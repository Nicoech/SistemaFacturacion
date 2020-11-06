namespace DesignSistemVentas.View.CuentasCorrientesView
{
    partial class reciboCTACTEReporteForm
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
            this.reporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reporte
            // 
            this.reporte.ActiveViewIndex = 0;
            this.reporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.reporte.DisplayStatusBar = false;
            this.reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporte.Location = new System.Drawing.Point(0, 0);
            this.reporte.Name = "reporte";
            this.reporte.ReportSource = "C:\\Users\\Nico\\Desktop\\Sistema de Ventas\\DesignSistemVentas\\DesignSistemVentas\\rec" +
    "iboCTACTE.rpt";
            this.reporte.Size = new System.Drawing.Size(1115, 574);
            this.reporte.TabIndex = 0;
            // 
            // reciboCTACTEReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 574);
            this.Controls.Add(this.reporte);
            this.Name = "reciboCTACTEReporteForm";
            this.Text = "reciboCTACTEReporteForm";
            this.ResumeLayout(false);

        }

        #endregion
        public CrystalDecisions.Windows.Forms.CrystalReportViewer reporte;
    }
}