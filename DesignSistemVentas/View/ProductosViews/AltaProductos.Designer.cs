namespace DesignSistemVentas.View.ProductosViews
{
    partial class AltaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaProductos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.txtStockAct = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtID_Prod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAltaProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_DNI = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new Bunifu.Framework.UI.BunifuFlatButton();
            this.botonMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.botonSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbCategoria);
            this.panel1.Controls.Add(this.txtCodProd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtStockMin);
            this.panel1.Controls.Add(this.txtStockAct);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtID_Prod);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAltaProducto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDomicilio);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.lbl_DNI);
            this.panel1.Location = new System.Drawing.Point(20, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 649);
            this.panel1.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 112;
            this.label5.Text = "CATEGORIA";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(24, 523);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(334, 27);
            this.cmbCategoria.TabIndex = 111;
            this.cmbCategoria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbCategoria_MouseClick);
            // 
            // txtCodProd
            // 
            this.txtCodProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodProd.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProd.Location = new System.Drawing.Point(24, 138);
            this.txtCodProd.MaxLength = 10;
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(334, 26);
            this.txtCodProd.TabIndex = 1;
            this.txtCodProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProd_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 19);
            this.label4.TabIndex = 110;
            this.label4.Text = "COD_PRODUCTO(Opcional)";
            // 
            // txtStockMin
            // 
            this.txtStockMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStockMin.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockMin.Location = new System.Drawing.Point(24, 445);
            this.txtStockMin.MaxLength = 10;
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(334, 26);
            this.txtStockMin.TabIndex = 5;
            this.txtStockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockMin_KeyPress);
            // 
            // txtStockAct
            // 
            this.txtStockAct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStockAct.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockAct.Location = new System.Drawing.Point(24, 374);
            this.txtStockAct.MaxLength = 10;
            this.txtStockAct.Name = "txtStockAct";
            this.txtStockAct.Size = new System.Drawing.Size(334, 26);
            this.txtStockAct.TabIndex = 4;
            this.txtStockAct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockAct_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecio.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(24, 289);
            this.txtPrecio.MaxLength = 20;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(334, 26);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(24, 216);
            this.txtDescripcion.MaxLength = 30;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(334, 26);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtID_Prod
            // 
            this.txtID_Prod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID_Prod.Enabled = false;
            this.txtID_Prod.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_Prod.Location = new System.Drawing.Point(24, 62);
            this.txtID_Prod.MaxLength = 5;
            this.txtID_Prod.Name = "txtID_Prod";
            this.txtID_Prod.Size = new System.Drawing.Size(334, 26);
            this.txtID_Prod.TabIndex = 105;
            this.txtID_Prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProducto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 19);
            this.label3.TabIndex = 104;
            this.label3.Text = "CANTIDAD MINIMA NECESARIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 103;
            this.label2.Text = "CANTIDAD EN STOCK";
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAltaProducto.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAltaProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAltaProducto.BorderRadius = 0;
            this.btnAltaProducto.ButtonText = "AGREGAR PRODUCTO";
            this.btnAltaProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnAltaProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAltaProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAltaProducto.Iconimage")));
            this.btnAltaProducto.Iconimage_right = null;
            this.btnAltaProducto.Iconimage_right_Selected = null;
            this.btnAltaProducto.Iconimage_Selected = null;
            this.btnAltaProducto.IconMarginLeft = 0;
            this.btnAltaProducto.IconMarginRight = 0;
            this.btnAltaProducto.IconRightVisible = true;
            this.btnAltaProducto.IconRightZoom = 0D;
            this.btnAltaProducto.IconVisible = true;
            this.btnAltaProducto.IconZoom = 90D;
            this.btnAltaProducto.IsTab = false;
            this.btnAltaProducto.Location = new System.Drawing.Point(24, 578);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Normalcolor = System.Drawing.Color.DarkOliveGreen;
            this.btnAltaProducto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAltaProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAltaProducto.selected = false;
            this.btnAltaProducto.Size = new System.Drawing.Size(338, 63);
            this.btnAltaProducto.TabIndex = 96;
            this.btnAltaProducto.Text = "AGREGAR PRODUCTO";
            this.btnAltaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAltaProducto.Textcolor = System.Drawing.Color.White;
            this.btnAltaProducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProducto.Click += new System.EventHandler(this.btnAltaProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 89;
            this.label1.Text = "APELLIDO";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(20, 267);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(58, 19);
            this.lblDomicilio.TabIndex = 85;
            this.lblDomicilio.Text = "PRECIO";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(20, 194);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(100, 19);
            this.lbl.TabIndex = 84;
            this.lbl.Text = "DESCRIPCION";
            // 
            // lbl_DNI
            // 
            this.lbl_DNI.AutoSize = true;
            this.lbl_DNI.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_DNI.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DNI.Location = new System.Drawing.Point(20, 26);
            this.lbl_DNI.Name = "lbl_DNI";
            this.lbl_DNI.Size = new System.Drawing.Size(106, 19);
            this.lbl_DNI.TabIndex = 76;
            this.lbl_DNI.Text = "ID_PRODUCTO";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.flowLayoutPanel3.Controls.Add(this.nombreUsuario);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(154, 31);
            this.flowLayoutPanel3.TabIndex = 85;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.BackColor = System.Drawing.Color.YellowGreen;
            this.nombreUsuario.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombreUsuario.Location = new System.Drawing.Point(3, 0);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(144, 25);
            this.nombreUsuario.TabIndex = 5;
            this.nombreUsuario.Text = "Alta Productos";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAgregarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAgregarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarCategoria.BorderRadius = 3;
            this.btnAgregarCategoria.ButtonText = "Agregar categoria producto";
            this.btnAgregarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCategoria.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarCategoria.Iconcolor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarCategoria.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarCategoria.Iconimage")));
            this.btnAgregarCategoria.Iconimage_right = null;
            this.btnAgregarCategoria.Iconimage_right_Selected = null;
            this.btnAgregarCategoria.Iconimage_Selected = null;
            this.btnAgregarCategoria.IconMarginLeft = 0;
            this.btnAgregarCategoria.IconMarginRight = 0;
            this.btnAgregarCategoria.IconRightVisible = true;
            this.btnAgregarCategoria.IconRightZoom = 1D;
            this.btnAgregarCategoria.IconVisible = true;
            this.btnAgregarCategoria.IconZoom = 90D;
            this.btnAgregarCategoria.IsTab = false;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(20, 62);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAgregarCategoria.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAgregarCategoria.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarCategoria.selected = false;
            this.btnAgregarCategoria.Size = new System.Drawing.Size(271, 47);
            this.btnAgregarCategoria.TabIndex = 107;
            this.btnAgregarCategoria.Text = "Agregar categoria producto";
            this.btnAgregarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarCategoria.Textcolor = System.Drawing.Color.White;
            this.btnAgregarCategoria.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMinimizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.ImageActive = null;
            this.botonMinimizar.Location = new System.Drawing.Point(344, 9);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(34, 30);
            this.botonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonMinimizar.TabIndex = 106;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Zoom = 10;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonSalir.Image = ((System.Drawing.Image)(resources.GetObject("botonSalir.Image")));
            this.botonSalir.ImageActive = null;
            this.botonSalir.Location = new System.Drawing.Point(377, 9);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(34, 30);
            this.botonSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonSalir.TabIndex = 105;
            this.botonSalir.TabStop = false;
            this.botonSalir.Zoom = 10;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // AltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(415, 768);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.botonMinimizar);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaProductos";
            this.Load += new System.EventHandler(this.AltaProductos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AltaProductos_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAltaProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label nombreUsuario;
        private Bunifu.Framework.UI.BunifuImageButton botonMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton botonSalir;
        public System.Windows.Forms.TextBox txtStockMin;
        public System.Windows.Forms.TextBox txtStockAct;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtID_Prod;
        private System.Windows.Forms.Label lbl_DNI;
        public System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarCategoria;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbCategoria;
    }
}