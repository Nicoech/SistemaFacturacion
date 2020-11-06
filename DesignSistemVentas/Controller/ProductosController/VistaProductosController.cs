using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.View;
using DesignSistemVentas.View.ProductosViews;
using System;
using System.Data;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.ProductosController
{
    class VistaProductosController
    {
        private VistaProductos _vp;
        private ModificacionesProductos _mp;
        private ProductosDao _pdao;
        private DataSet ds = new DataSet();
        public VistaProductosController(VistaProductos vp)
        {
            _vp = vp;
            _pdao = new ProductosDao();
        }
        public VistaProductosController(ModificacionesProductos mp)
        {
            _mp = mp;
            _pdao = new ProductosDao();
        }

        public void setViewToSellerUser()
        {
            _vp.btnAgregarProducto.Visible = false;
            _vp.btnModificarProducto.Visible = false;
            _vp.btnEliminarProducto.Visible = false;
            _vp.dgvProductos.Enabled = false;
        }


        public void searchProductsIntoDb()
        {
            _pdao.SearchProducts(_vp.dgvProductos);
        }

        public void searchProductosIntoDbByCodOrDescripcion()
        {

            _pdao.SearchProductByCodOrDescription(_vp.dgvProductos, _vp.txtBusquedaProductos.Text);
        }

        public void generoReportProductos()
        {
            productosReport c = new productosReport();

            productosReportForm prf = new productosReportForm();
            c.SetDataSource(ds);
            prf.crystalReport.ReportSource = c;
            prf.ShowDialog();
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
    }
}
