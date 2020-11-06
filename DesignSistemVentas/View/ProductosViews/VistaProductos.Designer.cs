namespace DesignSistemVentas.View
{
    partial class VistaProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaProductos));
            this.txtBusquedaProductos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExportarExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnListarProductos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.botonSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.botonMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAgregarProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificarProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusquedaProductos
            // 
            this.txtBusquedaProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBusquedaProductos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusquedaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBusquedaProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBusquedaProductos.HintForeColor = System.Drawing.Color.Empty;
            this.txtBusquedaProductos.HintText = "Buscar producto por codigo ";
            this.txtBusquedaProductos.isPassword = false;
            this.txtBusquedaProductos.LineFocusedColor = System.Drawing.Color.Green;
            this.txtBusquedaProductos.LineIdleColor = System.Drawing.Color.LimeGreen;
            this.txtBusquedaProductos.LineMouseHoverColor = System.Drawing.Color.MediumAquamarine;
            this.txtBusquedaProductos.LineThickness = 3;
            this.txtBusquedaProductos.Location = new System.Drawing.Point(12, 124);
            this.txtBusquedaProductos.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaProductos.Name = "txtBusquedaProductos";
            this.txtBusquedaProductos.Size = new System.Drawing.Size(333, 41);
            this.txtBusquedaProductos.TabIndex = 1;
            this.txtBusquedaProductos.Text = "Buscar producto por codigo o descripcion";
            this.txtBusquedaProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBusquedaProductos.OnValueChanged += new System.EventHandler(this.txtBusquedaProductos_OnValueChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.Location = new System.Drawing.Point(14, 172);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(823, 348);
            this.dgvProductos.TabIndex = 90;
            this.dgvProductos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductos_CellMouseDoubleClick);
            this.dgvProductos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProductos_RowsAdded);
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "STOCK";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 43);
            this.panel1.TabIndex = 101;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.btnAgregarProducto);
            this.panel2.Controls.Add(this.btnModificarProducto);
            this.panel2.Controls.Add(this.btnEliminarProducto);
            this.panel2.Location = new System.Drawing.Point(12, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 57);
            this.panel2.TabIndex = 102;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(186, 60);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.MediumSpringGreen;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(60, 57);
            this.bunifuFlatButton1.TabIndex = 104;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExportarExcel.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExportarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportarExcel.BorderRadius = 5;
            this.btnExportarExcel.ButtonText = "      EXPORTAR LISTA A EXCEL";
            this.btnExportarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarExcel.DisabledColor = System.Drawing.Color.Gray;
            this.btnExportarExcel.Enabled = false;
            this.btnExportarExcel.Iconcolor = System.Drawing.Color.White;
            this.btnExportarExcel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.Iconimage")));
            this.btnExportarExcel.Iconimage_right = null;
            this.btnExportarExcel.Iconimage_right_Selected = null;
            this.btnExportarExcel.Iconimage_Selected = null;
            this.btnExportarExcel.IconMarginLeft = 0;
            this.btnExportarExcel.IconMarginRight = 0;
            this.btnExportarExcel.IconRightVisible = true;
            this.btnExportarExcel.IconRightZoom = 0D;
            this.btnExportarExcel.IconVisible = true;
            this.btnExportarExcel.IconZoom = 90D;
            this.btnExportarExcel.IsTab = false;
            this.btnExportarExcel.Location = new System.Drawing.Point(564, 526);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Normalcolor = System.Drawing.Color.DarkGreen;
            this.btnExportarExcel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnExportarExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExportarExcel.selected = false;
            this.btnExportarExcel.Size = new System.Drawing.Size(273, 41);
            this.btnExportarExcel.TabIndex = 100;
            this.btnExportarExcel.Text = "      EXPORTAR LISTA A EXCEL";
            this.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarExcel.Textcolor = System.Drawing.Color.White;
            this.btnExportarExcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnListarProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnListarProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListarProductos.BorderRadius = 3;
            this.btnListarProductos.ButtonText = "Listar Productos";
            this.btnListarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarProductos.DisabledColor = System.Drawing.Color.Gray;
            this.btnListarProductos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnListarProductos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnListarProductos.Iconimage")));
            this.btnListarProductos.Iconimage_right = null;
            this.btnListarProductos.Iconimage_right_Selected = null;
            this.btnListarProductos.Iconimage_Selected = null;
            this.btnListarProductos.IconMarginLeft = 0;
            this.btnListarProductos.IconMarginRight = 0;
            this.btnListarProductos.IconRightVisible = true;
            this.btnListarProductos.IconRightZoom = 0D;
            this.btnListarProductos.IconVisible = true;
            this.btnListarProductos.IconZoom = 90D;
            this.btnListarProductos.IsTab = false;
            this.btnListarProductos.Location = new System.Drawing.Point(528, 124);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnListarProductos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnListarProductos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnListarProductos.selected = false;
            this.btnListarProductos.Size = new System.Drawing.Size(309, 41);
            this.btnListarProductos.TabIndex = 89;
            this.btnListarProductos.Text = "Listar Productos";
            this.btnListarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnListarProductos.Textcolor = System.Drawing.Color.White;
            this.btnListarProductos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonSalir.Image = ((System.Drawing.Image)(resources.GetObject("botonSalir.Image")));
            this.botonSalir.ImageActive = null;
            this.botonSalir.Location = new System.Drawing.Point(809, 5);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(29, 30);
            this.botonSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonSalir.TabIndex = 88;
            this.botonSalir.TabStop = false;
            this.botonSalir.Zoom = 10;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMinimizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.ImageActive = null;
            this.botonMinimizar.Location = new System.Drawing.Point(776, 5);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(34, 30);
            this.botonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonMinimizar.TabIndex = 82;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Zoom = 10;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(106, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAgregarProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarProducto.BorderRadius = 7;
            this.btnAgregarProducto.ButtonText = "";
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarProducto.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregarProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Iconimage")));
            this.btnAgregarProducto.Iconimage_right = null;
            this.btnAgregarProducto.Iconimage_right_Selected = null;
            this.btnAgregarProducto.Iconimage_Selected = null;
            this.btnAgregarProducto.IconMarginLeft = 0;
            this.btnAgregarProducto.IconMarginRight = 0;
            this.btnAgregarProducto.IconRightVisible = true;
            this.btnAgregarProducto.IconRightZoom = 0D;
            this.btnAgregarProducto.IconVisible = true;
            this.btnAgregarProducto.IconZoom = 90D;
            this.btnAgregarProducto.IsTab = false;
            this.btnAgregarProducto.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregarProducto.OnHovercolor = System.Drawing.Color.MediumSpringGreen;
            this.btnAgregarProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarProducto.selected = false;
            this.btnAgregarProducto.Size = new System.Drawing.Size(48, 48);
            this.btnAgregarProducto.TabIndex = 84;
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.Textcolor = System.Drawing.Color.White;
            this.btnAgregarProducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnModificarProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificarProducto.BorderRadius = 7;
            this.btnModificarProducto.ButtonText = "";
            this.btnModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnModificarProducto.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificarProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificarProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModificarProducto.Iconimage")));
            this.btnModificarProducto.Iconimage_right = null;
            this.btnModificarProducto.Iconimage_right_Selected = null;
            this.btnModificarProducto.Iconimage_Selected = null;
            this.btnModificarProducto.IconMarginLeft = 0;
            this.btnModificarProducto.IconMarginRight = 0;
            this.btnModificarProducto.IconRightVisible = true;
            this.btnModificarProducto.IconRightZoom = 0D;
            this.btnModificarProducto.IconVisible = true;
            this.btnModificarProducto.IconZoom = 90D;
            this.btnModificarProducto.IsTab = false;
            this.btnModificarProducto.Location = new System.Drawing.Point(57, 3);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificarProducto.OnHovercolor = System.Drawing.Color.MediumSpringGreen;
            this.btnModificarProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModificarProducto.selected = false;
            this.btnModificarProducto.Size = new System.Drawing.Size(48, 48);
            this.btnModificarProducto.TabIndex = 85;
            this.btnModificarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProducto.Textcolor = System.Drawing.Color.White;
            this.btnModificarProducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.Visible = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEliminarProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarProducto.BorderRadius = 7;
            this.btnEliminarProducto.ButtonText = "";
            this.btnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarProducto.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminarProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarProducto.Iconimage")));
            this.btnEliminarProducto.Iconimage_right = null;
            this.btnEliminarProducto.Iconimage_right_Selected = null;
            this.btnEliminarProducto.Iconimage_Selected = null;
            this.btnEliminarProducto.IconMarginLeft = 0;
            this.btnEliminarProducto.IconMarginRight = 0;
            this.btnEliminarProducto.IconRightVisible = true;
            this.btnEliminarProducto.IconRightZoom = 0D;
            this.btnEliminarProducto.IconVisible = true;
            this.btnEliminarProducto.IconZoom = 90D;
            this.btnEliminarProducto.IsTab = false;
            this.btnEliminarProducto.Location = new System.Drawing.Point(111, 4);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminarProducto.OnHovercolor = System.Drawing.Color.MediumSpringGreen;
            this.btnEliminarProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarProducto.selected = false;
            this.btnEliminarProducto.Size = new System.Drawing.Size(48, 47);
            this.btnEliminarProducto.TabIndex = 86;
            this.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Textcolor = System.Drawing.Color.White;
            this.btnEliminarProducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Visible = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // VistaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(846, 577);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnListarProductos);
            this.Controls.Add(this.txtBusquedaProductos);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonMinimizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaProductos";
            this.Load += new System.EventHandler(this.VistaProductos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VistaProductos_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.Framework.UI.BunifuFlatButton btnAgregarProducto;
        private Bunifu.Framework.UI.BunifuImageButton botonMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton botonSalir;
        private Bunifu.Framework.UI.BunifuFlatButton btnListarProductos;
        public System.Windows.Forms.DataGridView dgvProductos;
        public Bunifu.Framework.UI.BunifuFlatButton btnEliminarProducto;
        public Bunifu.Framework.UI.BunifuFlatButton btnModificarProducto;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtBusquedaProductos;
        private Bunifu.Framework.UI.BunifuFlatButton btnExportarExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}