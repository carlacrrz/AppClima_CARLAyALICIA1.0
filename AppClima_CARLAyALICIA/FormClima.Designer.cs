using System;
using System.Drawing;
using System.Windows.Forms;

partial class FormClima
{
    private System.ComponentModel.IContainer components = null;
    private Panel panelHeader;
    private Label lblUbicacion;
    private Label lblTemperaturaPrincipal;
    private Label lblDescripcionClima;
    private Label lblMaxMin;
    private Panel panelContenido;
    private Button btnVerSensores;
    private Button btnCerrar;
    private Panel panelEstadisticas;
    private Label lblSensacionTermica;
    private Label lblSensacionTermicaValor;
    private Label lblProbabilidadLluvia;
    private Label lblProbabilidadLluviaValor;
    private Label lblHumedad;
    private Label lblHumedadValor;
    private Label lblPresion;
    private Label lblPresionValor;
    private Label lblPuntoRocio;
    private Label lblPuntoRocioValor;
    private Label lblIndiceUV;
    private Label lblIndiceUVValor;
    private Label lblVelocidadViento;
    private Label lblVelocidadVientoValor;
    private Label lblDireccionViento;
    private Label lblDireccionVientoValor;
    private Label lblVisibilidad;
    private Label lblVisibilidadValor;
    private Panel panelCalidadAire;
    private Label lblCalidadAire;
    private Label lblIndiceCalidadAire;
    private Label lblTituloCalidadAire;

    [System.Runtime.InteropServices.DllImport("Gdi32.dll")]
    private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1000, 700);
        this.Text = "Clima";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.Sizable;
        this.FormBorderStyle = FormBorderStyle.Sizable;
        this.MinimumSize = new System.Drawing.Size(900, 650);
        this.BackColor = Color.FromArgb(0, 122, 255);

        CrearControles();
        PosicionarControles();
        ConfigurarAnclajes();
        AplicarEstilos();
        ConfigurarEventos();
    }

    private void CrearControles()
    {
        panelHeader = new Panel();
        panelHeader.BackColor = Color.FromArgb(0, 122, 255);

        lblUbicacion = new Label();
        lblUbicacion.Text = "Cargando...";
        lblUbicacion.Font = new Font("Arial", 22, FontStyle.Regular);
        lblUbicacion.ForeColor = Color.White;
        lblUbicacion.TextAlign = ContentAlignment.MiddleCenter;

        lblTituloCalidadAire = new Label();
        lblTituloCalidadAire.Text = "CAalidad del aire";
        lblTituloCalidadAire.Font = new Font("Arial", 14, FontStyle.Bold);
        lblTituloCalidadAire.ForeColor = Color.FromArgb(80, 80, 80);
        lblTituloCalidadAire.TextAlign = ContentAlignment.MiddleLeft;

        lblTemperaturaPrincipal = new Label();
        lblTemperaturaPrincipal.Text = "--°";
        lblTemperaturaPrincipal.Font = new Font("Arial", 80, FontStyle.Regular);
        lblTemperaturaPrincipal.ForeColor = Color.White;
        lblTemperaturaPrincipal.TextAlign = ContentAlignment.MiddleCenter;

        lblDescripcionClima = new Label();
        lblDescripcionClima.Text = "Cargando...";
        lblDescripcionClima.Font = new Font("Arial", 26, FontStyle.Regular);
        lblDescripcionClima.ForeColor = Color.White;
        lblDescripcionClima.TextAlign = ContentAlignment.MiddleCenter;

        lblMaxMin = new Label();
        lblMaxMin.Text = "--° / --°";
        lblMaxMin.Font = new Font("Arial", 22, FontStyle.Regular);
        lblMaxMin.ForeColor = Color.White;
        lblMaxMin.TextAlign = ContentAlignment.MiddleCenter;

        panelContenido = new Panel();
        panelContenido.BackColor = Color.White;

        btnVerSensores = new Button();
        btnVerSensores.Text = "📊 Ver Sensores Detallados";
        btnVerSensores.FlatStyle = FlatStyle.Flat;
        btnVerSensores.BackColor = Color.FromArgb(0, 122, 255);
        btnVerSensores.ForeColor = Color.White;
        btnVerSensores.Font = new Font("Arial", 14, FontStyle.Regular);

        btnCerrar = new Button();
        btnCerrar.Text = "✕";
        btnCerrar.FlatStyle = FlatStyle.Flat;
        btnCerrar.BackColor = Color.Transparent;
        btnCerrar.ForeColor = Color.White;
        btnCerrar.Font = new Font("Arial", 16, FontStyle.Bold);

        panelEstadisticas = new Panel();
        panelEstadisticas.BackColor = Color.FromArgb(242, 242, 247);

        CrearLabelsEstadisticas();

        panelCalidadAire = new Panel();
        panelCalidadAire.BackColor = Color.FromArgb(76, 175, 80);

        lblCalidadAire = new Label();
        lblCalidadAire.Text = "Calidad del Aire";
        lblCalidadAire.Font = new Font("Arial", 20, FontStyle.Bold);
        lblCalidadAire.ForeColor = Color.White;

        lblIndiceCalidadAire = new Label();
        lblIndiceCalidadAire.Text = "--";
        lblIndiceCalidadAire.Font = new Font("Arial", 32, FontStyle.Bold);
        lblIndiceCalidadAire.ForeColor = Color.White;

        AgregarControles();
    }

    private void CrearLabelsEstadisticas()
    {
        lblSensacionTermica = CrearLabelTitulo("Sensación Térmica");
        lblSensacionTermicaValor = CrearLabelValor("--°");

        lblProbabilidadLluvia = CrearLabelTitulo("Probabilidad de Lluvia");
        lblProbabilidadLluviaValor = CrearLabelValor("--%");

        lblHumedad = CrearLabelTitulo("Humedad");
        lblHumedadValor = CrearLabelValor("--%");

        lblPresion = CrearLabelTitulo("Presión Atmosférica");
        lblPresionValor = CrearLabelValor("-- hPa");

        lblPuntoRocio = CrearLabelTitulo("Punto de Rocío");
        lblPuntoRocioValor = CrearLabelValor("--°");

        lblIndiceUV = CrearLabelTitulo("Índice UV");
        lblIndiceUVValor = CrearLabelValor("--");

        lblVelocidadViento = CrearLabelTitulo("Velocidad del Viento");
        lblVelocidadVientoValor = CrearLabelValor("-- m/s");

        lblDireccionViento = CrearLabelTitulo("Dirección del Viento");
        lblDireccionVientoValor = CrearLabelValor("--");

        lblVisibilidad = CrearLabelTitulo("Visibilidad");
        lblVisibilidadValor = CrearLabelValor("-- km");
    }

    private Label CrearLabelTitulo(string texto)
    {
        var label = new Label();
        label.Text = texto;
        label.Font = new Font("Arial", 12, FontStyle.Regular);
        label.ForeColor = Color.FromArgb(100, 100, 100);
        label.TextAlign = ContentAlignment.MiddleLeft;
        return label;
    }

    private Label CrearLabelValor(string texto)
    {
        var label = new Label();
        label.Text = texto;
        label.Font = new Font("Arial", 16, FontStyle.Bold);
        label.ForeColor = Color.FromArgb(60, 60, 67);
        label.TextAlign = ContentAlignment.MiddleLeft;
        return label;
    }

    private void AgregarControles()
    {
        panelHeader.Controls.Add(lblUbicacion);
        panelHeader.Controls.Add(lblTemperaturaPrincipal);
        panelHeader.Controls.Add(lblDescripcionClima);
        panelHeader.Controls.Add(lblMaxMin);
        panelHeader.Controls.Add(btnCerrar);

        panelCalidadAire.Controls.Add(lblCalidadAire);
        panelCalidadAire.Controls.Add(lblIndiceCalidadAire);

        panelEstadisticas.Controls.Add(lblSensacionTermica);
        panelEstadisticas.Controls.Add(lblSensacionTermicaValor);
        panelEstadisticas.Controls.Add(lblProbabilidadLluvia);
        panelEstadisticas.Controls.Add(lblProbabilidadLluviaValor);
        panelEstadisticas.Controls.Add(lblHumedad);
        panelEstadisticas.Controls.Add(lblHumedadValor);
        panelEstadisticas.Controls.Add(lblPresion);
        panelEstadisticas.Controls.Add(lblPresionValor);
        panelEstadisticas.Controls.Add(lblPuntoRocio);
        panelEstadisticas.Controls.Add(lblPuntoRocioValor);
        panelEstadisticas.Controls.Add(lblIndiceUV);
        panelEstadisticas.Controls.Add(lblIndiceUVValor);
        panelEstadisticas.Controls.Add(lblVelocidadViento);
        panelEstadisticas.Controls.Add(lblVelocidadVientoValor);
        panelEstadisticas.Controls.Add(lblDireccionViento);
        panelEstadisticas.Controls.Add(lblDireccionVientoValor);
        panelEstadisticas.Controls.Add(lblVisibilidad);
        panelEstadisticas.Controls.Add(lblVisibilidadValor);

        panelContenido.Controls.Add(lblTituloCalidadAire);
        panelContenido.Controls.Add(panelEstadisticas);
        panelContenido.Controls.Add(panelCalidadAire);
        panelContenido.Controls.Add(btnVerSensores);

        this.Controls.Add(panelHeader);
        this.Controls.Add(panelContenido);
    }

    private void PosicionarControles()
    {
        // Header - altura fija de 300px
        panelHeader.Location = new Point(0, 0);
        panelHeader.Size = new Size(this.ClientSize.Width, 300);

        lblUbicacion.Location = new Point(0, 60);
        lblUbicacion.Size = new Size(panelHeader.Width, 40);

        lblTemperaturaPrincipal.Location = new Point(0, 100);
        lblTemperaturaPrincipal.Size = new Size(panelHeader.Width, 100);

        lblDescripcionClima.Location = new Point(0, 200);
        lblDescripcionClima.Size = new Size(panelHeader.Width, 40);

        lblMaxMin.Location = new Point(0, 240);
        lblMaxMin.Size = new Size(panelHeader.Width, 40);

        btnCerrar.Location = new Point(panelHeader.Width - 50, 15);
        btnCerrar.Size = new Size(35, 35);

        // Contenido - ocupa el espacio restante
        panelContenido.Location = new Point(0, 300);
        panelContenido.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 300);

        // Calidad del aire
        panelCalidadAire.Location = new Point(40, 45);  
        panelCalidadAire.Size = new Size(panelContenido.Width - 80, 90);

        lblCalidadAire.Location = new Point(40, 25);
        lblCalidadAire.Size = new Size(400, 40);
        lblIndiceCalidadAire.Location = new Point(panelCalidadAire.Width - 120, 20);
        lblIndiceCalidadAire.Size = new Size(100, 50);

        // Estadísticas
        panelEstadisticas.Location = new Point(0, 155); 
        panelEstadisticas.Size = new Size(panelContenido.Width, panelContenido.Height - 235);

        // Botón ver sensores
        btnVerSensores.Location = new Point(40, panelContenido.Height - 70);
        btnVerSensores.Size = new Size(panelContenido.Width - 80, 50);

        // Actualizar posiciones del grid de estadísticas
        PosicionarGridEstadisticas();
    }

    private void PosicionarGridEstadisticas()
    {
        int columnWidth = panelEstadisticas.Width / 3;
        int x = 40, y = 30;

        var titulos = new[] {
            lblSensacionTermica, lblProbabilidadLluvia, lblHumedad,
            lblPresion, lblPuntoRocio, lblIndiceUV,
            lblVelocidadViento, lblDireccionViento, lblVisibilidad
        };
        var valores = new[] {
            lblSensacionTermicaValor, lblProbabilidadLluviaValor, lblHumedadValor,
            lblPresionValor, lblPuntoRocioValor, lblIndiceUVValor,
            lblVelocidadVientoValor, lblDireccionVientoValor, lblVisibilidadValor
        };

        for (int i = 0; i < titulos.Length; i++)
        {
            titulos[i].Location = new Point(x, y);
            titulos[i].Size = new Size(columnWidth - 80, 25);

            valores[i].Location = new Point(x, y + 30);
            valores[i].Size = new Size(columnWidth - 80, 30);

            if ((i + 1) % 3 == 0)
            {
                x = 40;
                y += 90;
            }
            else
            {
                x += columnWidth;
            }
        }
    }

    private void ConfigurarAnclajes()
    {
        // Panel header se ancla arriba, izquierda y derecha
        panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        // Panel contenido se ancla en todos los lados
        panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

        // Título calidad del aire se ancla arriba, izquierda y derecha
        lblTituloCalidadAire.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        // Panel estadísticas se ancla arriba, abajo, izquierda y derecha
        panelEstadisticas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

        // Panel calidad de aire se ancla arriba, izquierda y derecha
        panelCalidadAire.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        // Botón se ancla abajo, izquierda y derecha
        btnVerSensores.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

        // Labels del header se anclan al centro
        lblUbicacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblTemperaturaPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblDescripcionClima.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblMaxMin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        // Botón cerrar se ancla arriba a la derecha
        btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    }

    private void AplicarEstilos()
    {
        btnVerSensores.FlatAppearance.BorderSize = 0;
        btnCerrar.FlatAppearance.BorderSize = 0;

        AplicarBordesRedondeados();
    }

    private void AplicarBordesRedondeados()
    {
        panelContenido.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContenido.Width, panelContenido.Height, 40, 40));
        panelCalidadAire.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelCalidadAire.Width, panelCalidadAire.Height, 25, 25));
        btnVerSensores.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnVerSensores.Width, btnVerSensores.Height, 25, 25));
    }

    private void ConfigurarEventos()
    {
        btnVerSensores.Click += btnVerSensores_Click;
        btnCerrar.Click += btnCerrar_Click;

        // Redibujar cuando cambie el tamaño
        this.Resize += (s, e) => {
            PosicionarControles();
            AplicarBordesRedondeados();
        };
    }
}