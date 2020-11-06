namespace DesignSistemVentas.Controller.HistoricoController
{
    partial class historicoReporteForm
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
            this.reporteHis = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reporteHis
            // 
            this.reporteHis.ActiveViewIndex = 0;
            this.reporteHis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reporteHis.Cursor = System.Windows.Forms.Cursors.Default;
            this.reporteHis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporteHis.Location = new System.Drawing.Point(0, 0);
            this.reporteHis.Name = "reporteHis";
            this.reporteHis.ReportSource = "C:\\Users\\Nico\\Desktop\\Sistema de Ventas\\DesignSistemVentas\\DesignSistemVentas\\his" +
    "toricoReport.rpt";
            this.reporteHis.Size = new System.Drawing.Size(1275, 853);
            this.reporteHis.TabIndex = 0;
            // 
            // historicoReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 853);
            this.Controls.Add(this.reporteHis);
            this.Name = "historicoReporteForm";
            this.Text = "historicoReporteForm";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer reporteHis;
    }
}