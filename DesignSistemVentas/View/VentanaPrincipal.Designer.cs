namespace DesignSistemVentas.Properties
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.FechaHora = new System.Windows.Forms.Timer(this.components);
            this.msjBotones = new System.Windows.Forms.ToolTip(this.components);
            this.hogarElectricoIcon = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelMenuCerrado = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.tipoUsuario = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DiaMesAño = new System.Windows.Forms.Label();
            this.Reloj = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnReimprimirFacturas = new System.Windows.Forms.Button();
            this.btnCuentasCorrientes = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hogarElectricoIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMenuCerrado)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FechaHora
            // 
            this.FechaHora.Enabled = true;
            this.FechaHora.Tick += new System.EventHandler(this.FechaHora_Tick);
            // 
            // hogarElectricoIcon
            // 
            this.hogarElectricoIcon.BackColor = System.Drawing.Color.Black;
            this.hogarElectricoIcon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hogarElectricoIcon.ErrorImage = null;
            this.hogarElectricoIcon.Image = ((System.Drawing.Image)(resources.GetObject("hogarElectricoIcon.Image")));
            this.hogarElectricoIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hogarElectricoIcon.Location = new System.Drawing.Point(0, 17);
            this.hogarElectricoIcon.Margin = new System.Windows.Forms.Padding(3, 1, 4, 4);
            this.hogarElectricoIcon.Name = "hogarElectricoIcon";
            this.hogarElectricoIcon.Size = new System.Drawing.Size(249, 118);
            this.hogarElectricoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hogarElectricoIcon.TabIndex = 67;
            this.hogarElectricoIcon.TabStop = false;
            this.msjBotones.SetToolTip(this.hogarElectricoIcon, "HOGAR ELECTRICO SISTEMA");
            // 
            // panelMenuCerrado
            // 
            this.panelMenuCerrado.BackColor = System.Drawing.Color.CadetBlue;
            this.panelMenuCerrado.Location = new System.Drawing.Point(0, 163);
            this.panelMenuCerrado.Name = "panelMenuCerrado";
            this.panelMenuCerrado.Size = new System.Drawing.Size(76, 348);
            this.panelMenuCerrado.TabIndex = 50;
            this.panelMenuCerrado.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.panel5);
            this.panelTop.Controls.Add(this.panel4);
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(725, 166);
            this.panelTop.TabIndex = 66;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "SISTEMA DE VENTAS HOGAR ELECTRICO";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.nombreUsuario);
            this.panel5.Controls.Add(this.tipoUsuario);
            this.panel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Location = new System.Drawing.Point(11, 36);
            this.panel5.Name = "panel5";
            this.panel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel5.Size = new System.Drawing.Size(342, 54);
            this.panel5.TabIndex = 66;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuario.ForeColor = System.Drawing.Color.ForestGreen;
            this.nombreUsuario.Location = new System.Drawing.Point(3, 8);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(151, 18);
            this.nombreUsuario.TabIndex = 4;
            this.nombreUsuario.Text = "\"Nombre usuario\"";
            // 
            // tipoUsuario
            // 
            this.tipoUsuario.AutoSize = true;
            this.tipoUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuario.ForeColor = System.Drawing.Color.ForestGreen;
            this.tipoUsuario.Location = new System.Drawing.Point(3, 31);
            this.tipoUsuario.Name = "tipoUsuario";
            this.tipoUsuario.Size = new System.Drawing.Size(146, 18);
            this.tipoUsuario.TabIndex = 7;
            this.tipoUsuario.Text = "\"Tipo de usuario\"";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.DiaMesAño);
            this.panel4.Controls.Add(this.Reloj);
            this.panel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Location = new System.Drawing.Point(11, 96);
            this.panel4.Name = "panel4";
            this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel4.Size = new System.Drawing.Size(455, 58);
            this.panel4.TabIndex = 65;
            // 
            // DiaMesAño
            // 
            this.DiaMesAño.AutoSize = true;
            this.DiaMesAño.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DiaMesAño.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaMesAño.ForeColor = System.Drawing.Color.ForestGreen;
            this.DiaMesAño.Location = new System.Drawing.Point(3, 31);
            this.DiaMesAño.Name = "DiaMesAño";
            this.DiaMesAño.Size = new System.Drawing.Size(98, 18);
            this.DiaMesAño.TabIndex = 1;
            this.DiaMesAño.Text = "DiaMesAño";
            // 
            // Reloj
            // 
            this.Reloj.AutoSize = true;
            this.Reloj.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Reloj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reloj.ForeColor = System.Drawing.Color.ForestGreen;
            this.Reloj.Location = new System.Drawing.Point(3, 5);
            this.Reloj.Name = "Reloj";
            this.Reloj.Size = new System.Drawing.Size(48, 18);
            this.Reloj.TabIndex = 0;
            this.Reloj.Text = "Reloj";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(4, 433);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 69);
            this.btnSalir.TabIndex = 63;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearUsuario.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCrearUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearUsuario.Image")));
            this.btnCrearUsuario.Location = new System.Drawing.Point(4, 172);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(68, 64);
            this.btnCrearUsuario.TabIndex = 65;
            this.btnCrearUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            this.btnCrearUsuario.MouseHover += new System.EventHandler(this.btnCrearUsuario_MouseHover);
            // 
            // btnReimprimirFacturas
            // 
            this.btnReimprimirFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReimprimirFacturas.BackColor = System.Drawing.Color.CadetBlue;
            this.btnReimprimirFacturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReimprimirFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReimprimirFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReimprimirFacturas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReimprimirFacturas.Image = ((System.Drawing.Image)(resources.GetObject("btnReimprimirFacturas.Image")));
            this.btnReimprimirFacturas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReimprimirFacturas.Location = new System.Drawing.Point(14, 178);
            this.btnReimprimirFacturas.Name = "btnReimprimirFacturas";
            this.btnReimprimirFacturas.Size = new System.Drawing.Size(138, 161);
            this.btnReimprimirFacturas.TabIndex = 6;
            this.btnReimprimirFacturas.Text = "REIMPRIMIR FACTURAS Y REMITOS";
            this.btnReimprimirFacturas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReimprimirFacturas.UseVisualStyleBackColor = false;
            this.btnReimprimirFacturas.Click += new System.EventHandler(this.btnReimprimirFacturas_Click);
            // 
            // btnCuentasCorrientes
            // 
            this.btnCuentasCorrientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCuentasCorrientes.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCuentasCorrientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCuentasCorrientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentasCorrientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentasCorrientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCuentasCorrientes.Image = ((System.Drawing.Image)(resources.GetObject("btnCuentasCorrientes.Image")));
            this.btnCuentasCorrientes.Location = new System.Drawing.Point(329, 178);
            this.btnCuentasCorrientes.Name = "btnCuentasCorrientes";
            this.btnCuentasCorrientes.Size = new System.Drawing.Size(146, 160);
            this.btnCuentasCorrientes.TabIndex = 7;
            this.btnCuentasCorrientes.Text = "CTAS.CTES";
            this.btnCuentasCorrientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCuentasCorrientes.UseVisualStyleBackColor = false;
            this.btnCuentasCorrientes.Click += new System.EventHandler(this.btnCuentasCorrientes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientes.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(168, 9);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(146, 160);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(168, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 161);
            this.button2.TabIndex = 5;
            this.button2.Text = "HISTORICO DE CLIENTES";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductos.BackColor = System.Drawing.Color.CadetBlue;
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductos.Location = new System.Drawing.Point(329, 9);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(146, 160);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "STOCK PRODUCTOS";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(14, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 160);
            this.button1.TabIndex = 1;
            this.button1.Text = "CAJA";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacturacion.BackColor = System.Drawing.Color.CadetBlue;
            this.btnFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.Image")));
            this.btnFacturacion.Location = new System.Drawing.Point(488, 9);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(146, 160);
            this.btnFacturacion.TabIndex = 4;
            this.btnFacturacion.Text = "FACTURACION";
            this.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFacturacion.UseVisualStyleBackColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnReimprimirFacturas);
            this.panel3.Controls.Add(this.btnCuentasCorrientes);
            this.panel3.Controls.Add(this.btnFacturacion);
            this.panel3.Controls.Add(this.btnProductos);
            this.panel3.Controls.Add(this.btnClientes);
            this.panel3.Location = new System.Drawing.Point(78, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1126, 348);
            this.panel3.TabIndex = 54;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBox_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.hogarElectricoIcon);
            this.panel1.Location = new System.Drawing.Point(472, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 154);
            this.panel1.TabIndex = 68;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(488, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 160);
            this.button3.TabIndex = 8;
            this.button3.Text = "LISTADO MOROSOS";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 514);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panelMenuCerrado);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HogarElectrico Ventana Principal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VentanaPrincipal_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.hogarElectricoIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMenuCerrado)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer FechaHora;
        private System.Windows.Forms.PictureBox panelMenuCerrado;
        private System.Windows.Forms.ToolTip msjBotones;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.Label tipoUsuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label DiaMesAño;
        private System.Windows.Forms.Label Reloj;
        private System.Windows.Forms.PictureBox hogarElectricoIcon;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnReimprimirFacturas;
        private System.Windows.Forms.Button btnCuentasCorrientes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
    }
}