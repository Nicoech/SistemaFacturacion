using DesignSistemVentas.Model;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.View;
using DesignSistemVentas.View.CajaView;
using System;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.CajaController
{
    class cajaDeleteMovimientoController
    {
        private CajaDao _cDao = new CajaDao();
        private cajaView _cv;
        private Caja _cajaModel = new Caja();
        public cajaDeleteMovimientoController(cajaView cv)
        {
            _cv = cv;
        }
        public void DeleteMovimientoCaja(cajaView _cv)
        {

            if (_cv.dgvCaja.SelectedCells.Count > 0)
            {

                int selectedRowIndex = _cv.dgvCaja.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = _cv.dgvCaja.Rows[selectedRowIndex];

                _cajaModel.Nro_Planilla = Convert.ToInt32(selectedRow.Cells["Nro_Planilla"].Value);

                if (_cDao.selectCondicion("Caja", "Nro_Planilla = " + _cajaModel.Nro_Planilla) == true)
                {

                    _cDao.deleteMovimientoCaja(_cajaModel);

                    MsgBox msg = new MsgBox();

                    msg.lblMsg.Text = "MOVIMIENTO DE CAJA" + "\n" + "ELIMINADO CON EXITO!";

                    msg.ShowDialog();

                    _cDao.searchCaja(_cv.dgvCaja);
                }
            }

        }
    }
}
