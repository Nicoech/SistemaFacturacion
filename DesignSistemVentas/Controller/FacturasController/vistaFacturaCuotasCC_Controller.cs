using DesignSistemVentas.Model;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.View.FacturasViews;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.FacturasController
{
    class vistaFacturaCuotasCC_Controller
    {
        private facturaCCFPView _vfcc;
        private VistaFacturas _vf;
        private FacturasDao _fac_dao;
        private CajaDao _cajaDao = new CajaDao();

        int cantidadCuotas = 0;
        decimal total;
        decimal importe;
        public vistaFacturaCuotasCC_Controller(facturaCCFPView vfcc)
        {
            _vfcc = vfcc;

            _fac_dao = new FacturasDao();
        }
        public vistaFacturaCuotasCC_Controller(VistaFacturas vf)
        {
            _vf = vf;

            _fac_dao = new FacturasDao();
        }

        //------------------------------------------------------------------------------------------------------------------------------
        public void traigoDatosnecesarios(VistaFacturas _vf)
        {
            _vfcc.dtpFechaInicial.Text = _vf.dtpFacturaFecha.Text;

            _vfcc.dtpFechaVto.Text = _vf.dtpFacturaFecha.Text;

            _vfcc.txtNroFactura.Text = _vf.txtNroFactura.Text;
            _vf.txtSaldo.Text = _vf.txtNetoImp.Text;


        }

        //------------------------------------------------------------------------------------------------------------------------------
        public void cambioSeleccionCuotas(VistaFacturas _vf)
        {
            _vf.txtNeto.Text = _vf.txtNetoImp.Text;
        }
        //------------------------------------------------------------------------------------------------------------------------------
        public string sacoImportexCantCuotas(string txt)
        {
            if (_vfcc.cmbBoxCantCuotas.SelectedIndex == 0)
            {

                total = Convert.ToDecimal(txt);

                importe = Math.Round(total / 6, 2);

            }
            if (_vfcc.cmbBoxCantCuotas.SelectedIndex == 1)
            {


                total = Convert.ToDecimal(txt);

                importe = Math.Round(total / 8, 2);

            }

            return importe.ToString();
        }

        //------------------------------------------------------------------------------------------------------------------------------
        public string descuentoPrimerCuotaAbonada(string anticipo)
        {
            decimal saldo;

            saldo = Convert.ToDecimal(_vf.txtSaldo.Text) - Convert.ToDecimal(anticipo);

            return saldo.ToString();
        }


        public void habilitoConfirmar(VistaFacturas _vf)
        {
            if (_vf.cmbBoxTipoCliente.SelectedIndex == 0)
            {
                _vf.btnConfirmarFacturaRegis.Visible = true;
                _vf.btnConfirmarFacturaRegis.Enabled = true;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------
        public void generoCuotasDGV(VistaFacturas _vf)
        {

            int num_fila;
            decimal saldoFinal;

            foreach (DataGridViewRow Fila in _vf.dgvFacturaCuotas.Rows)
            {
                num_fila = Fila.Index;
            }

            if (_vfcc.cmbBoxCantCuotas.SelectedIndex >= 0)
            {

                cantidadCuotas = Convert.ToInt32(_vfcc.cmbBoxCantCuotas.SelectedValue);

                if (_vf.dgvFacturaCuotas.RowCount == 0)
                {


                    _vf.txtNeto.Text = _vf.txtRecuperoValorOr.Text;

                    _vf.dgvFacturaCuotas.Rows.Add(cantidadCuotas);

                    _vf.txtSaldo.Text = _vf.txtNetoImp.Text;

                    _vf.txtTotal.Text = _vf.txtSaldo.Text;

                    _vf.txtTotalFormaDpago.Text = _vf.txtSaldo.Text;

                    saldoFinal = Convert.ToDecimal(_vf.txtSaldo.Text);

                    for (num_fila = 0; num_fila < cantidadCuotas; num_fila++)
                    {
                        _vf.dgvFacturaCuotas.Rows[num_fila].Cells[0].Value = _vfcc.txtNroFactura.Text;

                        _vf.dgvFacturaCuotas.Rows[num_fila].Cells[1].Value = (num_fila + 1).ToString();

                        _vf.dgvFacturaCuotas.Rows[num_fila].Cells[2].Value = sacoImportexCantCuotas(_vf.txtSaldo.Text);



                        if (num_fila != 0)
                        {

                            _vfcc.dtpFechaInicial.Text = Convert.ToDateTime(_vf.dtpFacturaFecha.Text).ToShortDateString();


                            DateTime fechaInicial = Convert.ToDateTime(_vf.dgvFacturaCuotas.Rows[num_fila - 1].Cells[3].Value).AddMonths(1);

                            DateTime fechaVto = Convert.ToDateTime(_vf.dgvFacturaCuotas.Rows[num_fila - 1].Cells[4].Value).AddMonths(1);


                            _vf.dgvFacturaCuotas.Rows[num_fila].Cells[3].Value = fechaInicial.ToShortDateString();
                            _vf.dgvFacturaCuotas.Rows[num_fila].Cells[4].Value = fechaVto.ToShortDateString();

                            _vf.dgvFacturaCuotas.Rows[num_fila].Cells[5].Value = "Pendiente";
                            _vf.dgvFacturaCuotas.Rows[num_fila].DefaultCellStyle.BackColor = Color.Red;
                            _vf.dgvFacturaCuotas.Rows[num_fila].DefaultCellStyle.ForeColor = Color.White;
                        }
                        else
                        {
                            _vf.txtAnticipo.Text = sacoImportexCantCuotas(saldoFinal.ToString());

                            _vf.txtSaldoAnticipo.Text = (saldoFinal - Convert.ToDecimal(_vf.txtAnticipo.Text)).ToString();

                            _vfcc.dtpFechaInicial.Text = _vf.dtpFacturaFecha.Text;

                            _vf.dgvFacturaCuotas.Rows[num_fila].Cells[3].Value = _vfcc.dtpFechaInicial.Text;
                            _vf.dgvFacturaCuotas.Rows[num_fila].Cells[4].Value = _vfcc.dtpFechaVto.Text;

                            _vf.dgvFacturaCuotas.Rows[num_fila].Cells[5].Value = "Abonada";
                            _vf.dgvFacturaCuotas.Rows[num_fila].DefaultCellStyle.BackColor = Color.Blue;
                            _vf.dgvFacturaCuotas.Rows[num_fila].DefaultCellStyle.ForeColor = Color.White;
                        }


                    }

                }
                else
                {
                    _vf.txtNeto.Text = _vf.txtRecuperoValorOr.Text;

                    _vf.dgvFacturaCuotas.Rows.Clear();

                    _vf.dgvFacturaCuotas.Rows.Add(cantidadCuotas);


                    _vf.txtSaldo.Text = _vf.txtNetoImp.Text;

                    _vf.txtNetoImp.Text = _vf.txtSaldo.Text;

                    _vf.txtTotalFormaDpago.Text = _vf.txtSaldo.Text;

                    for (num_fila = 0; num_fila < cantidadCuotas; num_fila++)
                    {
                        _vf.dgvFacturaCuotas.Rows[num_fila].Cells[0].Value = _vfcc.txtNroFactura.Text;

                        _vf.dgvFacturaCuotas.Rows[num_fila].Cells[1].Value = (num_fila + 1).ToString();

                        _vf.dgvFacturaCuotas.Rows[num_fila].Cells[2].Value = sacoImportexCantCuotas(_vf.txtSaldo.Text);


                        if (num_fila != 0)
                        {

                            _vfcc.dtpFechaInicial.Text = _vf.dtpFacturaFecha.Text;
                            DateTime fechaInicial = Convert.ToDateTime(_vf.dgvFacturaCuotas.Rows[num_fila - 1].Cells[3].Value).AddMonths(1);
                            DateTime fechaVto = Convert.ToDateTime(_vf.dgvFacturaCuotas.Rows[num_fila - 1].Cells[3].Value).AddMonths(1);


                            _vf.dgvFacturaCuotas.Rows[num_fila].Cells[3].Value = fechaInicial.ToShortDateString();
                            _vf.dgvFacturaCuotas.Rows[num_fila].Cells[4].Value = fechaVto.ToShortDateString();

                            _vf.dgvFacturaCuotas.Rows[num_fila].Cells[5].Value = "Pendiente";
                            _vf.dgvFacturaCuotas.Rows[num_fila].DefaultCellStyle.BackColor = Color.Red;
                            _vf.dgvFacturaCuotas.Rows[num_fila].DefaultCellStyle.ForeColor = Color.White;
                        }
                        else
                        {


                            _vf.txtAnticipo.Text = sacoImportexCantCuotas(_vf.txtSaldo.Text);

                            _vf.txtSaldoAnticipo.Text = (Convert.ToDecimal(_vf.txtSaldo.Text) - Convert.ToDecimal(_vf.txtAnticipo.Text)).ToString();

                            _vfcc.dtpFechaInicial.Text = _vf.dtpFacturaFecha.Text;

                            _vf.dgvFacturaCuotas.Rows[num_fila].Cells[3].Value = _vfcc.dtpFechaInicial.Text;
                            _vf.dgvFacturaCuotas.Rows[num_fila].Cells[4].Value = _vfcc.dtpFechaVto.Text;

                            _vf.dgvFacturaCuotas.Rows[num_fila].Cells[5].Value = "Abonada";
                            _vf.dgvFacturaCuotas.Rows[num_fila].DefaultCellStyle.BackColor = Color.Blue;
                            _vf.dgvFacturaCuotas.Rows[num_fila].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }

                }

            }
        }
        //------------------------------------------------------------------------------------------------------------------------------
        public void insertFacturaCuotasCC()
        {

            var FC = new FacturaCuotas();
            if (_vf.dgvFacturaCuotas.RowCount > 0)
            {

                foreach (DataGridViewRow filaProd in _vf.dgvFacturaCuotas.Rows)
                {
                    FC.Nro_Factura = Convert.ToInt16(filaProd.Cells[0].Value);
                    FC.Nro_Cuota = Convert.ToInt32(filaProd.Cells[1].Value);
                    FC.Importe = Convert.ToDecimal(filaProd.Cells[2].Value);
                    FC.fecha_inicial = Convert.ToDateTime(filaProd.Cells[3].Value);
                    FC.fecha_vto = Convert.ToDateTime(filaProd.Cells[4].Value);
                    FC.estado_cuota = (filaProd.Cells[5].Value).ToString();

                    _fac_dao.insertFacturaCuotas(FC);
                }
            }
            else
            {
                MessageBox.Show("NO SE CARGARON CUOTAS A LA FACTURA, INGRESE CANTIDAD DE CUOTAS!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public void pagoCC_CalculoCuotas_Observaciones(VistaFacturas _vf)
        {


            //EN CASO DE SELECCIONAR 6 CUOTAS
            if (_vfcc.cmbBoxCantCuotas.SelectedIndex == 0)
            {
                //_vf.txtRecargoCC.Text = "2.5%";



                _vf.txtObservaciones.Text =

                            " Cantidad de cuotas que va a abonar el cliente: " + _vfcc.cmbBoxCantCuotas.SelectedItem.ToString() +
                            ", anticipo día: " + _vfcc.dtpFechaInicial.Text + "." + "\n"
                            + " Importe Total: $ " + _vf.txtTotal.Text + "." + "\n" +
                            " Saldo(descontando anticipacion): $ " + _vf.txtSaldoAnticipo.Text
                            + " en cuotas mensuales de $ " + _vf.txtAnticipo.Text + " c/u" + "\n" +
                            " que se abonaran a partir del dia " + _vfcc.dtpFechaInicial.Value.Day.ToString() + " hasta el día " + _vfcc.dtpFechaVto.Value.Day + " de " + _vfcc.dtpFechaVto.Value.Year + " de cada mes";



                _vf.txtObservaciones.Enabled = false;
            }

            //EN CASO DE SELECCIONAR 8 CUOTAS
            if (_vfcc.cmbBoxCantCuotas.SelectedIndex == 1)
            {
                //_vf.txtRecargoCC.Text = "5%";



                _vf.txtObservaciones.Text =

                            " Cantidad de cuotas que va a abonar el cliente: " + _vfcc.cmbBoxCantCuotas.SelectedItem.ToString() +
                            ", anticipo día: " + _vfcc.dtpFechaInicial.Text + "." + "\n"
                            + " Importe Total : $ " + _vf.txtTotal.Text + "." + "\n" +
                            " Saldo(descontando anticipacion): $ " + _vf.txtSaldoAnticipo.Text
                            + " en cuotas mensuales de $ " + _vf.txtAnticipo.Text + " c/u" + "\n" +
                            " que se abonaran a partir del dia" + _vfcc.dtpFechaInicial.Value.Day.ToString() + " hasta el día " + _vfcc.dtpFechaVto.Value.Day + " de " + _vfcc.dtpFechaVto.Value.Year + " de cada mes";

                _vf.txtObservaciones.Enabled = false;
            }

            ////EN CASO DE SELECCIONAR 8 CUOTAS
            //if (_vfcc.cmbBoxCantCuotas.SelectedIndex == 2)
            //{
            //    //_vf.txtRecargoCC.Text = "10%";



            //    _vf.txtObservaciones.Text =
            //                " Cantidad de cuotas que va a abonar el cliente: " + _vfcc.cmbBoxCantCuotas.SelectedItem.ToString() +
            //                ", anticipo día: " + _vfcc.dtpFechaInicial.Text + "." + "\n"
            //                + " Importe Total(con recargo por abonar en cuotas): $ " + _vf.txtTotal.Text + "." + "\n" +
            //                " Saldo(descontando anticipacion): $ " + _vf.txtSaldoAnticipo.Text
            //                + " en cuotas mensuales de $ " + _vf.txtAnticipo.Text + " c/u" + "\n" +
            //                " que se abonaran a partir del dia " + _vfcc.dtpFechaInicial.Value.Day.ToString() + " hasta el día " + _vfcc.dtpFechaVto.Value.Day + " de " + _vfcc.dtpFechaVto.Value.Year + " de cada mes";


            //    _vf.txtObservaciones.Enabled = false;
            //}



        }

    }
}
