using CrystalDecisions.Shared;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.View.HistoricoClientesFacturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.HistoricoController
{
    class historicoController
    {
        private cargoClienteHistorico _cch;
        private HistoricoClientesView _hcv;
        private historicoDao hDao = new historicoDao();

        private string PATHReport;
        public historicoController(cargoClienteHistorico cch)
        {
            _cch = cch;
        }

        public historicoController(HistoricoClientesView hcv)
        {
            _hcv = hcv;
        }

        public void traigoFacturasHistoricoByDniCliente(DataGridView dgv)
        {
            dgv.DataSource = hDao.searchFacturasByDNICliente(_hcv.txtDNICliente.Text);
        }
        public void traigoFacturasHistoricoByFechas(DataGridView dgv)
        {
            dgv.DataSource = hDao.searchFacturasByFechas(_hcv.txtDNICliente.Text,_hcv.dtpInicial,_hcv.dtpFinal);
        }

        public void ExportarAExcel(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {

                dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                dgv.MultiSelect = true;
                dgv.SelectAll();
                DataObject dataObj = dgv.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);

                dgv.MultiSelect = false;
                dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;

                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object valor = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(valor);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
            else
            {
                MessageBox.Show("NO SE ENCONTRARON REGISTROS PARA EXPORTAR!", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void generoFacturaHistorico(string dni)
        {


            var result = System.Windows.Forms.MessageBox.Show("DESEA EXPORTAR HISTORICO DE CLIENTE?", "REIMPRESION FACTURA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {


                historicoReporteForm hrf = new historicoReporteForm();

                ParameterField pf = new ParameterField();
                ParameterFields pfs = new ParameterFields();
                ParameterDiscreteValue pdv = new ParameterDiscreteValue();

                pf.Name = "@dni";

                pdv.Value = dni;

                pf.CurrentValues.Add(pdv);
                pfs.Add(pf);

                hrf.reporteHis.ParameterFieldInfo = pfs;

                PATHReport = Environment.CurrentDirectory + @"\historicoReport.rpt";

                hrf.ShowDialog();
            }


        }

    }
}
