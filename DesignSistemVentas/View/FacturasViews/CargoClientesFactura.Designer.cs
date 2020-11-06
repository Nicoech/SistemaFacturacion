namespace DesignSistemVentas.View.FacturasViews
{
    partial class cargoClientesFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cargoClientesFactura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.botonMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.botonSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvClientesFactura = new System.Windows.Forms.DataGridView();
            this.txtBusquedaClientes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.BackColor = System.Drawing.Color.LightGray;
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.ImageActive = null;
            this.botonMinimizar.Location = new System.Drawing.Point(602, 4);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(36, 35);
            this.botonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonMinimizar.TabIndex = 72;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Zoom = 10;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.Color.LightGray;
            this.botonSalir.Image = ((System.Drawing.Image)(resources.GetObject("botonSalir.Image")));
            this.botonSalir.ImageActive = null;
            this.botonSalir.Location = new System.Drawing.Point(637, 4);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(33, 35);
            this.botonSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonSalir.TabIndex = 71;
            this.botonSalir.TabStop = false;
            this.botonSalir.Zoom = 10;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "SELECCIONE CLIENTE PARA CARGAR EN LA FACTURA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 59);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // dgvClientesFactura
            // 
            this.dgvClientesFactura.AllowUserToAddRows = false;
            this.dgvClientesFactura.AllowUserToDeleteRows = false;
            this.dgvClientesFactura.AllowUserToResizeColumns = false;
            this.dgvClientesFactura.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvClientesFactura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientesFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvClientesFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvClientesFactura.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvClientesFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientesFactura.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientesFactura.Location = new System.Drawing.Point(12, 162);
            this.dgvClientesFactura.MultiSelect = false;
            this.dgvClientesFactura.Name = "dgvClientesFactura";
            this.dgvClientesFactura.ReadOnly = true;
            this.dgvClientesFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvClientesFactura.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientesFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientesFactura.Size = new System.Drawing.Size(649, 411);
            this.dgvClientesFactura.TabIndex = 91;
            this.dgvClientesFactura.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClientesFactura_CellMouseClick_1);
            // 
            // txtBusquedaClientes
            // 
            this.txtBusquedaClientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBusquedaClientes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusquedaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBusquedaClientes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtBusquedaClientes.HintForeColor = System.Drawing.Color.Teal;
            this.txtBusquedaClientes.HintText = "Busqueda de cliente por DNI o Nombre";
            this.txtBusquedaClientes.isPassword = false;
            this.txtBusquedaClientes.LineFocusedColor = System.Drawing.Color.PaleGreen;
            this.txtBusquedaClientes.LineIdleColor = System.Drawing.Color.Green;
            this.txtBusquedaClientes.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBusquedaClientes.LineThickness = 3;
            this.txtBusquedaClientes.Location = new System.Drawing.Point(12, 105);
            this.txtBusquedaClientes.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaClientes.Name = "txtBusquedaClientes";
            this.txtBusquedaClientes.Size = new System.Drawing.Size(341, 50);
            this.txtBusquedaClientes.TabIndex = 92;
            this.txtBusquedaClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBusquedaClientes.OnValueChanged += new System.EventHandler(this.txtBusquedaClientes_OnValueChanged);
            // 
            // cargoClientesFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 585);
            this.Controls.Add(this.txtBusquedaClientes);
            this.Controls.Add(this.dgvClientesFactura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonMinimizar);
            this.Controls.Add(this.botonSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cargoClientesFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CargoClientesFactura";
            this.Load += new System.EventHandler(this.CargoClientesFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton botonMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton botonSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dgvClientesFactura;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtBusquedaClientes;
    }
}