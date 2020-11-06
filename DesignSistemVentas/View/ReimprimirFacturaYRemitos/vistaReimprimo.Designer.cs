namespace DesignSistemVentas.View.FacturasViews.ReimprimirFactura
{
    partial class vistaReimprimoFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vistaReimprimoFacturas));
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.cmbFacturasC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Remito = new System.Windows.Forms.Label();
            this.cmbRemito = new System.Windows.Forms.ComboBox();
            this.txtID_Cliente = new System.Windows.Forms.TextBox();
            this.obtengoNroFac = new System.Windows.Forms.TextBox();
            this.botonMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.botonSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(16, 78);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(383, 26);
            this.txtNombreCliente.TabIndex = 0;
            // 
            // cmbFacturasC
            // 
            this.cmbFacturasC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacturasC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFacturasC.FormattingEnabled = true;
            this.cmbFacturasC.Location = new System.Drawing.Point(16, 141);
            this.cmbFacturasC.Name = "cmbFacturasC";
            this.cmbFacturasC.Size = new System.Drawing.Size(206, 28);
            this.cmbFacturasC.TabIndex = 1;
            this.cmbFacturasC.SelectionChangeCommitted += new System.EventHandler(this.cmbFacturasC_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "REIMPRIMIR FACTURAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "SELECCIONE EL CLIENTE PARA CARGAR SUS FACTURAS --->\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "FACTURA N°";
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
            this.btnClientes.Location = new System.Drawing.Point(518, 18);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(56, 57);
            this.btnClientes.TabIndex = 74;
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 18);
            this.label4.TabIndex = 76;
            this.label4.Text = "NOMBRE CLIENTE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Remito);
            this.panel1.Controls.Add(this.cmbRemito);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbFacturasC);
            this.panel1.Controls.Add(this.txtNombreCliente);
            this.panel1.Controls.Add(this.txtID_Cliente);
            this.panel1.Controls.Add(this.obtengoNroFac);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 181);
            this.panel1.TabIndex = 77;
            // 
            // Remito
            // 
            this.Remito.AutoSize = true;
            this.Remito.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Remito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remito.Location = new System.Drawing.Point(267, 120);
            this.Remito.Name = "Remito";
            this.Remito.Size = new System.Drawing.Size(96, 18);
            this.Remito.TabIndex = 78;
            this.Remito.Text = "REMITO N°";
            // 
            // cmbRemito
            // 
            this.cmbRemito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRemito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRemito.FormattingEnabled = true;
            this.cmbRemito.Location = new System.Drawing.Point(270, 141);
            this.cmbRemito.Name = "cmbRemito";
            this.cmbRemito.Size = new System.Drawing.Size(215, 28);
            this.cmbRemito.TabIndex = 77;
            this.cmbRemito.SelectionChangeCommitted += new System.EventHandler(this.cmbRemito_SelectionChangeCommitted);
            // 
            // txtID_Cliente
            // 
            this.txtID_Cliente.Enabled = false;
            this.txtID_Cliente.Location = new System.Drawing.Point(16, 84);
            this.txtID_Cliente.Name = "txtID_Cliente";
            this.txtID_Cliente.Size = new System.Drawing.Size(202, 20);
            this.txtID_Cliente.TabIndex = 75;
            this.txtID_Cliente.Visible = false;
            // 
            // obtengoNroFac
            // 
            this.obtengoNroFac.Enabled = false;
            this.obtengoNroFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obtengoNroFac.Location = new System.Drawing.Point(16, 141);
            this.obtengoNroFac.Name = "obtengoNroFac";
            this.obtengoNroFac.Size = new System.Drawing.Size(153, 26);
            this.obtengoNroFac.TabIndex = 79;
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.ImageActive = null;
            this.botonMinimizar.Location = new System.Drawing.Point(530, 1);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(37, 35);
            this.botonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonMinimizar.TabIndex = 79;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Zoom = 10;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonSalir.Image = ((System.Drawing.Image)(resources.GetObject("botonSalir.Image")));
            this.botonSalir.ImageActive = null;
            this.botonSalir.Location = new System.Drawing.Point(566, 1);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(33, 35);
            this.botonSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonSalir.TabIndex = 78;
            this.botonSalir.TabStop = false;
            this.botonSalir.Zoom = 10;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(213, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // vistaReimprimoFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(605, 256);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonMinimizar);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vistaReimprimoFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vistaReimprimoFacturas";
            this.Load += new System.EventHandler(this.vistaReimprimoFacturas_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vistaReimprimoFacturas_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnClientes;
        public System.Windows.Forms.TextBox txtNombreCliente;
        public System.Windows.Forms.ComboBox cmbFacturasC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton botonMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton botonSalir;
        private System.Windows.Forms.Label Remito;
        public System.Windows.Forms.ComboBox cmbRemito;
        public System.Windows.Forms.TextBox txtID_Cliente;
        public System.Windows.Forms.TextBox obtengoNroFac;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}