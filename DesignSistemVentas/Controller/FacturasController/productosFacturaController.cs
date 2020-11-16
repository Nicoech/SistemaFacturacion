using DesignSistemVentas.Model;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.View.FacturasViews;
using System;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.FacturasController
{
    class productosFacturaController
    {

        private FacturasDao fac_Dao = new FacturasDao();

        private VistaFacturas _vf;

        private cargoProductosFactura _cpf;

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public productosFacturaController(VistaFacturas vf)
        {

            _vf = vf;
        }


        public productosFacturaController(cargoProductosFactura cpf)
        {
            _cpf = cpf;
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public void traigoProductos()
        {
            fac_Dao.searchProductosFactura(_cpf.dgvProductosFactura);
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------

        public void bindDataProducto()
        {

            _cpf.txtCodigo.Text = _cpf.dgvProductosFactura.CurrentRow.Cells[0].Value.ToString();
            _cpf.txtDescripcion.Text = _cpf.dgvProductosFactura.CurrentRow.Cells[1].Value.ToString();
            _cpf.txtPrecio.Text = _cpf.dgvProductosFactura.CurrentRow.Cells[2].Value.ToString();
            _cpf.txtStockActual.Text = _cpf.dgvProductosFactura.CurrentRow.Cells[3].Value.ToString();

        }

        public bool descuentoCantidad()
        {
            var P = new Productos();


            P.ID_Producto = Convert.ToInt32(_cpf.txtCodigo.Text);
            P.Stock_Act = Convert.ToInt32(_cpf.txtCantidad.Text);

            var result = System.Windows.Forms.MessageBox.Show("ESTA SEGURO DE AGREGAR LA CANTIDAD SELECCIONADA?, ESTA CANTIDAD SE ELIMINARA DEL STOCK ACTUAL DE PRODUCTO", "INGRESAR PRODUCTO FACTURA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                fac_Dao.descuentoCantidad(P);
                return true;
            }
            else
            {
                return false;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public bool adicionCantidad()
        {
            var P = new Productos();


            P.ID_Producto = Convert.ToInt32(_vf.dgvFactura.CurrentRow.Cells[0].Value);
            P.Stock_Act = Convert.ToInt32(_vf.dgvFactura.CurrentRow.Cells[3].Value);

            var result = System.Windows.Forms.MessageBox.Show("ESTA SEGURO DE ELIMINAR EL PRODUCTO?, EL STOCK DESCONTADO VOLVERA A AGREGARSE AL STOCK DEL PRODUCTO", "PRODUCTOS FACTURA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                fac_Dao.adicionCantidad(P);
                return true;
            }
            else
            {
                return false;
            }

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        public static int cont_fila = 0;
        public static decimal total = 0;
        public static decimal neto = 0;
        public static decimal iva = 0;
        public void agregoProductoFactura(VistaFacturas _vf)
        {

            bool existe = false;
            int num_fila = 0;


            if (cont_fila == 0)
            {

                _vf.dgvFactura.Rows.Add(_cpf.txtCodigo.Text, _cpf.txtDescripcion.Text, _cpf.txtPrecio.Text, _cpf.txtCantidad.Text);

                double precio = Convert.ToDouble(_vf.dgvFactura.Rows[cont_fila].Cells[2].Value);
                double cantidad = Convert.ToDouble(_vf.dgvFactura.Rows[cont_fila].Cells[3].Value);

                double importe = precio * cantidad;

                _vf.dgvFactura.Rows[cont_fila].Cells[4].Value = importe;

                cont_fila++;

                _vf.txtCantProd.Text = (_vf.dgvFactura.RowCount).ToString();

            }
            else
            {

                foreach (DataGridViewRow Fila in _vf.dgvFactura.Rows)
                {
                    if (Fila.Cells[0].Value.ToString() == _cpf.txtCodigo.Text)
                    {
                        existe = true;
                        num_fila = Fila.Index;

                    }
                }

                if (existe == true)
                {

                    _vf.dgvFactura.Rows[num_fila].Cells[3].Value = (Convert.ToInt32(_cpf.txtCantidad.Text) + Convert.ToInt32(_vf.dgvFactura.Rows[num_fila].Cells[3].Value)).ToString();


                    double importe = (Convert.ToDouble(_vf.dgvFactura.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(_vf.dgvFactura.Rows[num_fila].Cells[3].Value));


                    _vf.dgvFactura.Rows[num_fila].Cells[4].Value = importe;


                    _vf.txtCantProd.Text = (_vf.dgvFactura.RowCount).ToString();

                }
                else
                {

                    num_fila = _vf.dgvFactura.Rows.Add(_cpf.txtCodigo.Text, _cpf.txtDescripcion.Text, _cpf.txtPrecio.Text, _cpf.txtCantidad.Text);

                    double importe = (Convert.ToDouble(_vf.dgvFactura.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(_vf.dgvFactura.Rows[num_fila].Cells[3].Value));

                    _vf.dgvFactura.Rows[num_fila].Cells[4].Value = importe;

                    cont_fila++;
                }

                _vf.txtCantProd.Text = (_vf.dgvFactura.RowCount).ToString();
            }
            sacoTotal(_vf);
        }

        public void sacoTotal(VistaFacturas _vf)
        {
            //VOY SUMANDO TOTAL DE LOS IMPORTES DE CADA PRODUCTO

            foreach (DataGridViewRow dgv in _vf.dgvFactura.Rows)
            {
                if (dgv.Index == 0)
                {


                    if (_vf.txtSitIVA.Text == "RESPONSABLE INSCRIPTO")
                    {


                        neto = Convert.ToDecimal(dgv.Cells[4].Value);



                        _vf.txtNeto.Text = neto.ToString("N");

                        _vf.txtRecuperoValorOr.Text = neto.ToString("N");

                        total = Math.Round(neto, 2);

                        _vf.txtTotal.Text = total.ToString("N");
                        _vf.txtTotalFormaDpago.Text = total.ToString("N");
                        _vf.txtEfectivo.Text = total.ToString("N");
                        _vf.txtNetoImp.Text = total.ToString("N");

                        _vf.txtIVA.Text = "0 %";


                    }
                    else
                    {

                        neto = Convert.ToDecimal(dgv.Cells[4].Value);

                        _vf.txtNeto.Text = neto.ToString("N");

                        _vf.txtRecuperoValorOr.Text = neto.ToString("N");

                        total = Math.Round((neto * 0.21M) + neto, 2);

                        _vf.txtTotal.Text = total.ToString("N");
                        _vf.txtTotalFormaDpago.Text = total.ToString("N");
                        _vf.txtEfectivo.Text = total.ToString("N");
                        _vf.txtNetoImp.Text = total.ToString("N");

                        _vf.txtIVA.Text = "21 %";
                    }


                }
                else
                {

                    if (_vf.txtSitIVA.Text == "RESPONSABLE INSCRIPTO")
                    {

                        _vf.txtIVA.Text = "0 %";

                        neto = Convert.ToDecimal(dgv.Cells[4].Value) + Convert.ToDecimal(_vf.txtNeto.Text);

                        _vf.txtNeto.Text = neto.ToString();

                        total = Math.Round(neto, 2);

                        _vf.txtRecuperoValorOr.Text = neto.ToString("N");
                        _vf.txtNetoImp.Text = total.ToString("N");
                        _vf.txtTotal.Text = total.ToString("N");
                        _vf.txtTotalFormaDpago.Text = total.ToString("N");
                        _vf.txtEfectivo.Text = total.ToString("N");

                    }
                    else
                    {
                        _vf.txtIVA.Text = "21 %";

                        neto = Convert.ToDecimal(dgv.Cells[4].Value) + Convert.ToDecimal(_vf.txtNeto.Text);

                        _vf.txtNeto.Text = neto.ToString();

                        total = Math.Round((neto * 0.21M) + neto, 2);

                        _vf.txtRecuperoValorOr.Text = neto.ToString("N");
                        _vf.txtNetoImp.Text = total.ToString("N");
                        _vf.txtTotal.Text = total.ToString("N");
                        _vf.txtTotalFormaDpago.Text = total.ToString("N");
                        _vf.txtEfectivo.Text = total.ToString("N");

                    }

                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public void vuelto()
        {
            if (_vf.txtImporteAbonado.Text != "")
            {
                decimal importeAbonado = Convert.ToDecimal(_vf.txtImporteAbonado.Text);

                decimal vuelto = total - importeAbonado;

                _vf.txtVuelto.Text = vuelto.ToString();
            }
            else
            {
                _vf.txtImporteAbonado.Text = "";
            }


        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------

        public void eliminoProducto()
        {

            if (_vf.dgvFactura.RowCount > 0)
            {
                neto = (Convert.ToDecimal(_vf.txtNeto.Text)) - (Convert.ToDecimal(_vf.dgvFactura.Rows[_vf.dgvFactura.CurrentRow.Index].Cells[4].Value));

                _vf.txtNeto.Text = neto.ToString();

                _vf.txtNetoImp.Text = "0.00";

                if (_vf.txtSitIVA.Text == "CONSUMIDOR FINAL")
                {
                    iva = Convert.ToDecimal(_vf.txtNeto.Text) * 0.21M;

                    total = Math.Round(Convert.ToDecimal(_vf.txtNeto.Text) + iva, 2);
                }
                else
                {
                    total = Math.Round(Convert.ToDecimal(_vf.txtNeto.Text) + iva, 2);
                }

                _vf.txtNetoImp.Text = total.ToString();

                _vf.txtTotal.Text = total.ToString();

                _vf.txtTotalFormaDpago.Text = total.ToString();

                _vf.txtEfectivo.Text = total.ToString();

                _vf.dgvFactura.Rows.RemoveAt(_vf.dgvFactura.CurrentRow.Index);

                _vf.txtCantProd.Text = (_vf.dgvFactura.RowCount).ToString();

                vaciarDatos();

                cont_fila--;



            }
            else
            {
                MessageBox.Show("DEBE TENER AL MENOS UN PRODUCTO EN LA FACTURA PARA PODER ELIMINARLO");
            }

        }

        public void vaciarDatos()
        {
            _vf.txtImporteAbonado.Text = "0.00 ";
            _vf.txtVuelto.Text = "0.00";
            _vf.txtFechaC1.Text = "0.00";
            _vf.txtImporte1.Text = "0.00";
            _vf.txtImporte2.Text = "0.00";
            _vf.txtImporte3.Text = "0.00";
            _vf.txtImporte4.Text = "0.00";
            _vf.txtImporte5.Text = "0.00";
            _vf.txtImporte6.Text = "0.00";
            _vf.txtFechaC1.Text = "";
            _vf.txtFechaC2.Text = "";
            _vf.txtFechaC3.Text = "";
            _vf.txtFechaC4.Text = "";
            _vf.txtFechaC5.Text = "";
            _vf.txtFechaC6.Text = "";
            _vf.txtObservaciones.Text = "";
            _vf.cmbFormaDePago.DataSource = null;
        }
        public void Sololetras(KeyPressEventArgs e)
        {
            // Validacion de textbox para solo letras.

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO SE PUEDEN INGRESAR LETRAS.", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SoloNumeros(KeyPressEventArgs e)
        {
            // Validacion de textbox para solo letras.
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO SE PUEDEN INGRESAR NUMEROS.", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
