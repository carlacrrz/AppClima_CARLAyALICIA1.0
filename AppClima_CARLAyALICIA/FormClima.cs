using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public partial class FormClima : Form
{
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
        int nWidthEllipse, int nHeightEllipse
    );


    private ClienteCalidadAire cliente;
    private CalculadorMeteorologico calculador;
    private Timer timerActualizacion;
    private List<Muestra> muestrasActuales;

    public FormClima()
    {
        InitializeComponent();
        cliente = new ClienteCalidadAire();
        muestrasActuales = new List<Muestra>();
        ConfigurarInterfaz();
        ConfigurarTimer();
        ConfigurarEventos();
        CargarDatosIniciales();
    }

    private void ConfigurarInterfaz()
    {
        this.BackColor = Color.FromArgb(0, 122, 255);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.None;

        ConfigurarBordesRedondos();
        this.Resize += (s, e) => ConfigurarBordesRedondos();
    }

    private void ConfigurarBordesRedondos()
    {
        // Form principal - bordes redondos
        this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));

        // Paneles
        HacerBordesRedondos(panel1, 20);
        HacerBordesRedondos(panelCalidadAire, 20);

        // Botones
        HacerBordesRedondos(btnVerSensores, 15);
        HacerBordesRedondos(btnCerrar, 17);
    }

    private void HacerBordesRedondos(Control control, int radio)
    {
        control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, radio, radio));
    }

    private void ConfigurarTimer()
    {
        timerActualizacion = new Timer();
        timerActualizacion.Interval = 30000;
        timerActualizacion.Tick += async (s, e) => await ActualizarDatos();
        timerActualizacion.Start();
    }

    private void ConfigurarEventos()
    {
        btnVerSensores.Click += btnVerSensores_Click;
        btnCerrar.Click += btnCerrar_Click;
    }

    private async void CargarDatosIniciales()
    {
        await ActualizarDatos();
    }

    private async System.Threading.Tasks.Task ActualizarDatos()
    {
        try
        {
            var resultado = await cliente.ObtenerTodasLasLecturasAsync(3);
            muestrasActuales = resultado.Datos;

            if (muestrasActuales.Any())
            {
                calculador = new CalculadorMeteorologico(muestrasActuales);
                ActualizarUI();
            }
        }
        catch (Exception ex)
        {
            lblUbicacion.Text = "Error cargando datos";
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private void ActualizarUI()
    {
        if (calculador == null) return;

        lblTemperaturaPrincipal.Text = calculador.CalcularTemperaturaMedia().ToString("F0") + "°";
        lblDescripcionClima.Text = ObtenerDescripcionClima();
        lblUbicacion.Text = "Puerto Peñasco, Son.";
        lblMaxMin.Text = (calculador.CalcularTemperaturaMedia() + 2).ToString("F0") + "° / " + (calculador.CalcularTemperaturaMedia() - 2).ToString("F0") + "°";

        lblSensacionTermicaValor.Text = calculador.CalcularIndiceCalor().ToString("F1") + "°";
        lblProbabilidadLluviaValor.Text = CalcularProbabilidadLluvia().ToString("F0") + "%";
        lblHumedadValor.Text = calculador.CalcularHumedadRelativaMedia().ToString("F0") + "%";
        lblPresionValor.Text = calculador.CalcularPresionAtmosfericaMedia().ToString("F0") + " hPa";
        lblPuntoRocioValor.Text = calculador.CalcularPuntoRocio().ToString("F1") + "°";
        lblIndiceUVValor.Text = calculador.CalcularIndiceUVMaximo().ToString("F1");
        lblVelocidadVientoValor.Text = calculador.CalcularVelocidadVientoMedia().ToString("F1") + " m/s";
        lblDireccionVientoValor.Text = calculador.ObtenerDireccionVientoPredominante();
        lblVisibilidadValor.Text = CalcularVisibilidad().ToString("F1") + " km";

        var calidadAire = calculador.CalcularCalidadAire();
        lblCalidadAire.Text = ObtenerCalidadAireTexto(calidadAire);
        lblIndiceCalidadAire.Text = CalcularICA(calidadAire).ToString("F0");

        ActualizarColoresCalidadAire(calidadAire);
    }

   
    private string ObtenerDescripcionClima()
    {
        if (calculador == null) return "Cargando...";

        var temp = calculador.CalcularTemperaturaMedia();
        var humedad = calculador.CalcularHumedadRelativaMedia();
        var lluvia = calculador.CalcularPrecipitacionAcumulada();

        if (lluvia > 5) return "Lluvia intensa";
        if (lluvia > 1) return "Lluvia ligera";
        if (humedad > 80) return "Húmedo";
        if (temp > 30) return "Soleado";
        if (temp > 20) return "Parcialmente nublado";
        return "Despejado";
    }

    private double CalcularProbabilidadLluvia()
    {
        if (calculador == null) return 0;

        var humedad = calculador.CalcularHumedadRelativaMedia();
        var presion = calculador.CalcularPresionAtmosfericaMedia();

        double probabilidad = (humedad - 50) * 1.2;
        if (presion < 1010) probabilidad += 20;

        return Math.Max(0, Math.Min(100, probabilidad));
    }

    private double CalcularVisibilidad()
    {
        var pm25 = muestrasActuales
            .Where(m => m.Variable == "PM2.5")
            .Select(m => m.Valor)
            .DefaultIfEmpty(10)
            .Average();

        double visibilidad = 20 - (pm25 / 5);
        return Math.Max(2, Math.Min(20, visibilidad));
    }

    private string ObtenerCalidadAireTexto(Dictionary<string, double> calidadAire)
    {
        if (!calidadAire.Any()) return "Sin datos";

        var pm25 = calidadAire.ContainsKey("PM2.5") ? calidadAire["PM2.5"] : 0;

        if (pm25 < 12) return "La calidad de aire es buena";
        if (pm25 < 35) return "La calidad de aire es moderada";
        if (pm25 < 55) return "La calidad de aire es poco saludable";
        return "Mala";
    }

    private double CalcularICA(Dictionary<string, double> calidadAire)
    {
        if (!calidadAire.Any()) return 0;

        var pm25 = calidadAire.ContainsKey("PM2.5") ? calidadAire["PM2.5"] : 0;
        return (pm25 / 35) * 100;
    }

    private void ActualizarColoresCalidadAire(Dictionary<string, double> calidadAire)
    {
        var calidad = ObtenerCalidadAireTexto(calidadAire);
        Color color;

        switch (calidad)
        {
            case "Buena": color = Color.FromArgb(76, 175, 80); break;
            case "Moderada": color = Color.FromArgb(255, 193, 7); break;
            case "Poco saludable": color = Color.FromArgb(255, 152, 0); break;
            case "Mala": color = Color.FromArgb(244, 67, 54); break;
            default: color = Color.Gray; break;
        }

        panelCalidadAire.BackColor = color;
        lblIndiceCalidadAire.ForeColor = color;
    }

    private void btnVerSensores_Click(object sender, EventArgs e)
    {
        var formSensores = new Form1();
        formSensores.Show();
        this.Hide();

        formSensores.FormClosed += (s, args) => this.Show();
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void lblIndiceCalidadAire_Click(object sender, EventArgs e)
    {

    }

}