namespace DesignSistemVentas.View.FacturasViews
{
    partial class facturaCCFPView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facturaCCFPView));
            this.botonMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.botonSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarCuotasFactura = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaVto = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxCantCuotas = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMinimizar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.ImageActive = null;
            this.botonMinimizar.Location = new System.Drawing.Point(466, 12);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(34, 30);
            this.botonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonMinimizar.TabIndex = 72;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Zoom = 10;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonSalir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.botonSalir.Image = ((System.Drawing.Image)(resources.GetObject("botonSalir.Image")));
            this.botonSalir.ImageActive = null;
            this.botonSalir.Location = new System.Drawing.Point(506, 12);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(34, 30);
            this.botonSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonSalir.TabIndex = 71;
            this.botonSalir.TabStop = false;
            this.botonSalir.Zoom = 10;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Honeydew;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(158, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(258, 18);
            this.lbl1.TabIndex = 73;
            this.lbl1.Text = "FACTURA CUENTA CORRIENTE";
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroFactura.Enabled = false;
            this.txtNroFactura.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroFactura.Location = new System.Drawing.Point(19, 105);
            this.txtNroFactura.MaxLength = 11;
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(221, 30);
            this.txtNroFactura.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 122;
            this.label2.Text = "N° FACTURA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNroFactura);
            this.panel1.Location = new System.Drawing.Point(15, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 202);
            this.panel1.TabIndex = 127;
            // 
            // btnAgregarCuotasFactura
            // 
            this.btnAgregarCuotasFactura.Activecolor = System.Drawing.Color.DarkOliveGreen;
            this.btnAgregarCuotasFactura.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAgregarCuotasFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarCuotasFactura.BorderRadius = 7;
            this.btnAgregarCuotasFactura.ButtonText = "CONFIRMAR";
            this.btnAgregarCuotasFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCuotasFactura.DisabledColor = System.Drawing.Color.Transparent;
            this.btnAgregarCuotasFactura.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarCuotasFactura.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarCuotasFactura.Iconimage")));
            this.btnAgregarCuotasFactura.Iconimage_right = null;
            this.btnAgregarCuotasFactura.Iconimage_right_Selected = null;
            this.btnAgregarCuotasFactura.Iconimage_Selected = null;
            this.btnAgregarCuotasFactura.IconMarginLeft = 0;
            this.btnAgregarCuotasFactura.IconMarginRight = 0;
            this.btnAgregarCuotasFactura.IconRightVisible = true;
            this.btnAgregarCuotasFactura.IconRightZoom = 0D;
            this.btnAgregarCuotasFactura.IconVisible = true;
            this.btnAgregarCuotasFactura.IconZoom = 90D;
            this.btnAgregarCuotasFactura.IsTab = false;
            this.btnAgregarCuotasFactura.Location = new System.Drawing.Point(9, 8);
            this.btnAgregarCuotasFactura.Name = "btnAgregarCuotasFactura";
            this.btnAgregarCuotasFactura.Normalcolor = System.Drawing.Color.DarkOliveGreen;
            this.btnAgregarCuotasFactura.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.btnAgregarCuotasFactura.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAgregarCuotasFactura.selected = false;
            this.btnAgregarCuotasFactura.Size = new System.Drawing.Size(313, 73);
            this.btnAgregarCuotasFactura.TabIndex = 130;
            this.btnAgregarCuotasFactura.Text = "CONFIRMAR";
            this.btnAgregarCuotasFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarCuotasFactura.Textcolor = System.Drawing.Color.White;
            this.btnAgregarCuotasFactura.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCuotasFactura.Click += new System.EventHandler(this.btnAgregarCuotasFactura_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpFechaVto);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpFechaInicial);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbBoxCantCuotas);
            this.panel2.Location = new System.Drawing.Point(276, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 202);
            this.panel2.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 140;
            this.label1.Text = "FECHA LIMITE";
            // 
            // dtpFechaVto
            // 
            this.dtpFechaVto.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaVto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVto.Location = new System.Drawing.Point(23, 156);
            this.dtpFechaVto.Name = "dtpFechaVto";
            this.dtpFechaVto.Size = new System.Drawing.Size(219, 24);
            this.dtpFechaVto.TabIndex = 139;
            this.dtpFechaVto.Value = new System.DateTime(2020, 7, 15, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 18);
            this.label5.TabIndex = 138;
            this.label5.Text = "FECHA INICIAL DE PAGO";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicial.Enabled = false;
            this.dtpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicial.Location = new System.Drawing.Point(23, 105);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(219, 24);
            this.dtpFechaInicial.TabIndex = 137;
            this.dtpFechaInicial.Value = new System.DateTime(2020, 6, 23, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 18);
            this.label4.TabIndex = 136;
            this.label4.Text = "CANTIDAD DE CUOTAS";
            // 
            // cmbBoxCantCuotas
            // 
            this.cmbBoxCantCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCantCuotas.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbBoxCantCuotas.FormattingEnabled = true;
            this.cmbBoxCantCuotas.Location = new System.Drawing.Point(23, 41);
            this.cmbBoxCantCuotas.Name = "cmbBoxCantCuotas";
            this.cmbBoxCantCuotas.Size = new System.Drawing.Size(224, 31);
            this.cmbBoxCantCuotas.TabIndex = 135;
            this.cmbBoxCantCuotas.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCantCuotas_SelectedIndexChanged);
            this.cmbBoxCantCuotas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbBoxCantCuotas_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.Controls.Add(this.btnAgregarCuotasFactura);
            this.panel3.Location = new System.Drawing.Point(101, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 91);
            this.panel3.TabIndex = 128;
            // 
            // facturaCCFPView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(553, 359);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.botonMinimizar);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "facturaCCFPView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacturaCuotas";
            this.Load += new System.EventHandler(this.facturaCCFPView_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.facturaCCFPView_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton botonMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton botonSalir;
        private System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuFlatButton btnAgregarCuotasFactura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbBoxCantCuotas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtpFechaVto;
    }
}