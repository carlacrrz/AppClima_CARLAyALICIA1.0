using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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
    private PictureBox pictureBoxIconoClima;


    public FormClima()
    {
        InitializeComponent();

        cliente = new ClienteCalidadAire();
        muestrasActuales = new List<Muestra>();
        ConfigurarInterfaz();
        ConfigurarTimer();
        ConfigurarEventos();
        CargarDatosIniciales();
        ConfigurarBotonCerrar();
        ConfigurarLabelCentrado();
        CrearPictureBoxIcono();

        this.Load += (s, e) => AgregarIconosSencillos();


        Panel[] paneles = { panel1,panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10};

        foreach (Panel panel in paneles)
        {
            panel.BorderStyle = BorderStyle.None;
            panel.BackColor = Color.FromArgb(10, 255, 165, 0);
            panel.Padding = new Padding(0);
            panel.Margin = new Padding(0);
        }

    }

    private void ConfigurarInterfaz()
    {   
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.None;

        ConfigurarBordesRedondos();
        this.Resize += (s, e) => ConfigurarBordesRedondos();
    }

    private void CrearPictureBoxIcono()
    {
        pictureBoxIconoClima = new PictureBox();
        pictureBoxIconoClima.Name = "pictureBoxIconoClima";
        pictureBoxIconoClima.Size = new Size(50, 50);

        pictureBoxIconoClima.Location = new Point(
            lblDescripcionClima.Left - 60,
            lblDescripcionClima.Top - 5
        );
        pictureBoxIconoClima.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBoxIconoClima.BackColor = Color.Transparent;

        
        this.Controls.Add(pictureBoxIconoClima);
        pictureBoxIconoClima.BringToFront();
    }

    private void ConfigurarBordesRedondos()
    {

        this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));

        HacerBordesRedondos(panelEstadisticas, 20);
        HacerBordesRedondos(panelCalidadAire, 20);
        HacerBordesRedondos(panel1, 60);
        HacerBordesRedondos(panel2, 60);
        HacerBordesRedondos(panel3, 60);
        HacerBordesRedondos(panel4, 60);
        HacerBordesRedondos(panel5, 60);
        HacerBordesRedondos(panel6, 60);
        HacerBordesRedondos(panel7, 60);
        HacerBordesRedondos(panel8, 60);
        HacerBordesRedondos(panel9, 60);
        HacerBordesRedondos(panel10, 60);
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
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private void ActualizarUI()
    {
        if (calculador == null) return;

        lblTemperaturaPrincipal.Text = calculador.CalcularTemperaturaMedia().ToString("F0") + "°";
        lblDescripcionClima.Text = ObtenerDescripcionClima();
        lblUbicacion.Text = "Puerto Peñasco, Son.";
        lblMaxMin.Text = (calculador.CalcularTemperaturaMedia() + 2).ToString("Maxima: 0") + "° / " + (calculador.CalcularTemperaturaMedia() - 2).ToString("Minima: 0") + "°";

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
        if (calculador == null)
        {
            pictureBoxIconoClima.Image = AppClima_CARLAyALICIA.Properties.Resources.foto1;
            return "Cargando...";
        }

        var temp = calculador.CalcularTemperaturaMedia();
        var humedad = calculador.CalcularHumedadRelativaMedia();
        var lluvia = calculador.CalcularPrecipitacionAcumulada();
        var probabilidadLluvia = CalcularProbabilidadLluvia();




        if (probabilidadLluvia > 60 || lluvia > 2)
        {
            pictureBoxIconoClima.Image = AppClima_CARLAyALICIA.Properties.Resources.foto1;
                    ;
            return "Lluvia intensa";
        }
        else if (probabilidadLluvia > 15 || lluvia > 0.5)
        {
            pictureBoxIconoClima.Image = AppClima_CARLAyALICIA.Properties.Resources.foto1;
            return "Lluvia ligera";
        }
        else if (probabilidadLluvia > 0.5)
        {
            pictureBoxIconoClima.Image = AppClima_CARLAyALICIA.Properties.Resources.foto1;
            return "Parcialmente nublado";
        }
        else if (humedad > 85)
        {
            pictureBoxIconoClima.Image = AppClima_CARLAyALICIA.Properties.Resources.foto1;
            return "Nublado";
        }
        else if (humedad > 70)
        {
            pictureBoxIconoClima.Image = AppClima_CARLAyALICIA.Properties.Resources.foto1;
            return "Húmedo";
        }
        else if (temp > 30)
        {
            pictureBoxIconoClima.Image = AppClima_CARLAyALICIA.Properties.Resources.foto1;
            return "Soleado";
        }
        else
        {
            pictureBoxIconoClima.Image = AppClima_CARLAyALICIA.Properties.Resources.foto1;
            return "Despejado";
        }
    }

    private double CalcularProbabilidadLluvia()
    {
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
            case "La calidad de aire es buena": color = Color.FromArgb(76, 175, 80); break;
            case "La calidad de aire es moderada": color = Color.FromArgb(255, 193, 7); break;
            case "La calidad de aire es poco saludable": color = Color.FromArgb(255, 152, 0); break;
            case "Mala": color = Color.FromArgb(244, 67, 54); break;
            default: color = Color.Gray; break;
        }

        panelCalidadAire.BackColor = color;
        lblIndiceCalidadAire.ForeColor = color;
    }

    private void AgregarIconosSencillos()
    {
        var iconosMap = new Dictionary<string, string>
    {
        { "lblSensacionTermina", "termostato.png" },
        { "lblProbabilidadLluvia", "lluvia.png" },
        { "lblHumedad", "humedad.png" },
        { "lblPresion", "medir.png" },
        { "lblPuntoRocio", "rocio.png" },
        { "lblIndiceUV", "indice-uv.png" },
        { "lblVelocidadViento", "ventoso.png" },
        { "lblDireccionViento", "direccion-del-viento.png" },
        { "lblVisibilidad", "visibilidad.png" },
        { "label1", "aire.png" }
    };

        string carpetaIconos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "iconos");

        foreach (var item in iconosMap)
        {
            Control[] labelsEncontrados = this.Controls.Find(item.Key, true);

            if (labelsEncontrados.Length > 0 && labelsEncontrados[0] is Label label)
            {
                string rutaIcono = Path.Combine(carpetaIconos, item.Value);

                if (File.Exists(rutaIcono))
                {
                    AgregarIconoALabel(label, rutaIcono, item.Key);
                }
            }
        }
    }

    private void AgregarIconoALabel(Label label, string rutaIcono, string nombreLabel)
    {
        try
        {
            PictureBox icono = new PictureBox();
            icono.Name = label.Name + "icono_";
            icono.Size = new Size(20, 20);
            icono.Location = new Point(label.Right, label.Top + 5);
            icono.SizeMode = PictureBoxSizeMode.Zoom;
            icono.BackColor = Color.Transparent;
            icono.Image = Image.FromFile(rutaIcono);

            label.Parent.Controls.Add(icono);
            icono.BringToFront();

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error {ex.Message}");
        }
    }

    private void ConfigurarLabelCentrado()
    {
        lblCalidadAire.TextAlign = ContentAlignment.MiddleCenter;
        lblCalidadAire.AutoSize = false;
        lblCalidadAire.Size = panelCalidadAire.Size;

        lblCalidadAire.TextChanged += (s, e) => CentrarLabelEnPanel();

        panelCalidadAire.SizeChanged += (s, e) => CentrarLabelEnPanel();
    }

    private void CentrarLabelEnPanel()
    {
        lblCalidadAire.Location = new Point(
            (panelCalidadAire.Width - lblCalidadAire.Width) / 2,
            (panelCalidadAire.Height - lblCalidadAire.Height) / 2
        );
    }

    private void ConfigurarBotonCerrar()
    {
        btnCerrar.FlatStyle = FlatStyle.Flat;
        btnCerrar.FlatAppearance.BorderSize = 0;
        btnCerrar.BackColor = Color.Transparent;
        btnCerrar.ForeColor = Color.White;
        btnCerrar.Text = "X"; 
        btnCerrar.Font = new Font("Arial", 14, FontStyle.Bold);

        btnCerrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
        btnCerrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
    }
    private void btnCerrar_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void lblIndiceCalidadAire_Click(object sender, EventArgs e)
    {

    }

    private void panelEstadisticas_Paint(object sender, PaintEventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void FormClima_Load(object sender, EventArgs e)
    {

    }
}