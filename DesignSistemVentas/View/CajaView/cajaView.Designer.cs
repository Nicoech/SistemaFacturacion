namespace DesignSistemVentas.View.CajaView
{
    partial class cajaView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cajaView));
            this.dgvCtaCte = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpLimite = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarMovimiento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificarMovimiento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarMovimiento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.botonMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.botonSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.iconoClientes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaCte)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCtaCte
            // 
            this.dgvCtaCte.AllowUserToAddRows = false;
            this.dgvCtaCte.AllowUserToDeleteRows = false;
            this.dgvCtaCte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCtaCte.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCtaCte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCtaCte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCtaCte.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCtaCte.Location = new System.Drawing.Point(17, 168);
            this.dgvCtaCte.Name = "dgvCtaCte";
            this.dgvCtaCte.ReadOnly = true;
            this.dgvCtaCte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCtaCte.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCtaCte.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCtaCte.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCtaCte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCtaCte.Size = new System.Drawing.Size(858, 324);
            this.dgvCtaCte.TabIndex = 134;
            this.dgvCtaCte.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCtaCte_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 135;
            this.label1.Text = "CAJA";
            // 
            // dtpInicial
            // 
            this.dtpInicial.Checked = false;
            this.dtpInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(19, 32);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(195, 26);
            this.dtpInicial.TabIndex = 139;
            this.dtpInicial.ValueChanged += new System.EventHandler(this.dtpInicial_ValueChanged);
            // 
            // dtpLimite
            // 
            this.dtpLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dtpLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLimite.Location = new System.Drawing.Point(232, 31);
            this.dtpLimite.Name = "dtpLimite";
            this.dtpLimite.Size = new System.Drawing.Size(195, 26);
            this.dtpLimite.TabIndex = 140;
            this.dtpLimite.Value = new System.DateTime(2020, 10, 31, 0, 0, 0, 0);
            this.dtpLimite.ValueChanged += new System.EventHandler(this.dtpInicial_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(15, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 146;
            this.label3.Text = "Fecha Inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(228, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 147;
            this.label6.Text = "Fecha limite";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.btnEliminarMovimiento);
            this.panel1.Controls.Add(this.btnModificarMovimiento);
            this.panel1.Controls.Add(this.btnAgregarMovimiento);
            this.panel1.Location = new System.Drawing.Point(200, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 56);
            this.panel1.TabIndex = 150;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.iconoClientes);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 56);
            this.panel2.TabIndex = 152;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Honeydew;
            this.panel3.Controls.Add(this.cmbTipo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpInicial);
            this.panel3.Controls.Add(this.dtpLimite);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(17, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(858, 60);
            this.panel3.TabIndex = 155;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(486, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 158;
            this.label2.Text = "Filtrar por";
            // 
            // btnListar
            // 
            this.btnListar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnListar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnListar.BorderRadius = 7;
            this.btnListar.ButtonText = "LISTAR MOVIMIENTOS";
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.DisabledColor = System.Drawing.Color.Gray;
            this.btnListar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnListar.Iconcolor = System.Drawing.Color.Black;
            this.btnListar.Iconimage = null;
            this.btnListar.Iconimage_right = null;
            this.btnListar.Iconimage_right_Selected = null;
            this.btnListar.Iconimage_Selected = null;
            this.btnListar.IconMarginLeft = 0;
            this.btnListar.IconMarginRight = 0;
            this.btnListar.IconRightVisible = true;
            this.btnListar.IconRightZoom = 0D;
            this.btnListar.IconVisible = true;
            this.btnListar.IconZoom = 90D;
            this.btnListar.IsTab = false;
            this.btnListar.Location = new System.Drawing.Point(611, 498);
            this.btnListar.Name = "btnListar";
            this.btnListar.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnListar.OnHovercolor = System.Drawing.Color.MediumSpringGreen;
            this.btnListar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnListar.selected = false;
            this.btnListar.Size = new System.Drawing.Size(264, 57);
            this.btnListar.TabIndex = 102;
            this.btnListar.Text = "LISTAR MOVIMIENTOS";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnListar.Textcolor = System.Drawing.Color.Black;
            this.btnListar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(597, 19);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(225, 26);
            this.cmbTipo.TabIndex = 159;
            this.cmbTipo.SelectedValueChanged += new System.EventHandler(this.cmbTipo_SelectedValueChanged);
            this.cmbTipo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbTipo_MouseClick);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(802, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 162;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(839, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(33, 35);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 161;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(222, 6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.MediumSpringGreen;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(47, 47);
            this.bunifuFlatButton1.TabIndex = 101;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnEliminarMovimiento
            // 
            this.btnEliminarMovimiento.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEliminarMovimiento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminarMovimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarMovimiento.BorderRadius = 7;
            this.btnEliminarMovimiento.ButtonText = "";
            this.btnEliminarMovimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarMovimiento.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarMovimiento.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminarMovimiento.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarMovimiento.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarMovimiento.Iconimage")));
            this.btnEliminarMovimiento.Iconimage_right = null;
            this.btnEliminarMovimiento.Iconimage_right_Selected = null;
            this.btnEliminarMovimiento.Iconimage_Selected = null;
            this.btnEliminarMovimiento.IconMarginLeft = 0;
            this.btnEliminarMovimiento.IconMarginRight = 0;
            this.btnEliminarMovimiento.IconRightVisible = true;
            this.btnEliminarMovimiento.IconRightZoom = 0D;
            this.btnEliminarMovimiento.IconVisible = true;
            this.btnEliminarMovimiento.IconZoom = 90D;
            this.btnEliminarMovimiento.IsTab = false;
            this.btnEliminarMovimiento.Location = new System.Drawing.Point(147, 6);
            this.btnEliminarMovimiento.Name = "btnEliminarMovimiento";
            this.btnEliminarMovimiento.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminarMovimiento.OnHovercolor = System.Drawing.Color.MediumSpringGreen;
            this.btnEliminarMovimiento.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarMovimiento.selected = false;
            this.btnEliminarMovimiento.Size = new System.Drawing.Size(47, 47);
            this.btnEliminarMovimiento.TabIndex = 100;
            this.btnEliminarMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarMovimiento.Textcolor = System.Drawing.Color.White;
            this.btnEliminarMovimiento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMovimiento.Visible = false;
            this.btnEliminarMovimiento.Click += new System.EventHandler(this.btnEliminarMovimiento_Click);
            // 
            // btnModificarMovimiento
            // 
            this.btnModificarMovimiento.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnModificarMovimiento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificarMovimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificarMovimiento.BorderRadius = 7;
            this.btnModificarMovimiento.ButtonText = "";
            this.btnModificarMovimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarMovimiento.DisabledColor = System.Drawing.Color.Gray;
            this.btnModificarMovimiento.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificarMovimiento.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificarMovimiento.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModificarMovimiento.Iconimage")));
            this.btnModificarMovimiento.Iconimage_right = null;
            this.btnModificarMovimiento.Iconimage_right_Selected = null;
            this.btnModificarMovimiento.Iconimage_Selected = null;
            this.btnModificarMovimiento.IconMarginLeft = 0;
            this.btnModificarMovimiento.IconMarginRight = 0;
            this.btnModificarMovimiento.IconRightVisible = true;
            this.btnModificarMovimiento.IconRightZoom = 0D;
            this.btnModificarMovimiento.IconVisible = true;
            this.btnModificarMovimiento.IconZoom = 90D;
            this.btnModificarMovimiento.IsTab = false;
            this.btnModificarMovimiento.Location = new System.Drawing.Point(82, 5);
            this.btnModificarMovimiento.Name = "btnModificarMovimiento";
            this.btnModificarMovimiento.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificarMovimiento.OnHovercolor = System.Drawing.Color.MediumSpringGreen;
            this.btnModificarMovimiento.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModificarMovimiento.selected = false;
            this.btnModificarMovimiento.Size = new System.Drawing.Size(48, 48);
            this.btnModificarMovimiento.TabIndex = 99;
            this.btnModificarMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarMovimiento.Textcolor = System.Drawing.Color.White;
            this.btnModificarMovimiento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMovimiento.Visible = false;
            this.btnModificarMovimiento.Click += new System.EventHandler(this.btnModificarMovimiento_Click);
            // 
            // btnAgregarMovimiento
            // 
            this.btnAgregarMovimiento.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAgregarMovimiento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregarMovimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarMovimiento.BorderRadius = 7;
            this.btnAgregarMovimiento.ButtonText = "";
            this.btnAgregarMovimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMovimiento.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarMovimiento.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregarMovimiento.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarMovimiento.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarMovimiento.Iconimage")));
            this.btnAgregarMovimiento.Iconimage_right = null;
            this.btnAgregarMovimiento.Iconimage_right_Selected = null;
            this.btnAgregarMovimiento.Iconimage_Selected = null;
            this.btnAgregarMovimiento.IconMarginLeft = 0;
            this.btnAgregarMovimiento.IconMarginRight = 0;
            this.btnAgregarMovimiento.IconRightVisible = true;
            this.btnAgregarMovimiento.IconRightZoom = 0D;
            this.btnAgregarMovimiento.IconVisible = true;
            this.btnAgregarMovimiento.IconZoom = 90D;
            this.btnAgregarMovimiento.IsTab = false;
            this.btnAgregarMovimiento.Location = new System.Drawing.Point(17, 5);
            this.btnAgregarMovimiento.Name = "btnAgregarMovimiento";
            this.btnAgregarMovimiento.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregarMovimiento.OnHovercolor = System.Drawing.Color.MediumSpringGreen;
            this.btnAgregarMovimiento.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarMovimiento.selected = false;
            this.btnAgregarMovimiento.Size = new System.Drawing.Size(48, 48);
            this.btnAgregarMovimiento.TabIndex = 98;
            this.btnAgregarMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMovimiento.Textcolor = System.Drawing.Color.White;
            this.btnAgregarMovimiento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMovimiento.Click += new System.EventHandler(this.btnAgregarMovimiento_Click);
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.ImageActive = null;
            this.botonMinimizar.Location = new System.Drawing.Point(965, 6);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(37, 35);
            this.botonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonMinimizar.TabIndex = 149;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Zoom = 10;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonSalir.Image = ((System.Drawing.Image)(resources.GetObject("botonSalir.Image")));
            this.botonSalir.ImageActive = null;
            this.botonSalir.Location = new System.Drawing.Point(1002, 6);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(33, 35);
            this.botonSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonSalir.TabIndex = 148;
            this.botonSalir.TabStop = false;
            this.botonSalir.Zoom = 10;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // iconoClientes
            // 
            this.iconoClientes.BackColor = System.Drawing.Color.Transparent;
            this.iconoClientes.Image = ((System.Drawing.Image)(resources.GetObject("iconoClientes.Image")));
            this.iconoClientes.InitialImage = ((System.Drawing.Image)(resources.GetObject("iconoClientes.InitialImage")));
            this.iconoClientes.Location = new System.Drawing.Point(96, 6);
            this.iconoClientes.Name = "iconoClientes";
            this.iconoClientes.Size = new System.Drawing.Size(63, 46);
            this.iconoClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoClientes.TabIndex = 151;
            this.iconoClientes.TabStop = false;
            // 
            // cajaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(886, 567);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.botonMinimizar);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.dgvCtaCte);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cajaView";
            this.Text = "cajaView";
            this.Load += new System.EventHandler(this.cajaView_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cajaView_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaCte)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvCtaCte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuImageButton botonMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton botonSalir;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public Bunifu.Framework.UI.BunifuFlatButton btnEliminarMovimiento;
        public Bunifu.Framework.UI.BunifuFlatButton btnModificarMovimiento;
        public Bunifu.Framework.UI.BunifuFlatButton btnAgregarMovimiento;
        private System.Windows.Forms.PictureBox iconoClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuFlatButton btnListar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        public System.Windows.Forms.DateTimePicker dtpInicial;
        public System.Windows.Forms.DateTimePicker dtpLimite;
        public System.Windows.Forms.ComboBox cmbTipo;
    }
}