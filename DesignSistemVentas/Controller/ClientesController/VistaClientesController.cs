using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.View;
using DesignSistemVentas.View.ClientesViews;
using System;
using System.Data;
using System.Windows.Forms;


namespace DesignSistemVentas.Controller.ClientesController
{
    class VistaClientesController
    {
        private VistaClientes _vc;
        private ClientesDao _clnDao;
        private DataSet ds = new DataSet();
        public VistaClientesController(VistaClientes vc)
        {
            _vc = vc;
            _clnDao = new ClientesDao();
        }

        public void setViewToSellerUser()
        {
            _vc.btnAgregarCliente.Visible = false;
            _vc.dgvClientes.Enabled = false;
            _vc.btnModificarClientes.Visible = false;
            _vc.btnEliminarCliente.Visible = false;
            _vc.panel3.Visible = false;

        }

        public void searchClientes()
        {
            _clnDao.SearchClients(_vc.dgvClientes);
        }

        public void SearchClientsByIDorDNI()
        {
            _clnDao.SearchClientsByIDorDNI(_vc.dgvClientes, _vc.txtBusquedaClientes.Text);
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

        public void generoReportClientes()
        {
            clienteReport c = new clienteReport();

            clientesReportForm crf = new clientesReportForm();
            c.SetDataSource(ds);
            crf.crystalReport.ReportSource = c;
            crf.ShowDialog();
        }

    }
}
