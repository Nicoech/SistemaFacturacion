namespace DesignSistemVentas.View.HistoricoClientesFacturas
{
    partial class cargoClienteHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cargoClienteHistorico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusquedaClientes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.botonMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.botonSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientesHistorico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 138);
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
            this.txtBusquedaClientes.Location = new System.Drawing.Point(15, 158);
            this.txtBusquedaClientes.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaClientes.Name = "txtBusquedaClientes";
            this.txtBusquedaClientes.Size = new System.Drawing.Size(348, 39);
            this.txtBusquedaClientes.TabIndex = 104;
            this.txtBusquedaClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.ImageActive = null;
            this.botonMinimizar.Location = new System.Drawing.Point(309, 5);
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
            this.botonSalir.Location = new System.Drawing.Point(344, 5);
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
            this.pictureBox1.Location = new System.Drawing.Point(15, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 59);
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "CLIENTES HISTORICO";
            // 
            // dgvClientesHistorico
            // 
            this.dgvClientesHistorico.AllowUserToAddRows = false;
            this.dgvClientesHistorico.AllowUserToDeleteRows = false;
            this.dgvClientesHistorico.AllowUserToResizeColumns = false;
            this.dgvClientesHistorico.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvClientesHistorico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientesHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvClientesHistorico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvClientesHistorico.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvClientesHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientesHistorico.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientesHistorico.Location = new System.Drawing.Point(15, 204);
            this.dgvClientesHistorico.MultiSelect = false;
            this.dgvClientesHistorico.Name = "dgvClientesHistorico";
            this.dgvClientesHistorico.ReadOnly = true;
            this.dgvClientesHistorico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvClientesHistorico.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientesHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientesHistorico.Size = new System.Drawing.Size(348, 275);
            this.dgvClientesHistorico.TabIndex = 99;
            this.dgvClientesHistorico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientesHistorico_CellContentClick);
            // 
            // cargoClienteHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusquedaClientes);
            this.Controls.Add(this.botonMinimizar);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClientesHistorico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cargoClienteHistorico";
            this.Text = "cargoClienteHistorico";
            this.Load += new System.EventHandler(this.cargoClienteHistorico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesHistorico)).EndInit();
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
        public System.Windows.Forms.DataGridView dgvClientesHistorico;
    }
}