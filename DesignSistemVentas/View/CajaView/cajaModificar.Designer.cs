namespace DesignSistemVentas.View.CajaView
{
    partial class cajaModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cajaModificar));
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtpFechaMovimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPlanilla = new System.Windows.Forms.TextBox();
            this.btnAltaMovimientoCaja = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescripcion.Location = new System.Drawing.Point(15, 187);
            this.txtDescripcion.MaxLength = 60;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(353, 30);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpFechaMovimiento
            // 
            this.dtpFechaMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaMovimiento.Location = new System.Drawing.Point(15, 449);
            this.dtpFechaMovimiento.Name = "dtpFechaMovimiento";
            this.dtpFechaMovimiento.Size = new System.Drawing.Size(410, 29);
            this.dtpFechaMovimiento.TabIndex = 177;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 174;
            this.label7.Text = "FECHA";
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMonto.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMonto.Location = new System.Drawing.Point(15, 361);
            this.txtMonto.MaxLength = 15;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(415, 30);
            this.txtMonto.TabIndex = 4;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 172;
            this.label6.Text = "MONTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 171;
            this.label5.Text = "DETALLE";
            // 
            // txtDetalle
            // 
            this.txtDetalle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDetalle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDetalle.Location = new System.Drawing.Point(15, 276);
            this.txtDetalle.MaxLength = 60;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(410, 30);
            this.txtDetalle.TabIndex = 3;
            this.txtDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 169;
            this.label4.Text = "DESCRIPCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 18);
            this.label3.TabIndex = 168;
            this.label3.Text = "TIPO DE MOVIMIENTO";
            // 
            // cmbTipoMovimiento
            // 
            this.cmbTipoMovimiento.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbTipoMovimiento.FormattingEnabled = true;
            this.cmbTipoMovimiento.Location = new System.Drawing.Point(15, 107);
            this.cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            this.cmbTipoMovimiento.Size = new System.Drawing.Size(410, 31);
            this.cmbTipoMovimiento.TabIndex = 167;
            this.cmbTipoMovimiento.Click += new System.EventHandler(this.cmbTipoMovimiento_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 166;
            this.label2.Text = "N° PLANILLA";
            // 
            // txtIDPlanilla
            // 
            this.txtIDPlanilla.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIDPlanilla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIDPlanilla.Enabled = false;
            this.txtIDPlanilla.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPlanilla.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtIDPlanilla.Location = new System.Drawing.Point(15, 34);
            this.txtIDPlanilla.MaxLength = 8;
            this.txtIDPlanilla.Name = "txtIDPlanilla";
            this.txtIDPlanilla.ReadOnly = true;
            this.txtIDPlanilla.Size = new System.Drawing.Size(158, 30);
            this.txtIDPlanilla.TabIndex = 165;
            this.txtIDPlanilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAltaMovimientoCaja
            // 
            this.btnAltaMovimientoCaja.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAltaMovimientoCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaMovimientoCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAltaMovimientoCaja.Location = new System.Drawing.Point(10, 551);
            this.btnAltaMovimientoCaja.Name = "btnAltaMovimientoCaja";
            this.btnAltaMovimientoCaja.Size = new System.Drawing.Size(454, 65);
            this.btnAltaMovimientoCaja.TabIndex = 175;
            this.btnAltaMovimientoCaja.Text = "MODIFICAR MOVIMIENTO DE CAJA";
            this.btnAltaMovimientoCaja.UseVisualStyleBackColor = false;
            this.btnAltaMovimientoCaja.Click += new System.EventHandler(this.btnAltaMovimientoCaja_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.txtIDPlanilla);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.dtpFechaMovimiento);
            this.panel1.Controls.Add(this.cmbTipoMovimiento);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDetalle);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(11, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 495);
            this.panel1.TabIndex = 178;
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientes.BackColor = System.Drawing.Color.Teal;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnClientes.FlatAppearance.BorderSize = 3;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(374, 177);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(63, 55);
            this.btnClientes.TabIndex = 161;
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 18);
            this.label1.TabIndex = 179;
            this.label1.Text = "MODIFICACION INGRESO / EGRESO DE CAJA";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(394, 9);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(37, 35);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 181;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(431, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 180;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // cajaModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 622);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAltaMovimientoCaja);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cajaModificar";
            this.Text = "cajaModificar";
            this.Load += new System.EventHandler(this.cajaModificar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cajaModificar_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.DateTimePicker dtpFechaMovimiento;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbTipoMovimiento;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtIDPlanilla;
        private System.Windows.Forms.Button btnAltaMovimientoCaja;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}