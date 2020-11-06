namespace DesignSistemVentas.View.CajaView
{
    partial class agregarClienteMovimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarClienteMovimiento));
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusquedaClientes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientesCaja = new System.Windows.Forms.DataGridView();
            this.botonMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.botonSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 16);
            this.label2.TabIndex = 105;
            this.label2.Text = "SELECCIONE UN CLIENTE PARA CARGAR";
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
            this.txtBusquedaClientes.Location = new System.Drawing.Point(12, 160);
            this.txtBusquedaClientes.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaClientes.Name = "txtBusquedaClientes";
            this.txtBusquedaClientes.Size = new System.Drawing.Size(348, 39);
            this.txtBusquedaClientes.TabIndex = 104;
            this.txtBusquedaClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "CLIENTES ALTA CAJA";
            // 
            // dgvClientesCaja
            // 
            this.dgvClientesCaja.AllowUserToAddRows = false;
            this.dgvClientesCaja.AllowUserToDeleteRows = false;
            this.dgvClientesCaja.AllowUserToResizeColumns = false;
            this.dgvClientesCaja.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvClientesCaja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientesCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvClientesCaja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvClientesCaja.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvClientesCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientesCaja.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientesCaja.Location = new System.Drawing.Point(12, 206);
            this.dgvClientesCaja.MultiSelect = false;
            this.dgvClientesCaja.Name = "dgvClientesCaja";
            this.dgvClientesCaja.ReadOnly = true;
            this.dgvClientesCaja.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvClientesCaja.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientesCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientesCaja.Size = new System.Drawing.Size(348, 275);
            this.dgvClientesCaja.TabIndex = 99;
            this.dgvClientesCaja.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvClientesCaja_MouseClick);
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.ImageActive = null;
            this.botonMinimizar.Location = new System.Drawing.Point(299, 4);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(36, 35);
            this.botonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonMinimizar.TabIndex = 103;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Zoom = 10;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.botonSalir.Image = ((System.Drawing.Image)(resources.GetObject("botonSalir.Image")));
            this.botonSalir.ImageActive = null;
            this.botonSalir.Location = new System.Drawing.Point(334, 4);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(29, 35);
            this.botonSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonSalir.TabIndex = 102;
            this.botonSalir.TabStop = false;
            this.botonSalir.Zoom = 10;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 59);
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // agregarClienteMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusquedaClientes);
            this.Controls.Add(this.botonMinimizar);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClientesCaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregarClienteMovimiento";
            this.Text = "agregarClienteMovimiento";
            this.Load += new System.EventHandler(this.agregarClienteMovimiento_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.agregarClienteMovimiento_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtBusquedaClientes;
        private Bunifu.Framework.UI.BunifuImageButton botonMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton botonSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvClientesCaja;
    }
}