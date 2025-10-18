using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public partial class Form1 : Form
{
    private ClienteCalidadAire cliente;
    private CalculadorMeteorologico calculador;
    private List<Muestra> muestrasActuales;

    public Form1()
    {
        InitializeComponent();
        cliente = new ClienteCalidadAire();
        muestrasActuales = new List<Muestra>();
        ConfigurarEventos();
    }

    private void ConfigurarEventos()
    {
        btnConectar.Click += async (s, e) => await ConectarAPI();
        btnObtenerSensores.Click += async (s, e) => await ObtenerSensores();
        btnLecturasCompletas.Click += async (s, e) => await ObtenerLecturasCompletas();
        btnLecturasSensor.Click += async (s, e) => await ObtenerLecturasSensor();
        btnCalcularClima.Click += (s, e) => CalcularDatosClima();
    }

    private async System.Threading.Tasks.Task ConectarAPI()
    {
        MostrarProgreso(true, "Conectando");

        try
        {
            bool conectado = await cliente.VerificarSaludAsync();

            if (conectado)
            {
                ActualizarEstado("API conectada", Color.Green);
                btnConectar.BackColor = Color.Green;
                btnConectar.Enabled = false;
            }
            else
            {
                ActualizarEstado("No se pudo conectar con la API", Color.Red);
            }
        }
        catch (Exception ex)
        {
            ActualizarEstado($" Error: {ex.Message}", Color.Red);
        }
        finally
        {
            MostrarProgreso(false, "");
        }
    }

    private async System.Threading.Tasks.Task ObtenerSensores()
    {
        MostrarProgreso(true, "");

        try
        {
            var sensores = await cliente.ObtenerSensoresAsync();

            listSensores.Items.Clear();
            cmbSensor.Items.Clear();

            foreach (var sensor in sensores)
            {
                string infoSensor = $"{sensor.Id} - {sensor.Modelo}";
                listSensores.Items.Add(infoSensor);
                cmbSensor.Items.Add(sensor.Id);
            }

            if (cmbSensor.Items.Count > 0)
                cmbSensor.SelectedIndex = 0;

            ActualizarEstado($" {sensores.Count} sensores encontrados", Color.Green);
        }
        catch (Exception ex)
        {
            ActualizarEstado($"Error: {ex.Message}", Color.Red);
        }
        finally
        {
            MostrarProgreso(false, "");
        }
    }

    private async System.Threading.Tasks.Task ObtenerLecturasCompletas()
    {
        MostrarProgreso(true, "Obteniendo lecturas");

        try
        {
            var resultado = await cliente.ObtenerTodasLasLecturasAsync(5);
            muestrasActuales = resultado.Datos;

            MostrarLecturasEnGrid(muestrasActuales);
            ActualizarEstado($"{resultado.Cantidad} lecturas obtenidas", Color.Green);
        }
        catch (Exception ex)
        {
            ActualizarEstado($"Error: {ex.Message}", Color.Red);
        }
        finally
        {
            MostrarProgreso(false, "");
        }
    }

    private async System.Threading.Tasks.Task ObtenerLecturasSensor()
    {
        if (cmbSensor.SelectedItem == null)
        {
            MessageBox.Show("Seleccione un sensor");
            return;
        }

        string sensorId = cmbSensor.SelectedItem.ToString();
        MostrarProgreso(true, $"Obteniendo lecturas del sensor {sensorId}");

        try
        {
            var resultado = await cliente.ObtenerLecturasSensorAsync(sensorId, 10);
            muestrasActuales = resultado.Datos;

            MostrarLecturasEnGrid(muestrasActuales);
            ActualizarEstado($" {resultado.Cantidad} lecturas de {sensorId}", Color.Green);
        }
        catch (Exception ex)
        {
            ActualizarEstado($"Error: {ex.Message}", Color.Red);
        }
        finally
        {
            MostrarProgreso(false, "");
        }
    }

    private void CalcularDatosClima()
    {
        if (!muestrasActuales.Any())
        {
            MessageBox.Show("No hay lecturas para calcular");
            return;
        }

        try
        {
            calculador = new CalculadorMeteorologico(muestrasActuales);

            double temperatura = calculador.CalcularTemperaturaMedia();
            double humedad = calculador.CalcularHumedadRelativaMedia();
            double velocidadViento = calculador.CalcularVelocidadVientoMedia();
            string direccionViento = calculador.ObtenerDireccionVientoPredominante();
            double indiceCalor = calculador.CalcularIndiceCalor();
            double puntoRocio = calculador.CalcularPuntoRocio();

            lblTemperatura.Text = $"Temperatura: {temperatura}°C";
            lblHumedad.Text = $"Humedad: {humedad}%";
            lblViento.Text = $"Viento: {velocidadViento} m/s {direccionViento}";

            var calidadAire = calculador.CalcularCalidadAire();
            string calidadTexto = calidadAire.Any() ?
                $"{calidadAire.Count} contaminantes" : "Sin datos";
            lblCalidadAire.Text = $"Calidad Aire: {calidadTexto}";

            string resumen = $"RESUMEN METEOROLÓGICO:\n";
            resumen += $"• Temperatura: {temperatura}°C\n";
            resumen += $"• Sensación térmica: {indiceCalor}°C\n";
            resumen += $"• Humedad relativa: {humedad}%\n";
            resumen += $"• Punto de rocío: {puntoRocio}°C\n";
            resumen += $"• Viento: {velocidadViento} m/s desde {direccionViento}\n";
            resumen += $"• Índice UV máximo: {calculador.CalcularIndiceUVMaximo()}\n";
            resumen += $"• Precipitación: {calculador.CalcularPrecipitacionAcumulada():F2} mm\n";

            resumen += $"\nCALIDAD DEL AIRE:\n";
            foreach (var contaminante in calidadAire)
            {
                resumen += $"• {contaminante.Key}: {contaminante.Value:F2}\n";
            }

            txtResumen.Text = resumen;
            ActualizarEstado("Cálculos completados", Color.Green);
        }
        catch (Exception ex)
        {
            ActualizarEstado($"Error en cálculos: {ex.Message}", Color.Red);
        }
    }

    private void MostrarLecturasEnGrid(List<Muestra> lecturas)
    {
        gridLecturas.DataSource = lecturas.Select(l => new
        {
            l.IdSensor,
            l.Variable,
            l.Valor,
            l.Unidad,
            FechaHora = l.FechaHora.ToString("HH:mm:ss")
        }).ToList();
    }

    private void MostrarProgreso(bool mostrar, string mensaje)
    {
        progressBar.Visible = mostrar;
        progressBar.Style = mostrar ? ProgressBarStyle.Marquee : ProgressBarStyle.Blocks;

        if (!string.IsNullOrEmpty(mensaje))
            ActualizarEstado(mensaje, Color.Blue);
    }

    private void AgregarBotonRegresar()
    {
        var btnRegresar = new System.Windows.Forms.Button();
        btnRegresar.Text = "← Regresar al Clima";
        btnRegresar.Location = new Point(20, 560);
        btnRegresar.Size = new Size(150, 35);
        btnRegresar.BackColor = Color.FromArgb(0, 122, 255);
        btnRegresar.ForeColor = Color.White;
        btnRegresar.FlatStyle = FlatStyle.Flat;
        btnRegresar.FlatAppearance.BorderSize = 0;
        btnRegresar.Click += (s, e) => {
            this.Close();
        };
        this.Controls.Add(btnRegresar);
    }
    private void ActualizarEstado(string mensaje, Color color)
    {
        lblEstado.Text = mensaje;
        lblEstado.ForeColor = color;
    }
}
