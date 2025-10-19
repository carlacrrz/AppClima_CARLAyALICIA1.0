using System.Windows.Forms;

partial class FormClima
{
    private System.ComponentModel.IContainer components = null;

    public new AutoScaleMode AutoScaleMode { get; private set; }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.lblCalidadAire = new System.Windows.Forms.Label();
            this.lblVisibilidadValor = new System.Windows.Forms.Label();
            this.lblVelocidadVientoValor = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblTemperaturaPrincipal = new System.Windows.Forms.Label();
            this.lblSensacionTermicaValor = new System.Windows.Forms.Label();
            this.lblPuntoRocioValor = new System.Windows.Forms.Label();
            this.lblProbabilidadLluviaValor = new System.Windows.Forms.Label();
            this.lblPresionValor = new System.Windows.Forms.Label();
            this.lblMaxMin = new System.Windows.Forms.Label();
            this.lblIndiceUVValor = new System.Windows.Forms.Label();
            this.lblHumedadValor = new System.Windows.Forms.Label();
            this.lblDireccionVientoValor = new System.Windows.Forms.Label();
            this.lblDescripcionClima = new System.Windows.Forms.Label();
            this.lblSensacionTermina = new System.Windows.Forms.Label();
            this.lblPresion = new System.Windows.Forms.Label();
            this.lblVelocidadviento = new System.Windows.Forms.Label();
            this.lblProbabilidadLluvia = new System.Windows.Forms.Label();
            this.lblPuntoRocio = new System.Windows.Forms.Label();
            this.lblDireccionViento = new System.Windows.Forms.Label();
            this.lblHumedad = new System.Windows.Forms.Label();
            this.lblIndiceUV = new System.Windows.Forms.Label();
            this.lblVisibilidad = new System.Windows.Forms.Label();
            this.btnVerSensores = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIndiceCalidadAire = new System.Windows.Forms.Label();
            this.panelCalidadAire = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelCalidadAire.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalidadAire
            // 
            this.lblCalidadAire.AutoSize = true;
            this.lblCalidadAire.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalidadAire.Location = new System.Drawing.Point(56, 29);
            this.lblCalidadAire.Name = "lblCalidadAire";
            this.lblCalidadAire.Size = new System.Drawing.Size(838, 86);
            this.lblCalidadAire.TabIndex = 15;
            this.lblCalidadAire.Text = "La calidad del aire es buena";
            this.lblCalidadAire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVisibilidadValor
            // 
            this.lblVisibilidadValor.AutoSize = true;
            this.lblVisibilidadValor.BackColor = System.Drawing.Color.Transparent;
            this.lblVisibilidadValor.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisibilidadValor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblVisibilidadValor.Location = new System.Drawing.Point(729, 351);
            this.lblVisibilidadValor.Name = "lblVisibilidadValor";
            this.lblVisibilidadValor.Size = new System.Drawing.Size(43, 50);
            this.lblVisibilidadValor.TabIndex = 1;
            this.lblVisibilidadValor.Text = "0";
            // 
            // lblVelocidadVientoValor
            // 
            this.lblVelocidadVientoValor.AutoSize = true;
            this.lblVelocidadVientoValor.BackColor = System.Drawing.Color.Transparent;
            this.lblVelocidadVientoValor.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidadVientoValor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblVelocidadVientoValor.Location = new System.Drawing.Point(50, 351);
            this.lblVelocidadVientoValor.Name = "lblVelocidadVientoValor";
            this.lblVelocidadVientoValor.Size = new System.Drawing.Size(43, 50);
            this.lblVelocidadVientoValor.TabIndex = 2;
            this.lblVelocidadVientoValor.Text = "0";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.BackColor = System.Drawing.Color.Transparent;
            this.lblUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUbicacion.Font = new System.Drawing.Font("Segoe UI Semibold", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.ForeColor = System.Drawing.Color.White;
            this.lblUbicacion.Location = new System.Drawing.Point(334, 22);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(514, 71);
            this.lblUbicacion.TabIndex = 3;
            this.lblUbicacion.Text = "Puerto Peñaco, Son.";
            // 
            // lblTemperaturaPrincipal
            // 
            this.lblTemperaturaPrincipal.AutoSize = true;
            this.lblTemperaturaPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperaturaPrincipal.Font = new System.Drawing.Font("Segoe UI Semibold", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperaturaPrincipal.ForeColor = System.Drawing.Color.Black;
            this.lblTemperaturaPrincipal.Location = new System.Drawing.Point(333, 54);
            this.lblTemperaturaPrincipal.Name = "lblTemperaturaPrincipal";
            this.lblTemperaturaPrincipal.Size = new System.Drawing.Size(356, 425);
            this.lblTemperaturaPrincipal.TabIndex = 4;
            this.lblTemperaturaPrincipal.Text = "0";
            // 
            // lblSensacionTermicaValor
            // 
            this.lblSensacionTermicaValor.AutoSize = true;
            this.lblSensacionTermicaValor.BackColor = System.Drawing.Color.Transparent;
            this.lblSensacionTermicaValor.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensacionTermicaValor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSensacionTermicaValor.Location = new System.Drawing.Point(50, 151);
            this.lblSensacionTermicaValor.Name = "lblSensacionTermicaValor";
            this.lblSensacionTermicaValor.Size = new System.Drawing.Size(43, 50);
            this.lblSensacionTermicaValor.TabIndex = 5;
            this.lblSensacionTermicaValor.Text = "0";
            // 
            // lblPuntoRocioValor
            // 
            this.lblPuntoRocioValor.AutoSize = true;
            this.lblPuntoRocioValor.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntoRocioValor.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoRocioValor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPuntoRocioValor.Location = new System.Drawing.Point(359, 255);
            this.lblPuntoRocioValor.Name = "lblPuntoRocioValor";
            this.lblPuntoRocioValor.Size = new System.Drawing.Size(43, 50);
            this.lblPuntoRocioValor.TabIndex = 6;
            this.lblPuntoRocioValor.Text = "0";
            // 
            // lblProbabilidadLluviaValor
            // 
            this.lblProbabilidadLluviaValor.AutoSize = true;
            this.lblProbabilidadLluviaValor.BackColor = System.Drawing.Color.Transparent;
            this.lblProbabilidadLluviaValor.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProbabilidadLluviaValor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProbabilidadLluviaValor.Location = new System.Drawing.Point(359, 151);
            this.lblProbabilidadLluviaValor.Name = "lblProbabilidadLluviaValor";
            this.lblProbabilidadLluviaValor.Size = new System.Drawing.Size(43, 50);
            this.lblProbabilidadLluviaValor.TabIndex = 7;
            this.lblProbabilidadLluviaValor.Text = "0";
            // 
            // lblPresionValor
            // 
            this.lblPresionValor.AutoSize = true;
            this.lblPresionValor.BackColor = System.Drawing.Color.Transparent;
            this.lblPresionValor.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresionValor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPresionValor.Location = new System.Drawing.Point(50, 255);
            this.lblPresionValor.Name = "lblPresionValor";
            this.lblPresionValor.Size = new System.Drawing.Size(43, 50);
            this.lblPresionValor.TabIndex = 8;
            this.lblPresionValor.Text = "0";
            // 
            // lblMaxMin
            // 
            this.lblMaxMin.AutoSize = true;
            this.lblMaxMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxMin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxMin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMaxMin.Location = new System.Drawing.Point(295, 280);
            this.lblMaxMin.Name = "lblMaxMin";
            this.lblMaxMin.Size = new System.Drawing.Size(194, 65);
            this.lblMaxMin.TabIndex = 9;
            this.lblMaxMin.Text = "67 8 89";
            this.lblMaxMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndiceUVValor
            // 
            this.lblIndiceUVValor.AutoSize = true;
            this.lblIndiceUVValor.BackColor = System.Drawing.Color.Transparent;
            this.lblIndiceUVValor.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndiceUVValor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIndiceUVValor.Location = new System.Drawing.Point(729, 255);
            this.lblIndiceUVValor.Name = "lblIndiceUVValor";
            this.lblIndiceUVValor.Size = new System.Drawing.Size(43, 50);
            this.lblIndiceUVValor.TabIndex = 10;
            this.lblIndiceUVValor.Text = "0";
            // 
            // lblHumedadValor
            // 
            this.lblHumedadValor.AutoSize = true;
            this.lblHumedadValor.BackColor = System.Drawing.Color.Transparent;
            this.lblHumedadValor.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumedadValor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblHumedadValor.Location = new System.Drawing.Point(729, 151);
            this.lblHumedadValor.Name = "lblHumedadValor";
            this.lblHumedadValor.Size = new System.Drawing.Size(43, 50);
            this.lblHumedadValor.TabIndex = 12;
            this.lblHumedadValor.Text = "0";
            // 
            // lblDireccionVientoValor
            // 
            this.lblDireccionVientoValor.AutoSize = true;
            this.lblDireccionVientoValor.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccionVientoValor.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionVientoValor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDireccionVientoValor.Location = new System.Drawing.Point(359, 351);
            this.lblDireccionVientoValor.Name = "lblDireccionVientoValor";
            this.lblDireccionVientoValor.Size = new System.Drawing.Size(43, 50);
            this.lblDireccionVientoValor.TabIndex = 13;
            this.lblDireccionVientoValor.Text = "0";
            // 
            // lblDescripcionClima
            // 
            this.lblDescripcionClima.AutoSize = true;
            this.lblDescripcionClima.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcionClima.Font = new System.Drawing.Font("Segoe UI Semibold", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionClima.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescripcionClima.Location = new System.Drawing.Point(392, 239);
            this.lblDescripcionClima.Name = "lblDescripcionClima";
            this.lblDescripcionClima.Size = new System.Drawing.Size(225, 71);
            this.lblDescripcionClima.TabIndex = 14;
            this.lblDescripcionClima.Text = "Soleado";
            this.lblDescripcionClima.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSensacionTermina
            // 
            this.lblSensacionTermina.AutoSize = true;
            this.lblSensacionTermina.BackColor = System.Drawing.Color.Transparent;
            this.lblSensacionTermina.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensacionTermina.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSensacionTermina.Location = new System.Drawing.Point(50, 116);
            this.lblSensacionTermina.Name = "lblSensacionTermina";
            this.lblSensacionTermina.Size = new System.Drawing.Size(336, 50);
            this.lblSensacionTermina.TabIndex = 15;
            this.lblSensacionTermina.Text = "Sensacion termica ";
            // 
            // lblPresion
            // 
            this.lblPresion.AutoSize = true;
            this.lblPresion.BackColor = System.Drawing.Color.Transparent;
            this.lblPresion.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPresion.Location = new System.Drawing.Point(50, 216);
            this.lblPresion.Name = "lblPresion";
            this.lblPresion.Size = new System.Drawing.Size(148, 50);
            this.lblPresion.TabIndex = 16;
            this.lblPresion.Text = "Presion";
            // 
            // lblVelocidadviento
            // 
            this.lblVelocidadviento.AutoSize = true;
            this.lblVelocidadviento.BackColor = System.Drawing.Color.Transparent;
            this.lblVelocidadviento.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidadviento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVelocidadviento.Location = new System.Drawing.Point(50, 316);
            this.lblVelocidadviento.Name = "lblVelocidadviento";
            this.lblVelocidadviento.Size = new System.Drawing.Size(364, 50);
            this.lblVelocidadviento.TabIndex = 17;
            this.lblVelocidadviento.Text = "Velocidad del viento";
            // 
            // lblProbabilidadLluvia
            // 
            this.lblProbabilidadLluvia.AutoSize = true;
            this.lblProbabilidadLluvia.BackColor = System.Drawing.Color.Transparent;
            this.lblProbabilidadLluvia.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProbabilidadLluvia.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProbabilidadLluvia.Location = new System.Drawing.Point(359, 116);
            this.lblProbabilidadLluvia.Name = "lblProbabilidadLluvia";
            this.lblProbabilidadLluvia.Size = new System.Drawing.Size(388, 50);
            this.lblProbabilidadLluvia.TabIndex = 18;
            this.lblProbabilidadLluvia.Text = "Probabilidad de lluvia";
            // 
            // lblPuntoRocio
            // 
            this.lblPuntoRocio.AutoSize = true;
            this.lblPuntoRocio.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntoRocio.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoRocio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPuntoRocio.Location = new System.Drawing.Point(359, 216);
            this.lblPuntoRocio.Name = "lblPuntoRocio";
            this.lblPuntoRocio.Size = new System.Drawing.Size(228, 50);
            this.lblPuntoRocio.TabIndex = 19;
            this.lblPuntoRocio.Text = "Punto rocio ";
            // 
            // lblDireccionViento
            // 
            this.lblDireccionViento.AutoSize = true;
            this.lblDireccionViento.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccionViento.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionViento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDireccionViento.Location = new System.Drawing.Point(359, 316);
            this.lblDireccionViento.Name = "lblDireccionViento";
            this.lblDireccionViento.Size = new System.Drawing.Size(359, 50);
            this.lblDireccionViento.TabIndex = 20;
            this.lblDireccionViento.Text = "Direccion del viento";
            // 
            // lblHumedad
            // 
            this.lblHumedad.AutoSize = true;
            this.lblHumedad.BackColor = System.Drawing.Color.Transparent;
            this.lblHumedad.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumedad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHumedad.Location = new System.Drawing.Point(729, 116);
            this.lblHumedad.Name = "lblHumedad";
            this.lblHumedad.Size = new System.Drawing.Size(187, 50);
            this.lblHumedad.TabIndex = 21;
            this.lblHumedad.Text = "Humedad";
            // 
            // lblIndiceUV
            // 
            this.lblIndiceUV.AutoSize = true;
            this.lblIndiceUV.BackColor = System.Drawing.Color.Transparent;
            this.lblIndiceUV.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndiceUV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIndiceUV.Location = new System.Drawing.Point(729, 216);
            this.lblIndiceUV.Name = "lblIndiceUV";
            this.lblIndiceUV.Size = new System.Drawing.Size(184, 50);
            this.lblIndiceUV.TabIndex = 22;
            this.lblIndiceUV.Text = "Indice UV";
            // 
            // lblVisibilidad
            // 
            this.lblVisibilidad.AutoSize = true;
            this.lblVisibilidad.BackColor = System.Drawing.Color.Transparent;
            this.lblVisibilidad.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisibilidad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVisibilidad.Location = new System.Drawing.Point(729, 316);
            this.lblVisibilidad.Name = "lblVisibilidad";
            this.lblVisibilidad.Size = new System.Drawing.Size(207, 50);
            this.lblVisibilidad.TabIndex = 23;
            this.lblVisibilidad.Text = "Visibilidad ";
            // 
            // btnVerSensores
            // 
            this.btnVerSensores.BackColor = System.Drawing.Color.DimGray;
            this.btnVerSensores.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSensores.Location = new System.Drawing.Point(699, 447);
            this.btnVerSensores.Name = "btnVerSensores";
            this.btnVerSensores.Size = new System.Drawing.Size(159, 46);
            this.btnVerSensores.TabIndex = 24;
            this.btnVerSensores.Text = "Ver Sensores";
            this.btnVerSensores.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Location = new System.Drawing.Point(867, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 42);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblIndiceCalidadAire);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblProbabilidadLluviaValor);
            this.panel1.Controls.Add(this.lblPresionValor);
            this.panel1.Controls.Add(this.btnVerSensores);
            this.panel1.Controls.Add(this.lblVisibilidadValor);
            this.panel1.Controls.Add(this.lblVelocidadVientoValor);
            this.panel1.Controls.Add(this.lblSensacionTermicaValor);
            this.panel1.Controls.Add(this.lblVisibilidad);
            this.panel1.Controls.Add(this.lblPuntoRocioValor);
            this.panel1.Controls.Add(this.lblIndiceUV);
            this.panel1.Controls.Add(this.lblIndiceUVValor);
            this.panel1.Controls.Add(this.lblHumedad);
            this.panel1.Controls.Add(this.lblHumedadValor);
            this.panel1.Controls.Add(this.lblDireccionViento);
            this.panel1.Controls.Add(this.lblDireccionVientoValor);
            this.panel1.Controls.Add(this.lblPuntoRocio);
            this.panel1.Controls.Add(this.lblSensacionTermina);
            this.panel1.Controls.Add(this.lblProbabilidadLluvia);
            this.panel1.Controls.Add(this.lblPresion);
            this.panel1.Controls.Add(this.lblVelocidadviento);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 556);
            this.panel1.TabIndex = 16;
            // 
            // lblIndiceCalidadAire
            // 
            this.lblIndiceCalidadAire.AutoSize = true;
            this.lblIndiceCalidadAire.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndiceCalidadAire.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIndiceCalidadAire.Location = new System.Drawing.Point(48, 430);
            this.lblIndiceCalidadAire.Name = "lblIndiceCalidadAire";
            this.lblIndiceCalidadAire.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIndiceCalidadAire.Size = new System.Drawing.Size(43, 50);
            this.lblIndiceCalidadAire.TabIndex = 16;
            this.lblIndiceCalidadAire.Text = "0";
            // 
            // panelCalidadAire
            // 
            this.panelCalidadAire.AllowDrop = true;
            this.panelCalidadAire.BackColor = System.Drawing.Color.Green;
            this.panelCalidadAire.Controls.Add(this.lblCalidadAire);
            this.panelCalidadAire.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelCalidadAire.Location = new System.Drawing.Point(156, 327);
            this.panelCalidadAire.Name = "panelCalidadAire";
            this.panelCalidadAire.Size = new System.Drawing.Size(614, 115);
            this.panelCalidadAire.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(50, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 50);
            this.label1.TabIndex = 17;
            this.label1.Text = "Calidad de aire";
            // 
            // FormClima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::AppClima_CARLAyALICIA.Properties.Resources.foto21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(945, 845);
            this.Controls.Add(this.panelCalidadAire);
            this.Controls.Add(this.lblMaxMin);
            this.Controls.Add(this.lblDescripcionClima);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTemperaturaPrincipal);
            this.Controls.Add(this.lblUbicacion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "FormClima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App de Clima";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCalidadAire.ResumeLayout(false);
            this.panelCalidadAire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private Label lblVisibilidadValor;
    private Label lblVelocidadVientoValor;
    private Label lblUbicacion;
    private Label lblTemperaturaPrincipal;
    private Label lblSensacionTermicaValor;
    private Label lblPuntoRocioValor;
    private Label lblProbabilidadLluviaValor;
    private Label lblPresionValor;
    private Label lblMaxMin;
    private Label lblIndiceUVValor;
    private Label lblHumedadValor;
    private Label lblDireccionVientoValor;
    private Label lblDescripcionClima;
    private Label lblCalidadAire;
    private Label lblSensacionTermina;
    private Label lblPresion;
    private Label lblVelocidadviento;
    protected internal Label lblProbabilidadLluvia;
    private Label lblPuntoRocio;
    private Label lblDireccionViento;
    private Label lblHumedad;
    private Label lblIndiceUV;
    private Label lblVisibilidad;
    private Button btnVerSensores;
    private Button btnCerrar;
    private ImageList imageList1;
    private Panel panel1;
    private Panel panelCalidadAire;
    private Label lblIndiceCalidadAire;
    private Label label1;
}