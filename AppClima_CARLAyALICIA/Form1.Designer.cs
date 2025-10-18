using System.Drawing;
using System.Windows.Forms;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private Button btnConectar;
    private Button btnObtenerSensores;
    private Button btnLecturasCompletas;
    private Button btnCalcularClima;
    private ListBox listSensores;
    private DataGridView gridLecturas;
    private Label lblTemperatura;
    private Label lblHumedad;
    private Label lblViento;
    private Label lblCalidadAire;
    private TextBox txtResumen;
    private ProgressBar progressBar;
    private Label lblEstado;
    private ComboBox cmbSensor;
    private Button btnLecturasSensor;
    private Label lblTitulo;

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
        this.ClientSize = new System.Drawing.Size(900, 600);
        this.Text = "Sistema de Calidad del Aire";

        CrearControles();
        PosicionarControles();
    }

    private void CrearControles()
    {
        lblTitulo = new Label();
        lblTitulo.Text = "Monitoreo de Calidad del Aire y Clima";
        lblTitulo.Font = new Font("Arial", 16, FontStyle.Bold);

        btnConectar = new Button();
        btnConectar.Text = "Conectar API";
        btnConectar.BackColor = Color.LightGreen;

        btnObtenerSensores = new Button();
        btnObtenerSensores.Text = "Obtener Sensores";

        btnLecturasCompletas = new Button();
        btnLecturasCompletas.Text = "Lecturas Completas";

        btnLecturasSensor = new Button();
        btnLecturasSensor.Text = "Lecturas del Sensor";

        btnCalcularClima = new Button();
        btnCalcularClima.Text = "Calcular Clima";
        btnCalcularClima.BackColor = Color.LightBlue;

        listSensores = new ListBox();
        listSensores.Font = new Font("Consolas", 9);

        gridLecturas = new DataGridView();
        gridLecturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        lblTemperatura = new Label();
        lblTemperatura.Text = "Temperatura: --°C";
        lblTemperatura.BorderStyle = BorderStyle.FixedSingle;

        lblHumedad = new Label();
        lblHumedad.Text = "Humedad: --%";
        lblHumedad.BorderStyle = BorderStyle.FixedSingle;

        lblViento = new Label();
        lblViento.Text = "Viento: -- m/s --";
        lblViento.BorderStyle = BorderStyle.FixedSingle;

        lblCalidadAire = new Label();
        lblCalidadAire.Text = "Calidad Aire: --";
        lblCalidadAire.BorderStyle = BorderStyle.FixedSingle;

        txtResumen = new TextBox();
        txtResumen.Multiline = true;
        txtResumen.ScrollBars = ScrollBars.Vertical;
        txtResumen.Font = new Font("Arial", 9);

        progressBar = new ProgressBar();
        progressBar.Style = ProgressBarStyle.Marquee;
        progressBar.Visible = false;

        lblEstado = new Label();
        lblEstado.Text = "Listo";
        lblEstado.ForeColor = Color.Blue;

        cmbSensor = new ComboBox();
        cmbSensor.DropDownStyle = ComboBoxStyle.DropDownList;

        AgregarControles();
    }

    private void AgregarControles()
    {
        Controls.Add(lblTitulo);
        Controls.Add(btnConectar);
        Controls.Add(btnObtenerSensores);
        Controls.Add(btnLecturasCompletas);
        Controls.Add(btnLecturasSensor);
        Controls.Add(btnCalcularClima);
        Controls.Add(listSensores);
        Controls.Add(gridLecturas);
        Controls.Add(lblTemperatura);
        Controls.Add(lblHumedad);
        Controls.Add(lblViento);
        Controls.Add(lblCalidadAire);
        Controls.Add(txtResumen);
        Controls.Add(progressBar);
        Controls.Add(lblEstado);
        Controls.Add(cmbSensor);
    }

    private void PosicionarControles()
    {
        lblTitulo.Location = new Point(20, 10);
        lblTitulo.Size = new Size(400, 30);

        btnConectar.Location = new Point(20, 50);
        btnConectar.Size = new Size(120, 30);

        btnObtenerSensores.Location = new Point(150, 50);
        btnObtenerSensores.Size = new Size(120, 30);

        cmbSensor.Location = new Point(280, 50);
        cmbSensor.Size = new Size(150, 30);

        btnLecturasSensor.Location = new Point(440, 50);
        btnLecturasSensor.Size = new Size(140, 30);

        btnLecturasCompletas.Location = new Point(590, 50);
        btnLecturasCompletas.Size = new Size(140, 30);

        btnCalcularClima.Location = new Point(740, 50);
        btnCalcularClima.Size = new Size(120, 30);

        listSensores.Location = new Point(20, 90);
        listSensores.Size = new Size(300, 200);

        gridLecturas.Location = new Point(330, 90);
        gridLecturas.Size = new Size(530, 200);

        lblTemperatura.Location = new Point(20, 300);
        lblTemperatura.Size = new Size(200, 25);

        lblHumedad.Location = new Point(230, 300);
        lblHumedad.Size = new Size(200, 25);

        lblViento.Location = new Point(440, 300);
        lblViento.Size = new Size(200, 25);

        lblCalidadAire.Location = new Point(650, 300);
        lblCalidadAire.Size = new Size(200, 25);

        txtResumen.Location = new Point(20, 340);
        txtResumen.Size = new Size(830, 150);

        progressBar.Location = new Point(20, 500);
        progressBar.Size = new Size(830, 20);

        lblEstado.Location = new Point(20, 530);
        lblEstado.Size = new Size(830, 20);
    }
}

internal struct NewStruct
{
    public object Item1;
    public object Item2;

    public NewStruct(object item1, object item2)
    {
        Item1 = item1;
        Item2 = item2;
    }

    public override bool Equals(object obj)
    {
        return obj is NewStruct other &&
               System.Collections.Generic.EqualityComparer<object>.Default.Equals(Item1, other.Item1) &&
               System.Collections.Generic.EqualityComparer<object>.Default.Equals(Item2, other.Item2);
    }

    public override int GetHashCode()
    {
        int hashCode = -1030903623;
        hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<object>.Default.GetHashCode(Item1);
        hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<object>.Default.GetHashCode(Item2);
        return hashCode;
    }

    public void Deconstruct(out object item1, out object item2)
    {
        item1 = Item1;
        item2 = Item2;
    }

    public static implicit operator (object, object)(NewStruct value)
    {
        return (value.Item1, value.Item2);
    }

    public static implicit operator NewStruct((object, object) value)
    {
        return new NewStruct(value.Item1, value.Item2);
    }
}