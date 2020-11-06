namespace DesignSistemVentas.View.ProductosViews
{
    partial class AltaCategoriaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCategoriaProducto));
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAltaUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.botonSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.botonMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(12, 161);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(328, 26);
            this.txtDescripcion.TabIndex = 106;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.flowLayoutPanel3.Controls.Add(this.nombreUsuario);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 41);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(248, 31);
            this.flowLayoutPanel3.TabIndex = 115;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.BackColor = System.Drawing.Color.YellowGreen;
            this.nombreUsuario.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombreUsuario.Location = new System.Drawing.Point(3, 0);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(235, 25);
            this.nombreUsuario.TabIndex = 5;
            this.nombreUsuario.Text = "Alta Categoria productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(266, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 117;
            this.label1.Text = "DESCRIPCION";
            // 
            // txtIDCategoria
            // 
            this.txtIDCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIDCategoria.Enabled = false;
            this.txtIDCategoria.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCategoria.Location = new System.Drawing.Point(12, 97);
            this.txtIDCategoria.MaxLength = 5;
            this.txtIDCategoria.Name = "txtIDCategoria";
            this.txtIDCategoria.Size = new System.Drawing.Size(128, 26);
            this.txtIDCategoria.TabIndex = 119;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 120;
            this.label2.Text = "ID CATEGORIA";
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAltaUsuario.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAltaUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAltaUsuario.BorderRadius = 0;
            this.btnAltaUsuario.ButtonText = "AGREGAR CATEGORIA";
            this.btnAltaUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaUsuario.DisabledColor = System.Drawing.Color.Gray;
            this.btnAltaUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAltaUsuario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAltaUsuario.Iconimage")));
            this.btnAltaUsuario.Iconimage_right = null;
            this.btnAltaUsuario.Iconimage_right_Selected = null;
            this.btnAltaUsuario.Iconimage_Selected = null;
            this.btnAltaUsuario.IconMarginLeft = 0;
            this.btnAltaUsuario.IconMarginRight = 0;
            this.btnAltaUsuario.IconRightVisible = true;
            this.btnAltaUsuario.IconRightZoom = 0D;
            this.btnAltaUsuario.IconVisible = true;
            this.btnAltaUsuario.IconZoom = 90D;
            this.btnAltaUsuario.IsTab = false;
            this.btnAltaUsuario.Location = new System.Drawing.Point(12, 203);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Normalcolor = System.Drawing.Color.DarkSeaGreen;
            this.btnAltaUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAltaUsuario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAltaUsuario.selected = false;
            this.btnAltaUsuario.Size = new System.Drawing.Size(328, 62);
            this.btnAltaUsuario.TabIndex = 123;
            this.btnAltaUsuario.Text = "AGREGAR CATEGORIA";
            this.btnAltaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAltaUsuario.Textcolor = System.Drawing.Color.White;
            this.btnAltaUsuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaUsuario.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonSalir.Image = ((System.Drawing.Image)(resources.GetObject("botonSalir.Image")));
            this.botonSalir.ImageActive = null;
            this.botonSalir.Location = new System.Drawing.Point(312, 6);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(29, 30);
            this.botonSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonSalir.TabIndex = 125;
            this.botonSalir.TabStop = false;
            this.botonSalir.Zoom = 10;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click_1);
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMinimizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.ImageActive = null;
            this.botonMinimizar.Location = new System.Drawing.Point(279, 6);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(34, 30);
            this.botonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonMinimizar.TabIndex = 124;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Zoom = 10;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // AltaCategoriaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(352, 277);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonMinimizar);
            this.Controls.Add(this.btnAltaUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.txtDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaCategoriaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaCategoriaProducto";
            this.Load += new System.EventHandler(this.AltaCategoriaProducto_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AltaCategoriaProducto_MouseDown);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtIDCategoria;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAltaUsuario;
        private Bunifu.Framework.UI.BunifuImageButton botonSalir;
        private Bunifu.Framework.UI.BunifuImageButton botonMinimizar;
    }
}