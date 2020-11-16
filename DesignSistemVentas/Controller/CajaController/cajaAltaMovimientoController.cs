using DesignSistemVentas.Model;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.Utilities;
using DesignSistemVentas.View;
using DesignSistemVentas.View.CajaView;
using System;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.CajaController
{
    class cajaAltaMovimientoController
    {
        private cajaAgregar _ca;
        private Constants c = new Constants();
        private CajaDao cDao = new CajaDao();
        private agregarClienteMovimiento _acm;
        private cajaView _cv;
        private Caja _cajaModel = new Caja();
        public cajaAltaMovimientoController(cajaAgregar ca)
        {
            _ca = ca;
        }
        public cajaAltaMovimientoController(agregarClienteMovimiento acm)
        {
            _acm = acm;
        }
        public cajaAltaMovimientoController(cajaView cv)
        {
            _cv = cv;
        }

        public void generoNroPlanilla()
        {
            _ca.txtIDPlanilla.Text = cDao.obtengoNroPlanilla().ToString();
        }
        public void accionesCajaAltaMovimientosLoad()
        {
            _ca.cmbTipoMovimiento.DataSource = c.TipoMovimientoCaja();
        }

        public void searchMovimientosCaja(cajaView _cv)
        {
            if (cDao.searchCaja(_cv.dgvCaja) == false)
            {
                MessageBox.Show("NO SE ENCONTRARON MOVIMIENTOS DE CAJA!");
            }
        }
        public void AltaMovimientoCaja(cajaView _cv)
        {

            _cajaModel.Nro_Planilla = Convert.ToInt32(_ca.txtIDPlanilla.Text);

            _cajaModel.Tipo = _ca.cmbTipoMovimiento.Text;

            _cajaModel.Descripcion = _ca.txtDescripcion.Text;

            _cajaModel.Detalle = _ca.txtDetalle.Text;

            _cajaModel.Valor = Convert.ToDecimal(_ca.txtImporte.Text);

            _cajaModel.Fecha = _ca.dtpFechaMovimiento.Text;


            if (cDao.InsertMovimientoCaja(_cajaModel))
            {
                MsgBox msg = new MsgBox();

                msg.lblMsg.Text = "NUEVO MOVIMIENTO INGRESADO A LA CAJA CON EXITO!";

                msg.ShowDialog();


                var result = System.Windows.Forms.MessageBox.Show("DESEA DAR DEL ALTA OTRO MOVIMIENTO?", "ALTA MOVIMIENTO CAJA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    VaciarDatos();
                }
                else
                {
                    Form.ActiveForm.Close();

                    searchMovimientosCaja(_cv);
                }
            }

            Form.ActiveForm.Close();

        }

        public void VaciarDatos()
        {
            _ca.txtIDPlanilla.Text = "";
            _ca.txtDescripcion.Clear();
            _ca.txtDetalle.Clear();
            _ca.txtMonto.Clear();

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
