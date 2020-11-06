namespace DesignSistemVentas.View
{
    partial class MsgBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.Icon = new System.Windows.Forms.PictureBox();
            this.lblMsg = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Icon_delay = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnOK = new JThinButton.JThinButton();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            this.bunifuFormFadeTransition1.TransitionEnd += new System.EventHandler(this.bunifuFormFadeTransition1_TransitionEnd);
            // 
            // Icon
            // 
            this.Icon.Image = ((System.Drawing.Image)(resources.GetObject("Icon.Image")));
            this.Icon.Location = new System.Drawing.Point(137, 71);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(68, 63);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon.TabIndex = 0;
            this.Icon.TabStop = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(51, 35);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(64, 16);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "MENSAJE";
            // 
            // Icon_delay
            // 
            this.Icon_delay.Interval = 1500;
            this.Icon_delay.Tick += new System.EventHandler(this.Icon_delay_Tick);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOK.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnOK.BorderRadius = 5;
            this.btnOK.ButtonText = "OK";
            this.btnOK.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColors = System.Drawing.Color.White;
            this.btnOK.HoverBackground = System.Drawing.SystemColors.ActiveCaption;
            this.btnOK.HoverBorder = System.Drawing.Color.Empty;
            this.btnOK.HoverFontColor = System.Drawing.Color.MintCream;
            this.btnOK.LineThickness = 2;
            this.btnOK.Location = new System.Drawing.Point(54, 160);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOK.Size = new System.Drawing.Size(225, 41);
            this.btnOK.TabIndex = 13;
            this.btnOK.Click += new System.EventHandler(this.btnIngresoUsuario_Click);
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(336, 214);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.Icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgBox";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog";
            this.Load += new System.EventHandler(this.MsgBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private new System.Windows.Forms.PictureBox Icon;
        private System.Windows.Forms.Timer Icon_delay;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private JThinButton.JThinButton btnOK;
        public Bunifu.Framework.UI.BunifuCustomLabel lblMsg;
    }
}