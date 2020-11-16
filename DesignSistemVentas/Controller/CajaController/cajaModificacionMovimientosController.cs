using DesignSistemVentas.Model;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.Utilities;
using DesignSistemVentas.View;
using DesignSistemVentas.View.CajaView;
using System;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.CajaController
{
    class cajaModificacionMovimientosController
    {

        private cajaModificar _cm;
        private Caja _cajaModel = new Caja();
        Constants c = new Constants();
        private CajaDao _cDao = new CajaDao();
        private agregarClienteMovimientoModif _acm;

        public cajaModificacionMovimientosController(cajaModificar cm)
        {
            _cm = cm;
        }
        public cajaModificacionMovimientosController(agregarClienteMovimientoModif acm)
        {
            _acm = acm;
        }


        public void traigoClientesCaja(agregarClienteMovimientoModif _acm)
        {
            _cDao.searchClientesCaja(_acm.dgvClientesCaja);
        }


        public void bindDataCliente(cajaModificar _cm)
        {
            _cm.txtDescripcion.Text = _acm.dgvClientesCaja.CurrentRow.Cells[1].Value.ToString() + " " + _acm.dgvClientesCaja.CurrentRow.Cells[2].Value.ToString() + " " + _acm.dgvClientesCaja.CurrentRow.Cells[3].Value.ToString();
            _acm.Close();
        }

        public void bindDataMovimiento(cajaView _cv)
        {
            cajaModificar cm = new cajaModificar(_cv);

            cm.txtIDPlanilla.Text = _cv.dgvCaja.CurrentRow.Cells[0].Value.ToString();
            cm.cmbTipoMovimiento.Text = _cv.dgvCaja.CurrentRow.Cells[1].Value.ToString();
            cm.txtDescripcion.Text = _cv.dgvCaja.CurrentRow.Cells[2].Value.ToString();
            cm.txtDetalle.Text = _cv.dgvCaja.CurrentRow.Cells[3].Value.ToString();
            cm.txtMonto.Text = _cv.dgvCaja.CurrentRow.Cells[4].Value.ToString();
            cm.ShowDialog();


        }
        public void searchMovimientosCaja(cajaView _cv)
        {
            _cDao.searchCaja(_cv.dgvCaja);
        }
        public void updateMovimientoCaja(cajaView _cv)
        {

            _cajaModel.Nro_Planilla = Convert.ToInt32(_cm.txtIDPlanilla.Text);

            _cajaModel.Tipo = _cm.cmbTipoMovimiento.Text;

            _cajaModel.Descripcion = _cm.txtDescripcion.Text;

            _cajaModel.Detalle = _cm.txtDetalle.Text;

            _cajaModel.Valor = Convert.ToDecimal(_cm.txtMonto.Text);

            _cajaModel.Fecha = _cm.dtpFechaMovimiento.Text;


            if (_cDao.UpdateMovimientoCaja(_cajaModel))
            {
                MsgBox msg = new MsgBox();

                msg.lblMsg.Text = "MOVIMIENTO MODIFICADO CON EXITO!";

                msg.ShowDialog();

                Form.ActiveForm.Close();

                searchMovimientosCaja(_cv);
            }

        }

        public void NumerosConComa(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 44)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }

        }

    }
}
