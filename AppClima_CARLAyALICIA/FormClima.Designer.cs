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
            this.pictureBoxIconoClima = new System.Windows.Forms.PictureBox();
            this.lblCalidadAire = new System.Windows.Forms.Label();
            this.lblVisibilidadValor = new System.Windows.Forms.Label();
            this.lblVelocidadVientoValor = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblTemperaturaPrincipal = new System.Windows.Forms.Label();
            this.lblSensacionTermicaValor = new System.Windows.Forms.Label();
            this.lblPresionValor = new System.Windows.Forms.Label();
            this.lblMaxMin = new System.Windows.Forms.Label();
            this.lblIndiceUVValor = new System.Windows.Forms.Label();
            this.lblHumedadValor = new System.Windows.Forms.Label();
            this.lblDescripcionClima = new System.Windows.Forms.Label();
            this.lblSensacionTermina = new System.Windows.Forms.Label();
            this.lblPresion = new System.Windows.Forms.Label();
            this.lblVelocidadviento = new System.Windows.Forms.Label();
            this.lblHumedad = new System.Windows.Forms.Label();
            this.lblIndiceUV = new System.Windows.Forms.Label();
            this.lblVisibilidad = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.imageListClima = new System.Windows.Forms.ImageList(this.components);
            this.panelEstadisticas = new System.Windows.Forms.Panel();
            this.panelRecomendaciones = new System.Windows.Forms.Panel();
            this.flpRecomendaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRecomendacionesTitulo = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblPuntoRocio = new System.Windows.Forms.Label();
            this.lblPuntoRocioValor = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblDireccionViento = new System.Windows.Forms.Label();
            this.lblDireccionVientoValor = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblProbabilidadLluvia = new System.Windows.Forms.Label();
            this.lblProbabilidadLluviaValor = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIndiceCalidadAire = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCalidadAire = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoClima)).BeginInit();
            this.panelEstadisticas.SuspendLayout();
            this.panelRecomendaciones.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCalidadAire.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxIconoClima
            // 
            this.pictureBoxIconoClima.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIconoClima.Name = "pictureBoxIconoClima";
            this.pictureBoxIconoClima.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxIconoClima.TabIndex = 0;
            this.pictureBoxIconoClima.TabStop = false;
            // 
            // lblCalidadAire
            // 
            this.lblCalidadAire.AutoSize = true;
            this.lblCalidadAire.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalidadAire.Location = new System.Drawing.Point(56, 30);
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
            this.lblVisibilidadValor.Location = new System.Drawing.Point(26, 50);
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
            this.lblVelocidadVientoValor.Location = new System.Drawing.Point(23, 50);
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
            this.lblUbicacion.Location = new System.Drawing.Point(349, 22);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(514, 71);
            this.lblUbicacion.TabIndex = 3;
            this.lblUbicacion.Text = "Puerto Peñaco, Son.";
            // 
            // lblTemperaturaPrincipal
            // 
            this.lblTemperaturaPrincipal.AutoSize = true;
            this.lblTemperaturaPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperaturaPrincipal.Font = new System.Drawing.Font("Segoe UI", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperaturaPrincipal.ForeColor = System.Drawing.Color.Black;
            this.lblTemperaturaPrincipal.Location = new System.Drawing.Point(348, 33);
            this.lblTemperaturaPrincipal.Name = "lblTemperaturaPrincipal";
            this.lblTemperaturaPrincipal.Size = new System.Drawing.Size(351, 425);
            this.lblTemperaturaPrincipal.TabIndex = 4;
            this.lblTemperaturaPrincipal.Text = "0";
            // 
            // lblSensacionTermicaValor
            // 
            this.lblSensacionTermicaValor.AutoSize = true;
            this.lblSensacionTermicaValor.BackColor = System.Drawing.Color.Transparent;
            this.lblSensacionTermicaValor.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensacionTermicaValor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSensacionTermicaValor.Location = new System.Drawing.Point(23, 57);
            this.lblSensacionTermicaValor.Name = "lblSensacionTermicaValor";
            this.lblSensacionTermicaValor.Size = new System.Drawing.Size(43, 50);
            this.lblSensacionTermicaValor.TabIndex = 5;
            this.lblSensacionTermicaValor.Text = "0";
            // 
            // lblPresionValor
            // 
            this.lblPresionValor.AutoSize = true;
            this.lblPresionValor.BackColor = System.Drawing.Color.Transparent;
            this.lblPresionValor.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresionValor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPresionValor.Location = new System.Drawing.Point(23, 53);
            this.lblPresionValor.Name = "lblPresionValor";
            this.lblPresionValor.Size = new System.Drawing.Size(43, 50);
            this.lblPresionValor.TabIndex = 8;
            this.lblPresionValor.Text = "0";
            // 
            // lblMaxMin
            // 
            this.lblMaxMin.AutoSize = true;
            this.lblMaxMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxMin.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxMin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMaxMin.Location = new System.Drawing.Point(315, 251);
            this.lblMaxMin.Name = "lblMaxMin";
            this.lblMaxMin.Size = new System.Drawing.Size(188, 65);
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
            this.lblIndiceUVValor.Location = new System.Drawing.Point(25, 54);
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
            this.lblHumedadValor.Location = new System.Drawing.Point(26, 52);
            this.lblHumedadValor.Name = "lblHumedadValor";
            this.lblHumedadValor.Size = new System.Drawing.Size(43, 50);
            this.lblHumedadValor.TabIndex = 12;
            this.lblHumedadValor.Text = "0";
            // 
            // lblDescripcionClima
            // 
            this.lblDescripcionClima.AutoSize = true;
            this.lblDescripcionClima.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcionClima.Font = new System.Drawing.Font("Segoe UI Semibold", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionClima.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescripcionClima.Location = new System.Drawing.Point(394, 195);
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
            this.lblSensacionTermina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSensacionTermina.Location = new System.Drawing.Point(23, 20);
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
            this.lblPresion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPresion.Location = new System.Drawing.Point(23, 14);
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
            this.lblVelocidadviento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVelocidadviento.Location = new System.Drawing.Point(23, 16);
            this.lblVelocidadviento.Name = "lblVelocidadviento";
            this.lblVelocidadviento.Size = new System.Drawing.Size(364, 50);
            this.lblVelocidadviento.TabIndex = 17;
            this.lblVelocidadviento.Text = "Velocidad del viento";
            // 
            // lblHumedad
            // 
            this.lblHumedad.AutoSize = true;
            this.lblHumedad.BackColor = System.Drawing.Color.Transparent;
            this.lblHumedad.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHumedad.Location = new System.Drawing.Point(23, 23);
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
            this.lblIndiceUV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIndiceUV.Location = new System.Drawing.Point(25, 15);
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
            this.lblVisibilidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVisibilidad.Location = new System.Drawing.Point(26, 16);
            this.lblVisibilidad.Name = "lblVisibilidad";
            this.lblVisibilidad.Size = new System.Drawing.Size(207, 50);
            this.lblVisibilidad.TabIndex = 23;
            this.lblVisibilidad.Text = "Visibilidad ";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(850, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(70, 52);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // imageListClima
            // 
            this.imageListClima.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListClima.ImageSize = new System.Drawing.Size(24, 24);
            this.imageListClima.TransparentColor = System.Drawing.Color.Black;
            // 
            // panelEstadisticas
            // 
            this.panelEstadisticas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelEstadisticas.Controls.Add(this.panelRecomendaciones);
            this.panelEstadisticas.Controls.Add(this.panel10);
            this.panelEstadisticas.Controls.Add(this.panel9);
            this.panelEstadisticas.Controls.Add(this.panel8);
            this.panelEstadisticas.Controls.Add(this.panel6);
            this.panelEstadisticas.Controls.Add(this.panel7);
            this.panelEstadisticas.Controls.Add(this.panel5);
            this.panelEstadisticas.Controls.Add(this.panel4);
            this.panelEstadisticas.Controls.Add(this.panel3);
            this.panelEstadisticas.Controls.Add(this.panel2);
            this.panelEstadisticas.Controls.Add(this.panel1);
            this.panelEstadisticas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelEstadisticas.Location = new System.Drawing.Point(0, 398);
            this.panelEstadisticas.Name = "panelEstadisticas";
            this.panelEstadisticas.Size = new System.Drawing.Size(951, 658);
            this.panelEstadisticas.TabIndex = 16;
            // 
            // panelRecomendaciones
            // 
            this.panelRecomendaciones.BackColor = System.Drawing.Color.Gainsboro;
            this.panelRecomendaciones.Controls.Add(this.flpRecomendaciones);
            this.panelRecomendaciones.Controls.Add(this.lblRecomendacionesTitulo);
            this.panelRecomendaciones.Location = new System.Drawing.Point(326, 362);
            this.panelRecomendaciones.Name = "panelRecomendaciones";
            this.panelRecomendaciones.Size = new System.Drawing.Size(603, 109);
            this.panelRecomendaciones.TabIndex = 32;
            // 
            // flpRecomendaciones
            // 
            this.flpRecomendaciones.BackColor = System.Drawing.Color.Transparent;
            this.flpRecomendaciones.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpRecomendaciones.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.flpRecomendaciones.Location = new System.Drawing.Point(25, 59);
            this.flpRecomendaciones.Name = "flpRecomendaciones";
            this.flpRecomendaciones.Size = new System.Drawing.Size(401, 73);
            this.flpRecomendaciones.TabIndex = 19;
            // 
            // lblRecomendacionesTitulo
            // 
            this.lblRecomendacionesTitulo.AutoSize = true;
            this.lblRecomendacionesTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblRecomendacionesTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecomendacionesTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRecomendacionesTitulo.Location = new System.Drawing.Point(26, 22);
            this.lblRecomendacionesTitulo.Name = "lblRecomendacionesTitulo";
            this.lblRecomendacionesTitulo.Size = new System.Drawing.Size(326, 50);
            this.lblRecomendacionesTitulo.TabIndex = 18;
            this.lblRecomendacionesTitulo.Text = "Recomendaciones";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel10.Controls.Add(this.lblVisibilidad);
            this.panel10.Controls.Add(this.lblVisibilidadValor);
            this.panel10.Location = new System.Drawing.Point(642, 244);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(287, 108);
            this.panel10.TabIndex = 31;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel9.Controls.Add(this.lblIndiceUV);
            this.panel9.Controls.Add(this.lblIndiceUVValor);
            this.panel9.Location = new System.Drawing.Point(643, 122);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(286, 104);
            this.panel9.TabIndex = 30;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.Controls.Add(this.lblHumedad);
            this.panel8.Controls.Add(this.lblHumedadValor);
            this.panel8.Location = new System.Drawing.Point(642, 8);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(287, 104);
            this.panel8.TabIndex = 29;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Controls.Add(this.lblPuntoRocio);
            this.panel6.Controls.Add(this.lblPuntoRocioValor);
            this.panel6.Location = new System.Drawing.Point(326, 123);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(308, 103);
            this.panel6.TabIndex = 26;
            // 
            // lblPuntoRocio
            // 
            this.lblPuntoRocio.AutoSize = true;
            this.lblPuntoRocio.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntoRocio.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoRocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPuntoRocio.Location = new System.Drawing.Point(26, 14);
            this.lblPuntoRocio.Name = "lblPuntoRocio";
            this.lblPuntoRocio.Size = new System.Drawing.Size(228, 50);
            this.lblPuntoRocio.TabIndex = 19;
            this.lblPuntoRocio.Text = "Punto rocio ";
            // 
            // lblPuntoRocioValor
            // 
            this.lblPuntoRocioValor.AutoSize = true;
            this.lblPuntoRocioValor.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntoRocioValor.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoRocioValor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPuntoRocioValor.Location = new System.Drawing.Point(26, 53);
            this.lblPuntoRocioValor.Name = "lblPuntoRocioValor";
            this.lblPuntoRocioValor.Size = new System.Drawing.Size(43, 50);
            this.lblPuntoRocioValor.TabIndex = 6;
            this.lblPuntoRocioValor.Text = "0";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.Controls.Add(this.lblDireccionViento);
            this.panel7.Controls.Add(this.lblDireccionVientoValor);
            this.panel7.Location = new System.Drawing.Point(326, 244);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(308, 108);
            this.panel7.TabIndex = 26;
            // 
            // lblDireccionViento
            // 
            this.lblDireccionViento.AutoSize = true;
            this.lblDireccionViento.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccionViento.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionViento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDireccionViento.Location = new System.Drawing.Point(26, 16);
            this.lblDireccionViento.Name = "lblDireccionViento";
            this.lblDireccionViento.Size = new System.Drawing.Size(359, 50);
            this.lblDireccionViento.TabIndex = 20;
            this.lblDireccionViento.Text = "Direccion del viento";
            // 
            // lblDireccionVientoValor
            // 
            this.lblDireccionVientoValor.AutoSize = true;
            this.lblDireccionVientoValor.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccionVientoValor.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionVientoValor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDireccionVientoValor.Location = new System.Drawing.Point(26, 58);
            this.lblDireccionVientoValor.Name = "lblDireccionVientoValor";
            this.lblDireccionVientoValor.Size = new System.Drawing.Size(43, 50);
            this.lblDireccionVientoValor.TabIndex = 13;
            this.lblDireccionVientoValor.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.lblProbabilidadLluvia);
            this.panel5.Controls.Add(this.lblProbabilidadLluviaValor);
            this.panel5.Location = new System.Drawing.Point(326, 8);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(308, 104);
            this.panel5.TabIndex = 28;
            // 
            // lblProbabilidadLluvia
            // 
            this.lblProbabilidadLluvia.AutoSize = true;
            this.lblProbabilidadLluvia.BackColor = System.Drawing.Color.Transparent;
            this.lblProbabilidadLluvia.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProbabilidadLluvia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProbabilidadLluvia.Location = new System.Drawing.Point(26, 23);
            this.lblProbabilidadLluvia.Name = "lblProbabilidadLluvia";
            this.lblProbabilidadLluvia.Size = new System.Drawing.Size(388, 50);
            this.lblProbabilidadLluvia.TabIndex = 18;
            this.lblProbabilidadLluvia.Text = "Probabilidad de lluvia";
            // 
            // lblProbabilidadLluviaValor
            // 
            this.lblProbabilidadLluviaValor.AutoSize = true;
            this.lblProbabilidadLluviaValor.BackColor = System.Drawing.Color.Transparent;
            this.lblProbabilidadLluviaValor.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProbabilidadLluviaValor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProbabilidadLluviaValor.Location = new System.Drawing.Point(26, 52);
            this.lblProbabilidadLluviaValor.Name = "lblProbabilidadLluviaValor";
            this.lblProbabilidadLluviaValor.Size = new System.Drawing.Size(43, 50);
            this.lblProbabilidadLluviaValor.TabIndex = 7;
            this.lblProbabilidadLluviaValor.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblIndiceCalidadAire);
            this.panel4.Location = new System.Drawing.Point(13, 362);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 109);
            this.panel4.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 50);
            this.label1.TabIndex = 17;
            this.label1.Text = "Calidad de aire";
            // 
            // lblIndiceCalidadAire
            // 
            this.lblIndiceCalidadAire.AutoSize = true;
            this.lblIndiceCalidadAire.BackColor = System.Drawing.Color.Transparent;
            this.lblIndiceCalidadAire.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndiceCalidadAire.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIndiceCalidadAire.Location = new System.Drawing.Point(23, 59);
            this.lblIndiceCalidadAire.Name = "lblIndiceCalidadAire";
            this.lblIndiceCalidadAire.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIndiceCalidadAire.Size = new System.Drawing.Size(43, 50);
            this.lblIndiceCalidadAire.TabIndex = 16;
            this.lblIndiceCalidadAire.Text = "0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblVelocidadviento);
            this.panel3.Controls.Add(this.lblVelocidadVientoValor);
            this.panel3.Location = new System.Drawing.Point(13, 244);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 108);
            this.panel3.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPresion);
            this.panel2.Controls.Add(this.lblPresionValor);
            this.panel2.Location = new System.Drawing.Point(13, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 103);
            this.panel2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lblSensacionTermicaValor);
            this.panel1.Controls.Add(this.lblSensacionTermina);
            this.panel1.Location = new System.Drawing.Point(13, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 101);
            this.panel1.TabIndex = 24;
            // 
            // panelCalidadAire
            // 
            this.panelCalidadAire.AllowDrop = true;
            this.panelCalidadAire.BackColor = System.Drawing.Color.Green;
            this.panelCalidadAire.Controls.Add(this.lblCalidadAire);
            this.panelCalidadAire.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelCalidadAire.Location = new System.Drawing.Point(110, 295);
            this.panelCalidadAire.Name = "panelCalidadAire";
            this.panelCalidadAire.Size = new System.Drawing.Size(708, 97);
            this.panelCalidadAire.TabIndex = 16;
            // 
            // FormClima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::AppClima_CARLAyALICIA.Properties.Resources.foto21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(946, 939);
            this.Controls.Add(this.panelCalidadAire);
            this.Controls.Add(this.lblMaxMin);
            this.Controls.Add(this.lblDescripcionClima);
            this.Controls.Add(this.panelEstadisticas);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblTemperaturaPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "FormClima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App de Clima";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoClima)).EndInit();
            this.panelEstadisticas.ResumeLayout(false);
            this.panelRecomendaciones.ResumeLayout(false);
            this.panelRecomendaciones.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    private Label lblPresionValor;
    private Label lblMaxMin;
    private Label lblIndiceUVValor;
    private Label lblHumedadValor;
    private Label lblDescripcionClima;
    private Label lblCalidadAire;
    private Label lblSensacionTermina;
    private Label lblPresion;
    private Label lblVelocidadviento;
    private Label lblHumedad;
    private Label lblIndiceUV;
    private Label lblVisibilidad;
    private Button btnCerrar;
    private ImageList imageListClima;
    private Panel panelEstadisticas;
    private Panel panelCalidadAire;
    private Label lblIndiceCalidadAire;
    private Label label1;
    protected internal Label lblProbabilidadLluvia;
    private Label lblPuntoRocio;
    private Label lblDireccionVientoValor;
    private Label lblProbabilidadLluviaValor;
    private Label lblDireccionViento;
    private Label lblPuntoRocioValor;
    private Panel panel1;
    private Panel panel4;
    private Panel panel3;
    private Panel panel2;
    private Panel panel6;
    private Panel panel7;
    private Panel panel5;
    private Panel panel8;
    private Panel panel10;
    private Panel panel9;
    private Label lblRecomendacionesTitulo;
    private Panel panelRecomendaciones;
    private FlowLayoutPanel flpRecomendaciones;


}