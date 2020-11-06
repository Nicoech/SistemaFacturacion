namespace DesignSistemVentas.View.FacturasViews
{
    partial class facturaReporteForm
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
            this.crystalReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReport
            // 
            this.crystalReport.ActiveViewIndex = 0;
            this.crystalReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReport.DisplayStatusBar = false;
            this.crystalReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReport.Location = new System.Drawing.Point(0, 0);
            this.crystalReport.Name = "crystalReport";
            this.crystalReport.ReportSource = "C:\\Users\\Nico\\Desktop\\Sistema de Ventas\\DesignSistemVentas\\DesignSistemVentas\\Fac" +
    "tura.rpt";
            this.crystalReport.Size = new System.Drawing.Size(1109, 1061);
            this.crystalReport.TabIndex = 0;
            this.crystalReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // facturaReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 1061);
            this.Controls.Add(this.crystalReport);
            this.Name = "facturaReporteForm";
            this.Text = "facturaReporteForm";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReport;
    }
}