namespace DesignSistemVentas.View.RemitosViews
{
    partial class reportRemito
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
            this.remitoReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // remitoReport
            // 
            this.remitoReport.ActiveViewIndex = 0;
            this.remitoReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remitoReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.remitoReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remitoReport.Location = new System.Drawing.Point(0, 0);
            this.remitoReport.Name = "remitoReport";
            this.remitoReport.ReportSource = "C:\\Users\\Nico\\Desktop\\Sistema de Ventas\\DesignSistemVentas\\DesignSistemVentas\\Rem" +
    "ito.rpt";
            this.remitoReport.Size = new System.Drawing.Size(1167, 1061);
            this.remitoReport.TabIndex = 0;
            // 
            // reportRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 1061);
            this.Controls.Add(this.remitoReport);
            this.Name = "reportRemito";
            this.Text = "reportRemito";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer remitoReport;
    }
}