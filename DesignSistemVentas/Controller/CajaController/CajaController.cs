using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using DesignSistemVentas.View.CajaView;
using System.Windows.Forms;
using DesignSistemVentas.Model.Dao;

namespace DesignSistemVentas.Controller.CajaController
{
    class CajaController
    {
        private DataSet ds = new DataSet();
        private CajaDao _cDao = new CajaDao();
        private cajaView _cv;

        public CajaController(cajaView cv)
        {
            _cv = cv;
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

    }
}
