using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.View.CajaView;
using System;
using System.Data;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.CajaController
{
    class CajaController
    {
        private DataSet ds = new DataSet();
        private CajaDao _cDao = new CajaDao();
        private cajaView _cv;
        decimal suma;
        decimal total;
        public CajaController(cajaView cv)
        {
            _cv = cv;
        }
        public void setViewToSellerUser()
        {
            _cv.btnModificarMovimiento.Enabled = false;
            _cv.btnEliminarMovimiento.Enabled = false;
        }
        public void generoReportCaja()
        {
            CajaR c = new CajaR();

            cajaReportForm crf = new cajaReportForm();


            c.SetDataSource(ds);
            crf.crystalReport.ReportSource = c;
            crf.ShowDialog();
        }

        public void traigoMovimientosbyFiltro(DataGridView dgv)
        {
            dgv.DataSource = _cDao.searchMovimientosbyFiltro(_cv.cmbTipo.Text);
        }


        public void traigoMovimientosbyFechas(DataGridView dgv)
        {
            dgv.DataSource = _cDao.searchMovimientosbyFecha(_cv.dtpInicial, _cv.dtpLimite);
        }

        public void generoTotalCaja(DataGridView dgv)
        {
            total = 0;
            foreach (DataGridViewRow filaProd in dgv.Rows)
            {
                suma = Convert.ToDecimal(filaProd.Cells[4].Value);
                total += suma;

                _cv.txtTotalCaja.Text = total.ToString();
            }
        }
    }
}
