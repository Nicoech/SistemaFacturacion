using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DesignSistemVentas.Model;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.View;
using DesignSistemVentas.View.FacturasViews;
using DesignSistemVentas.View.FacturasViews.ReimprimirFactura;
using DesignSistemVentas.View.RemitosViews;
using System;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.FacturasController
{
    class vistaEncabezadoFacturaController
    {

        private ReportDocument oRep = new ReportDocument();
        private VistaFacturas _vf;
        private vistaFacturaCuotasCC_Controller _vfcc;
        private facturaFPTarjetaView _ft;
        private FacturasDao _fac_dao;
        private vistaReimprimoFacturas _vrf;
        private cargoClientesFactura _ccf;
        private productosFacturaController _pf_ctr;
        private CajaDao _cajaDao = new CajaDao();

        private string PATHReport;

        MsgBox msg = new MsgBox();

        private Utilities.Constants c = new Utilities.Constants();
        public vistaEncabezadoFacturaController(VistaFacturas vf)
        {
            _fac_dao = new FacturasDao();

            _vf = vf;

            _pf_ctr = new productosFacturaController(_vf);

            _vfcc = new vistaFacturaCuotasCC_Controller(_vf);
        }
        public vistaEncabezadoFacturaController(cargoClientesFactura ccf)
        {
            _ccf = ccf;
        }
        public vistaEncabezadoFacturaController(facturaFPTarjetaView ft)
        {
            _ft = ft;
        }

        public vistaEncabezadoFacturaController(vistaReimprimoFacturas vrf)
        {
            _vrf = vrf;
        }
//--------------------------------------------------------------------------------------------------------------------------------------------------
        public void cerrarVentana()
        {
            if (MessageBox.Show("¿DESEA CERRAR ESTA VENTANA?", "CERRAR ESTA VENTANA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Form.ActiveForm.Close();
            }
        }

//--------------------------------------------------------------------------------------------------------------------------------------------------
        public void generoFactura(int NroFac, string nt, string iv, string ivaImp)
        {

            facturaReporteForm fcr = new facturaReporteForm();
            ParameterField pf = new ParameterField();
            ParameterFields pfs = new ParameterFields();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();

            pf.Name = "@Nro_Fac";
            pdv.Value = NroFac;
            pf.CurrentValues.Add(pdv);
            pfs.Add(pf);

            fcr.crystalReport.ParameterFieldInfo = pfs;

            PATHReport = Environment.CurrentDirectory + @"\Factura.rpt";

            oRep.Load(PATHReport);

            TextObject neto;
            TextObject IVA;
            TextObject ivaImpuesto;

            if (oRep.ReportDefinition.ReportObjects["neto"] != null)
            {
                neto = (TextObject)oRep.ReportDefinition.ReportObjects["neto"];
                neto.Text = nt;
            }
            if (oRep.ReportDefinition.ReportObjects["iva"] != null)
            {
                IVA = (TextObject)oRep.ReportDefinition.ReportObjects["iva"];
                IVA.Text = iv;
            }

            if (oRep.ReportDefinition.ReportObjects["IVAImp"] != null)
            {
                ivaImpuesto = (TextObject)oRep.ReportDefinition.ReportObjects["IVAImp"];
                ivaImpuesto.Text = ivaImp;
            }

            fcr.crystalReport.ReportSource = oRep;

            fcr.ShowDialog();

        }

        public void ExportarTopdf(ReportDocument oRep)
        {
            try
            {
                ExportOptions CrExportOptions;
                DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
                CrDiskFileDestinationOptions.DiskFileName = "C:\\Facturas\\Factura1.pdf";
                CrExportOptions = oRep.ExportOptions;
                {
                    CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                    CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                    CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                    CrExportOptions.FormatOptions = CrFormatTypeOptions;
                }
                oRep.Export();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
     
//--------------------------------------------------------------------------------------------------------------------------------------------------
        public void generoRemito(int NroRemito)
        {

            reportRemito RRF = new reportRemito();
            ReportDocument oRep = new ReportDocument();
            ParameterField pf = new ParameterField();
            ParameterFields pfs = new ParameterFields();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();

            pf.Name = "@Nro_Rem";
            pdv.Value = NroRemito;
            pf.CurrentValues.Add(pdv);
            pfs.Add(pf);

            RRF.remitoReport.ParameterFieldInfo = pfs;

            PATHReport = Environment.CurrentDirectory + @"\Remito.rpt";

            oRep.Load(PATHReport);

            RRF.remitoReport.ReportSource = oRep;

            RRF.ShowDialog();

        }
//--------------------------------------------------------------------------------------------------------------------------------------------------
public bool insertEncabezadoFactura()
        {
            bool inserte = false;
            var producto = new Facturacion();
            int Nro_Remito;

            //CHEQUEO QUE LOS VALORES DE LOS TEXTBOXS NO ESTEN VACIOS O SEAN NULOS
            if ((_vf.txtNroFactura.Text != "") & (_vf.txtIDCliente.Text != "") & (_vf.txtSitIVA.Text != "") & (_vf.txtDomicilio.Text != "") & (_vf.txtNombreCliente.Text != "") & (_vf.txtVendedor.Text != ""))
            {
                //RECORRO LA GRILLA Y VOY TOMANDO LOS VALORES DE CADA PRODUCTO PARA INSERTAR EN FACTURA
                foreach (DataGridViewRow filaProd in _vf.dgvFactura.Rows)
                {
                    producto.ID_Producto = Convert.ToInt32(filaProd.Cells[0].Value);
                    producto.Cantidad = Convert.ToInt32(filaProd.Cells[3].Value);

                    producto.Nro_Factura = Convert.ToInt32(_vf.txtNroFactura.Text);
                    producto.Letra_Factura = Convert.ToChar(_vf.cmbBoxLetraF.Text);
                    producto.ID_Cliente = Convert.ToInt32(_vf.txtIDCliente.Text);
                    producto.Nro_DNI = Convert.ToInt32(_vf.txtDNICliente.Text);
                    producto.FormaDePago = Convert.ToString(_vf.cmbFormaDePago.Text);
                    producto.Fecha_Emision = Convert.ToDateTime(_vf.dtpFacturaFecha.Text);
                    producto.Vendedor = Convert.ToString(_vf.txtVendedor.Text);
                    producto.Saldo = Convert.ToDecimal(_vf.txtSaldoAnticipo.Text);
                    producto.neto = Convert.ToDecimal(_vf.txtNeto.Text);
                    producto.iva = _vf.txtIVA.Text;
                    producto.netoIVA = Convert.ToDecimal(_vf.txtNetoImp.Text);
                    producto.Observaciones = _vf.txtObservaciones.Text;
                    producto.total = Convert.ToDecimal(_vf.txtTotal.Text);

                    //INSERTO FACTURA EN BASE DE DATOS
                    if ((_vf.cmbFormaDePago.SelectedIndex == 0) || (_vf.cmbFormaDePago.SelectedIndex == 1))
                    {
                        insertoFacturaIngresoCaja();
                        _fac_dao.insertoFacturaDao(producto);
                    }
                    else
                    {
                         insertoFacturaCCIngresoCaja();
                        _fac_dao.insertoFacturaDaoCC(producto);
                    }

                    inserte = true;
                }
                if (Convert.ToInt32(_vf.txtCantProd.Text) > 0)
                {
                    if (inserte == true)
                    {
                        //INSERTO TOTAL FACTURA EN BASE DE DATOS (CONSULTO NUMERO DE FACTURA AL CUAL PERTENECE)


                        _fac_dao.guardoTotalFactura(Convert.ToInt32(_vf.txtNroFactura.Text), Convert.ToDecimal(_vf.txtTotal.Text), _vf.txtIVA.Text, Convert.ToDecimal(_vf.txtNeto.Text), Convert.ToDecimal(_vf.txtNetoImp.Text), _vf.txtObservaciones.Text);

                        //EN CASO DE QUE EL PAGO SEA POR CUENTA CORRIENTE EN CUOTAS
                        if (_vf.cmbFormaDePago.SelectedIndex == 2)
                        {
                            //INSERTO CANTIDAD DE CUOTAS Y A QUE FACTURA PERTENECEN
                            _vfcc.insertFacturaCuotasCC();

                            if (_vf.txtNroRemito.Text != "")
                            {

                                Nro_Remito = InsertoEncabezadoRemito();

                                msg.lblMsg.Text = "FACTURA Y REMITO CARGADOS CON EXITO!";

                                msg.ShowDialog();

                                //GENERO REPORTE DE FACTURA CORRESPONDIENTE.
                                generoFactura(producto.Nro_Factura, _vf.txtNeto.Text, _vf.txtIVA.Text, _vf.txtNetoImp.Text);

                                generoRemito(Nro_Remito);

                                //VACIO DATOS FORM VISTA-FACTURA
                                vaciarDatosYdesahilitarBotones();

                                //STORE PROCEDURE QUE GENERA NUEVO NUMERO  DE FACTURA
                                generoNroFactura();

                            }
                            else
                            {

                                msg.lblMsg.Text = "FACTURA CARGADA CON EXITO!";

                                msg.ShowDialog();

                                generoFactura(producto.Nro_Factura, _vf.txtNeto.Text, _vf.txtIVA.Text, _vf.txtNetoImp.Text);

                                //VACIO DATOS FORM VISTA-FACTURA
                                vaciarDatosYdesahilitarBotones();

                                //STORE PROCEDURE QUE GENERA NUEVO NUMERO  DE FACTURA
                                generoNroFactura();

                            }


                        }
                        else
                        {
                            if (_vf.txtNroRemito.Text != "")
                            {
                                Nro_Remito = InsertoEncabezadoRemito();

                                msg.lblMsg.Text = "FACTURA Y REMITO CARGADOS CON EXITO!";

                                msg.ShowDialog();

                                generoFactura(producto.Nro_Factura, _vf.txtNeto.Text, _vf.txtIVA.Text, _vf.txtNetoImp.Text);

                                generoRemito(Nro_Remito);


                                //VACIO DATOS FORM VISTA-FACTURA
                                vaciarDatosYdesahilitarBotones();

                                //STORE PROCEDURE QUE GENERA NUEVO NUMERO  DE FACTURA
                                generoNroFactura();
                            }
                            else
                            {

                                msg.lblMsg.Text = "FACTURA CARGADA CON EXITO!";

                                msg.ShowDialog();

                                generoFactura(producto.Nro_Factura, _vf.txtNeto.Text, _vf.txtIVA.Text, _vf.txtNetoImp.Text);

                                //VACIO DATOS FORM VISTA-FACTURA
                                vaciarDatosYdesahilitarBotones();

                                //STORE PROCEDURE QUE GENERA NUEVO NUMERO  DE FACTURA
                                generoNroFactura();
                            }
                        }

                    }



                    //LA FUNCION DEVUELVE VERDADERO EN CASO DE QUE LAS TRANSACCIONES SALIERON CORRECTAMENTE
                    return true;
                }
                else
                {
                    MessageBox.Show("DEBE HABER AL MENOS UN PRODUCTO INGRESADO PARA PODER FACTURAR!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }



            }
            else
            {
                MessageBox.Show("DEBE CARGAR UN CLIENTE PARA PODER FACTURAR!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public void insertoFacturaIngresoCaja()
        {

            Caja caja = new Caja();

            caja.Nro_Planilla = _cajaDao.obtengoNroPlanilla();

            caja.Tipo = "INGRESO";

            caja.Descripcion = _vf.txtDNICliente.Text +" "+ _vf.txtNombreCliente.Text;

            caja.Detalle = "FACTURA N° " + _vf.txtNroFactura.Text + " FP: " + _vf.cmbFormaDePago.Text;

            caja.Valor = Convert.ToDecimal(_vf.txtTotal.Text);

            caja.Fecha = _vf.dtpFacturaFecha.Text;


            _cajaDao.InsertMovimientoCaja(caja);

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public void insertoFacturaCCIngresoCaja()
        {

                Caja caja = new Caja();


                caja.Nro_Planilla = _cajaDao.obtengoNroPlanilla();

                caja.Tipo = "INGRESO";

                caja.Descripcion = _vf.txtDNICliente.Text + " " + _vf.txtNombreCliente.Text;

                caja.Detalle = "CUOTA N° " + _vf.dgvFacturaCuotas.CurrentRow.Cells[1].Value.ToString() + " FACTURA N° " + _vf.txtNroFactura.Text;

                caja.Valor = Convert.ToDecimal(_vf.dgvFacturaCuotas.CurrentRow.Cells[2].Value);

                caja.Fecha = _vf.dtpFacturaFecha.Text;

                _cajaDao.InsertMovimientoCaja(caja);
  
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public int InsertoEncabezadoRemito()
        {
            var R = new RemitoModel();

            foreach (DataGridViewRow filaProd in _vf.dgvFactura.Rows)
            {

                R.ID_Producto = Convert.ToInt32(filaProd.Cells[0].Value);
                R.Cantidad = Convert.ToInt32(filaProd.Cells[3].Value);

                R.Nro_Remito = Convert.ToInt16(_vf.txtNroRemito.Text);
                R.Nro_Factura = Convert.ToInt16(_vf.txtNroFactura.Text);
                R.Fecha_Emision = Convert.ToDateTime(_vf.dtpFacturaFecha.Text);

                _fac_dao.InsertEncabezadoRemito(R);

            }
            return R.Nro_Remito;


        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------

        //FUNCION QUE OBTIENE UN NUEVO NUMERO DE FACTURA
        public void generoNroFactura()
        {
            _vf.txtNroFactura.Text = _fac_dao.obtengoNroFactura().ToString();
        }

        //FUNCION QUE OBTIENE UN NUEVO NUMERO DE REMITO
        public void generoNroRemito()
        {
            _vf.txtNroRemito.Text = _fac_dao.obtengoNroRemito().ToString();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        private void vaciarDatosYdesahilitarBotonesCC()
        {
            _vf.txtIDCliente.Text = "";
            _vf.txtNetoImp.Text = "0.00";
            _vf.txtDNICliente.Text = "";
            _vf.txtDomicilio.Text = "";
            _vf.txtNroDomicilio.Text = "";
            _vf.txtTotalFormaDpago.Text = "";
            _vf.txtNombreCliente.Text = "";
            _vf.txtSitIVA.Text = "";
            _vf.txtCuit.Text = "";
            _vf.txtTotal.Text = "0.00";
            _vf.txtNeto.Text = "0.00";
            _vf.txtNetoImp.Visible = false;
            _vf.txtNetoImp.Visible = false;
            _vf.panelDatosCliente.Enabled = false;
            _vf.panelTF.Enabled = false;
            _vf.panelFacturaCuotas.Visible = false;
            _vf.panelFC.Visible = false;


            _vf.dgvFactura.Rows.Clear();
            _vf.dgvFacturaCuotas.Rows.Clear();

            _vf.btnEliminoProd.Enabled = false;
        }

        //FUNCION QUE VACIA Y DESHABILITA LOS COMPONENTES DEL FORM FACTURA
        private void vaciarDatosYdesahilitarBotones()
        {
            _vf.txtNroFactura.Text = "";
            _vf.txtIDCliente.Text = "";
            _vf.txtNetoImp.Text = "0.00";
            _vf.txtDNICliente.Text = "";
            _vf.txtDomicilio.Text = "";
            _vf.txtNroDomicilio.Text = "";
            _vf.txtTotalFormaDpago.Text = "";
            _vf.txtNombreCliente.Text = "";
            if (_vf.cmbFormaDePago.SelectedIndex == 0)
            {
                _vf.panelTC.Visible = true;
                _vf.panelEfectivo.Visible = false;
            }
            if (_vf.cmbFormaDePago.SelectedIndex == 1)
            {
                _vf.panelTC.Visible = true;
                _vf.panelEfectivo.Visible = false;
                _vf.panelTarjetaC.Visible = false;
            }
            if (_vf.cmbFormaDePago.SelectedIndex == 2)
            {
                _vf.panelTC.Visible = true;
                _vf.panelEfectivo.Visible = false;
                _vf.panelFC.Visible = false;
                _vf.panelFacturaCuotas.Visible = false;
            }
            _vf.cmbBoxTipoCliente.DataSource = null;
            _vf.cmbFormaDePago.DataSource = null;

            _vf.txtSitIVA.Text = "";
            _vf.txtCuit.Text = "";
            _vf.txtTotal.Text = "0.00";
            _vf.txtNeto.Text = "0.00";
            _vf.txtNetoImp.Visible = false;
            _vf.txtNetoImp.Visible = false;
            _vf.panelDatosCliente.Enabled = false;
            _vf.panelTF.Enabled = false;

            _vf.dgvFactura.Rows.Clear();


            _vf.btnEliminoProd.Enabled = false;
        }

        //FUNCION QUE VACIA LOS COMPONENTES DEL FORM FACTURA
        public void vaciarDatos()
        {

            _vf.txtIDCliente.Text = "";
            _vf.txtNetoImp.Text = "";
            _vf.txtDNICliente.Text = "";
            _vf.txtDomicilio.Text = "";
            _vf.txtNroDomicilio.Text = "";
            _vf.txtTotalFormaDpago.Text = "";
            _vf.txtNombreCliente.Text = "";
            _vf.txtSitIVA.Text = "";
            _vf.txtCuit.Text = "";
            _vf.txtNeto.Text = "";
            _vf.txtNetoImp.Text = "";
            _vf.txtIVA.Text = "";



        }

        //-----------------------------------------------------------------------------------------------------------------------------------------

        //FUNCION QUE CALCULA LAS CUOTAS EN CASO DE SELECCIONAR FORMA DE PAGO TARJETA DE CREDITO
        public void pagoTarjetaCalculoCuotas(VistaFacturas _vf)
        {
            decimal cuotaIndividual;

            //EN CASO DE SELECCIONAR 3 CUOTAS
            if (_ft.cmbBoxCantCuotas.SelectedIndex == 0)
            {

                //HABILITO BOTON DE CONFIRMAR FACTURA CLIENTES EVENTUALES


                _vf.btnConfirmarFacturaRegis.Visible = true;
                _vf.btnConfirmarFacturaRegis.Enabled = true;


                _vf.formaDePago.Enabled = true;

                _vf.txtImporteAbonado.Enabled = false;

                _vf.txtNombreC.Text = "";
                _vf.txtBanco.Text = "";
                _vf.txtEmpresaTarjeta.Text = "";

                _vf.txtImporte1.Enabled = false;
                _vf.txtImporte2.Enabled = false;
                _vf.txtImporte3.Enabled = false;
                _vf.txtImporte4.Enabled = false;
                _vf.txtImporte5.Enabled = false;
                _vf.txtImporte6.Enabled = false;
                _vf.txtFechaC1.Enabled = false;
                _vf.txtFechaC2.Enabled = false;
                _vf.txtFechaC3.Enabled = false;
                _vf.txtFechaC4.Enabled = false;
                _vf.txtFechaC5.Enabled = false;
                _vf.txtFechaC6.Enabled = false;

                _vf.txtRecargo.Text = "2.35%";

                //CUOTA 1
                _vf.txtImporte1.Text = Math.Round(calculoImporteXCuota(_vf), 2).ToString();

                //CUOTA 2  
                _vf.txtImporte2.Text = Math.Round(calculoImporteXCuota(_vf), 2).ToString();

                //CUOTA 3
                _vf.txtImporte3.Text = Math.Round(calculoImporteXCuota(_vf), 2).ToString();

                _vf.txtImporte4.Text = "";
                _vf.txtImporte5.Text = "";
                _vf.txtImporte6.Text = "";


                _vf.dtpFacturaFecha.Text = DateTime.Today.ToString();

                DateTime fecha1 = Convert.ToDateTime(_vf.dtpFacturaFecha.Text).AddMonths(1);
                DateTime fecha2 = Convert.ToDateTime(fecha1).AddMonths(1);
                DateTime fecha3 = Convert.ToDateTime(fecha2).AddMonths(1);

                _vf.txtFechaC1.Text = fecha1.ToShortDateString();
                _vf.txtFechaC2.Text = fecha2.ToShortDateString();
                _vf.txtFechaC3.Text = fecha3.ToShortDateString();
                _vf.txtFechaC4.Text = "";
                _vf.txtFechaC5.Text = "";
                _vf.txtFechaC6.Text = "";


                _vf.txtObservaciones.Text = " El Cliente abono el/los productos con tarjeta de credito, en 3 cuotas con un recargo del 2.5%." +
                                            " Cada cuota tiene un valor de $ " + _vf.txtImporte1.Text;


                _vf.txtObservaciones.Enabled = false;


                cuotaIndividual = Math.Round(Convert.ToDecimal(_vf.txtImporte1.Text) * 3, 2);

                _vf.txtTotal.Text = cuotaIndividual.ToString();
                _vf.txtTotalFormaDpago.Text = cuotaIndividual.ToString();

                _ft.Close();
            }

            //EN CASO DE SELECCIONAR 6 CUOTAS
            else
            {

                _vf.formaDePago.Enabled = true;

                _vf.txtImporteAbonado.Enabled = false;


                _vf.txtNombreC.Text = "";
                _vf.txtBanco.Text = "";
                _vf.txtEmpresaTarjeta.Text = "";

                _vf.txtImporte1.Enabled = false;
                _vf.txtImporte2.Enabled = false;
                _vf.txtImporte3.Enabled = false;
                _vf.txtImporte4.Enabled = false;
                _vf.txtImporte5.Enabled = false;
                _vf.txtImporte6.Enabled = false;

                _vf.txtFechaC1.Enabled = false;
                _vf.txtFechaC2.Enabled = false;
                _vf.txtFechaC3.Enabled = false;
                _vf.txtFechaC4.Enabled = false;
                _vf.txtFechaC5.Enabled = false;
                _vf.txtFechaC6.Enabled = false;

                _vf.txtRecargo.Text = "5%";

                //CUOTA 1  
                _vf.txtImporte1.Text = Math.Round(calculoImporteXCuota(_vf), 2).ToString();
                //CUOTA 2  
                _vf.txtImporte2.Text = Math.Round(calculoImporteXCuota(_vf), 2).ToString();
                //CUOTA 3  
                _vf.txtImporte3.Text = Math.Round(calculoImporteXCuota(_vf), 2).ToString();
                //CUOTA 4  
                _vf.txtImporte4.Text = Math.Round(calculoImporteXCuota(_vf), 2).ToString();
                //CUOTA 5  
                _vf.txtImporte5.Text = Math.Round(calculoImporteXCuota(_vf), 2).ToString();
                //CUOTA 6
                _vf.txtImporte6.Text = Math.Round(calculoImporteXCuota(_vf), 2).ToString();


                _vf.dtpFacturaFecha.Text = DateTime.Today.AddMonths(1).ToString();

                DateTime fecha1 = Convert.ToDateTime(_vf.dtpFacturaFecha.Text).AddMonths(1);
                DateTime fecha2 = Convert.ToDateTime(fecha1).AddMonths(1);
                DateTime fecha3 = Convert.ToDateTime(fecha2).AddMonths(1);
                DateTime fecha4 = Convert.ToDateTime(fecha3).AddMonths(1);
                DateTime fecha5 = Convert.ToDateTime(fecha4).AddMonths(1);
                DateTime fecha6 = Convert.ToDateTime(fecha5).AddMonths(1);

                _vf.txtFechaC1.Text = fecha1.ToShortDateString();
                _vf.txtFechaC2.Text = fecha2.ToShortDateString();
                _vf.txtFechaC3.Text = fecha3.ToShortDateString();
                _vf.txtFechaC4.Text = fecha4.ToShortDateString();
                _vf.txtFechaC5.Text = fecha5.ToShortDateString();
                _vf.txtFechaC6.Text = fecha6.ToShortDateString();


                _vf.txtObservaciones.Text = (" El Cliente abono el/los productos con tarjeta de credito, en 6 cuotas con un recargo del 5%." +
                                             " Cada cuota tiene un valor de $ " + _vf.txtImporte1.Text);

                _vf.txtObservaciones.Enabled = false;

                cuotaIndividual = Math.Round(Convert.ToDecimal(_vf.txtImporte1.Text) * 6, 2);

                _vf.txtTotal.Text = cuotaIndividual.ToString();
                _vf.txtTotalFormaDpago.Text = cuotaIndividual.ToString();

                _ft.Close();
            }

        }

        public void agregoDatosTarjeta(VistaFacturas _vf)
        {
            if (_vf.txtNombreC.Text != "" && _vf.txtBanco.Text != "" && _vf.txtEmpresaTarjeta.Text != "") {

                if (_vf.txtImporte4.Text == "" && _vf.txtImporte5.Text == "" && _vf.txtImporte6.Text == "")
                {
                    _vf.txtObservaciones.Text = (" El Cliente abono el/los productos con tarjeta de credito, en 3 cuotas con un recargo del 2.5%." +
                            " Cada cuota tiene un valor de $ " + _vf.txtImporte1.Text) +
                            "\n" + "\n" + " Titular Tarjeta: "+_vf.txtNombreC.Text.ToUpper() + "\n" + " Empresa tarjeta: " + _vf.txtEmpresaTarjeta.Text.ToUpper() + "\n" + " Banco: " + _vf.txtBanco.Text.ToUpper();
                }
                else
                {
                    _vf.txtObservaciones.Text = (" El Cliente abono el/los productos con tarjeta de credito, en 6 cuotas con un recargo del 5%." +
                           " Cada cuota tiene un valor de $ " + _vf.txtImporte1.Text) +
                           "\n" + "\n" + " Titular Tarjeta: " + _vf.txtNombreC.Text.ToUpper() + "\n" + " Empresa tarjeta: " + _vf.txtEmpresaTarjeta.Text.ToUpper() + "\n" + " Banco: " + _vf.txtBanco.Text.ToUpper();
                }

            }


        }

        public void VaciarDatosCuotasYDeshabilitarPanel()
        {
            _vf.txtImporte1.Text = "";
            _vf.txtImporte2.Text = "";
            _vf.txtImporte3.Text = "";
            _vf.txtImporte4.Text = "";
            _vf.txtImporte5.Text = "";
            _vf.txtImporte6.Text = "";

            _vf.txtFechaC1.Text = "";
            _vf.txtFechaC2.Text = "";
            _vf.txtFechaC3.Text = "";
            _vf.txtFechaC4.Text = "";
            _vf.txtFechaC5.Text = "";
            _vf.txtFechaC6.Text = "";



            _vf.txtRecargo.Text = "";

        }

        public decimal calculoImporteXCuota(VistaFacturas _vf)
        {
            decimal recargoCuota;
            decimal importe = Convert.ToDecimal(_vf.txtEfectivo.Text);

            if (_ft.cmbBoxCantCuotas.SelectedIndex == 0)
            {
                decimal ImportePorcuota = importe / 3;

                recargoCuota = (ImportePorcuota * 0.0235M) + ImportePorcuota;

                return recargoCuota;

            }
            else
            {
                decimal ImportePorcuota = importe / 6;

                recargoCuota = (ImportePorcuota * 0.05M) + ImportePorcuota;

                return recargoCuota;
            }



        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------

        public void muestroTipoDeFactura()
        {

            // CLIENTE EVENTUAL

            if (_vf.cmbBoxTipoCliente.SelectedIndex == 1)
            {
                var result = System.Windows.Forms.MessageBox.Show("DESEA DAR DE ALTA UN CLIENTE? , DE LO CONTRARIO CARGUE UNO YA REGISTRADO EN EL SISTEMA", "DAR DE ALTA CLIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    AltaClientes ac = new AltaClientes();

                    ac.btnAltaClienteFactura.Visible= true;
                    ac.btnAltaCliente.Visible = false;
                    ac.btnSalirACFac.Visible = true;
                    ac.btnVolver.Visible = false;

                    _vf.cmbBoxTipoCliente.DataSource = null;

                    ac.ShowDialog();

                }
                else
                {

                    _vf.cmbBoxTipoCliente.SelectedIndex = 0;

                    _vf.txtIDCliente.Enabled = false;
                    _vf.btnAgregarProducto.Enabled = true;
                    _vf.txtSitIVA.Enabled = true;

                    _vf.dgvFactura.Rows.Clear();


                    _vf.txtCantProd.Text = _vf.dgvFactura.RowCount.ToString();

                    _vf.label39.Visible = true;
                    _vf.label41.Visible = true;

                    _vf.btnClientes.Enabled = true;

                    _vf.txtNroDomicilio.Enabled = true;
                    _vf.panelDatosCliente.Enabled = true;
                    _vf.panelBotones.Enabled = true;

                    _vf.cmbFormaDePago.DataSource = null;

                    _vf.txtNombreCliente.Enabled = false;
                    _vf.txtDNICliente.Enabled = false;
                    _vf.txtDomicilio.Enabled = false;
                    _vf.txtCuit.Enabled = false;
                    _vf.panelTF.Enabled = true;
                    _vf.txtNroDomicilio.Enabled = false;

                    _vf.panelTF.Enabled = true;

                    vaciarDatos();
                }

            }

            // CLIENTE REGISTRADO

            if (_vf.cmbBoxTipoCliente.SelectedIndex == 0)
            {

                _vf.dgvFactura.Rows.Clear();

                _vf.txtCantProd.Text = _vf.dgvFactura.RowCount.ToString();

                _vf.label39.Visible = true;
                _vf.label41.Visible = true;

                _vf.btnClientes.Enabled = true;

                _vf.txtNroDomicilio.Enabled = true;
                _vf.panelDatosCliente.Enabled = true;
                _vf.panelBotones.Enabled = true;

                _vf.cmbFormaDePago.DataSource = null;

                _vf.txtNombreCliente.Enabled = false;
                _vf.txtDNICliente.Enabled = false;
                _vf.txtDomicilio.Enabled = false;
                _vf.txtCuit.Enabled = false;
                _vf.panelTF.Enabled = true;
                _vf.txtNroDomicilio.Enabled = false;

                vaciarDatos();
            }

        }

        public void seleccionFormaDePago()
        {
            _vf.txtObservaciones.Text = "";

            if (_vf.cmbFormaDePago.SelectedIndex == 0)
            {

                _vf.btnConfirmarFacturaRegis.Visible = true;
                _vf.btnConfirmarFacturaRegis.Enabled = true;

                _vf.dgvFacturaCuotas.Rows.Clear();

                _vf.panelEfectivo.Visible = true;

                _vf.txtObservaciones.Enabled = true;

                _vf.panelTC.Visible = false;

                _vf.panelTarjetaC.Visible = false;

                _vf.panelFC.Visible = false;

                _vf.txtImporteAbonado.Enabled = true;

                _vf.panelFacturaCuotas.Visible = false;

                _vf.txtSaldo.Text = "0.00";

                _vf.txtAnticipo.Text = "0.00";

                _vf.txtSaldoAnticipo.Text = "0.00";

                _vf.txtSaldo.Text = "0.00";

                _vf.txtAnticipo.Text = "0.00";

                _vf.txtSaldoAnticipo.Text = "0.00";

                _vf.lblNetoIMP.Visible = false;

                _vf.txtNetoImp.Visible = false;

                _pf_ctr.sacoTotal(_vf);

                VaciarDatosCuotasYDeshabilitarPanel();
            }

            if (_vf.cmbFormaDePago.SelectedIndex == 1)
            {

                _vf.btnConfirmarFacturaRegis.Visible = true;

                _vf.btnConfirmarFacturaRegis.Enabled = true;

                _vf.dgvFacturaCuotas.Rows.Clear();

                _vf.panel11.Visible = true;

                _vf.panelTC.Visible = true;

                _vf.panelTarjetaC.Visible = true;

                _vf.panelEfectivo.Visible = false;

                _vf.panelFC.Visible = false;

                _vf.panelFacturaCuotas.Visible = false;

                _vf.txtSaldo.Text = "0.00";

                _vf.txtAnticipo.Text = "0.00";

                _vf.txtSaldoAnticipo.Text = "0.00";

                _vf.lblNetoIMP.Visible = true;

                _vf.txtNetoImp.Visible = true;

                _pf_ctr.sacoTotal(_vf);

                facturaFPTarjetaView ft = new facturaFPTarjetaView(_vf);
                ft.ShowDialog();
            }

            if (_vf.cmbFormaDePago.SelectedIndex == 2)
            {


                _vf.dgvFacturaCuotas.Rows.Clear();

                _vf.panelFC.Visible = true;

                _vf.panelFacturaCuotas.Visible = true;

                _vf.panelTC.Visible = false;

                _vf.panelTarjetaC.Visible = false;

                _vf.formaDePago.Visible = true;

                _vf.panelEfectivo.Visible = false;

                _vf.lblNetoIMP.Visible = true;

                _vf.txtNetoImp.Visible = true;

                _vf.lblTotalEF.Visible = true;

                facturaCCFPView FCC = new facturaCCFPView(_vf);

                FCC.ShowDialog();

            }
        }

        public void ventanaPregunta()
        {
            var result = System.Windows.Forms.MessageBox.Show("DESEA SEGUIR FACTURANDO?", "FACTURAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result != DialogResult.OK)
            {
                Form.ActiveForm.Hide();
                generoNroFactura();
            }
            else
            {

                _vf.tabControl.SelectedTab = _vf.encabezadoFactura;
            }
        }
        public void controloFormaDePagoFacturaRegis()
        {
            if ((_vf.txtNroFactura.Text != "") & (_vf.txtIDCliente.Text != "") & (_vf.txtDomicilio.Text != "") & (_vf.txtNombreCliente.Text != "") & (_vf.txtVendedor.Text != ""))
            {
                if (_vf.txtSitIVA.Text != "")
                {


                    if (Convert.ToInt32(_vf.txtCantProd.Text) > 0)
                    {
                        if (_vf.cmbFormaDePago.SelectedIndex >= 0)
                        {

                            insertEncabezadoFactura();

                            _vf.txtNroRemito.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("DEBE SELECCIONAR UNA FORMA DE PAGO PARA EMITIR SU FACTURA", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("DEBE HABER AL MENOS UN PRODUCTO INGRESADO PARA PODER FACTURAR!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UNA SITUACION IVA DEL CLIENTE PARA FACTURAR!", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("DEBE CARGAR UN CLIENTE PARA PODER FACTURAR!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void muestroFormasDePagoCliente()
        {
            if (_vf.cmbBoxTipoCliente.SelectedIndex == 0)
            {
                _vf.cmbFormaDePago.DataSource = c.FormaDePagoClientesRegistrados();
            }
            else
            {
                _vf.cmbFormaDePago.DataSource = c.FormaDePagoClientesEventuales();

            }
        }

        public void chequeoDNIFacEvent(string txt)
        {

            if (_fac_dao.selectCondicion("Clientes", "Nro_Dni = " + txt) == true)

            {
                MessageBox.Show("EL DNI QUE DESEA INGRESAR FORMA PARTE DE UN CLIENTE REGISTRADO!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }
        public void accionesFacturasLoad()
        {
            _vf.panelDatosCliente.Enabled = false;
            _vf.formaDePago.Visible = true;
            _vf.panelTarjetaC.Visible = false;
            _vf.panelFacturaCuotas.Visible = false;
            _vf.panelTF.Enabled = false;
            _vf.txtSitIVA.Enabled = false;
            _vf.label3.Visible = true;
            _vf.cmbFormaDePago.DataSource = null;
            _vf.dtpFacturaFecha.Text = DateTime.Today.ToShortDateString();
            _vf.dtpFacturaFecha.MinDate = DateTime.Today;

        }
        public void habilitoEventos()
        {
            Utilities.Constants c = new Utilities.Constants();


            //SELECCION CLIENTE REGISTRADO.
            if (_vf.cmbBoxTipoCliente.SelectedIndex == 0)
            {
                //OPCION RESPONSABLE INSCRIPTO
                if (_vf.txtSitIVA.Text == "RESPONSABLE INSCRIPTO")
                {
                    _vf.dgvFactura.Rows.Clear();

                    _vf.txtTotal.Text = "0.00";
                    _vf.txtTotalFormaDpago.Text = "0.00";
                    _vf.txtNeto.Text = "0.00";
                    _vf.txtIVA.Text = "0 %";
                    _vf.txtNetoImp.Text = "0.00";

                    _vf.txtCuit.Text = _vf.txtDNICliente.Text;

                    _vf.txtDNICliente.Visible = true;
                    _vf.txtDNICliente.Enabled = false;

                    _vf.txtCuit.Visible = true;
                    _vf.txtCuit.Enabled = true;
                    _vf.txtCuit.Text = _vf.txtDNICliente.Text;


                    _vf.cmbBoxLetraF.Text = "A";

                }
                else
                {

                    //OPCION CONSUMIDOR FINAL.

                    _vf.dgvFactura.Rows.Clear();

                    _vf.txtTotal.Text = "0.00";
                    _vf.txtTotalFormaDpago.Text = "0.00";
                    _vf.txtNeto.Text = "0.00";
                    _vf.txtIVA.Text = "21 %";
                    _vf.txtNetoImp.Text = "0.00";

                    _vf.txtDNICliente.Visible = true;
                    _vf.txtDNICliente.Visible = true;

                    _vf.txtCuit.Enabled = false;
                    _vf.txtCuit.Text = "";
                    _vf.txtCuit.Visible = true;


                    _vf.cmbBoxLetraF.Text = "B";

                }
            }
            //SELECCION CLIENTE EVENTUAL.
            if (_vf.cmbBoxTipoCliente.SelectedIndex == 1)
            {

                //OPCION RESPONSABLE INSCRIPTO
                if (_vf.txtSitIVA.Text == "RESPONSABLE INSCRIPTO")
                {
                    _vf.dgvFactura.Rows.Clear();

                    _vf.txtNeto.Text = "0.00";
                    _vf.txtIVA.Text = "0 %";
                    _vf.txtNetoImp.Text = "0.00";

                    _vf.txtDNICliente.Enabled = true;
                    _vf.txtCuit.Enabled = true;
                    _vf.txtCuit.Text = _vf.txtDNICliente.Text;


                    _vf.cmbBoxLetraF.Text = "A";
                    _vf.cmbBoxLetraF.Enabled = false;
                }
                else
                {
                    //OPCION CONSUMIDOR FINAL.

                    _vf.dgvFactura.Rows.Clear();

                    _vf.txtNeto.Text = "0.00";
                    _vf.txtIVA.Text = "21 %";
                    _vf.txtNetoImp.Text = "0.00";

                    _vf.txtDNICliente.Enabled = true;
                    _vf.txtCuit.Enabled = false;

                    _vf.txtCuit.Text = "";
                    _vf.txtCuit.Visible = true;

                    _vf.cmbBoxLetraF.Text = "B";
                    _vf.cmbBoxLetraF.Enabled = false;

                }
            }

        }

        public void controlDatosClienteFactura()
        {
            cargoProductosFactura CPF = new cargoProductosFactura(_vf);



                //-----------------------OPCIONES EN CASO DE SELECCIONAR CLIENTE REGISTRADO-----------------------//

                if (_vf.cmbBoxTipoCliente.SelectedIndex == 0)
                {

                    if (_vf.txtSitIVA.Text == "RESPONSABLE INSCRIPTO")
                    {
                        if ((_vf.txtNombreCliente.Text != "") & (_vf.txtDNICliente.Text != "") & (_vf.cmbBoxLetraF.DataSource != null) & (_vf.txtCuit.Text != "") &  (_vf.txtDomicilio.Text != "") & (_vf.txtNroDomicilio.Text != ""))
                        {
                            _vf.btnAgregarProducto.Enabled = true;
                            CPF.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("DEBE COMPLETAR TODOS LOS DATOS SOLICITADOS DEL CLIENTE!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    if (_vf.txtSitIVA.Text == "CONSUMIDOR FINAL")
                    {
                        if ((_vf.txtNombreCliente.Text != "") & (_vf.txtDNICliente.Text != "") & (_vf.cmbBoxLetraF.DataSource != null) & (_vf.txtDomicilio.Text != "") & (_vf.txtNroDomicilio.Text != ""))
                        {
                            if (_vf.txtDNICliente.TextLength == 8)
                            {
                                _vf.btnAgregarProducto.Enabled = true;
                                CPF.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("EL DNI DEBE CONTENER 8 DIGITOS!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("DEBE COMPLETAR TODOS LOS DATOS SOLICITADOS DEL CLIENTE!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                }
                else
                {

                    if (_vf.txtSitIVA.Text == "RESPONSABLE INSCRIPTO")
                    {
                        _vf.btnAgregarProducto.Enabled = true;

                        if ((_vf.txtNombreCliente.Text != "") & (_vf.txtDNICliente.Text != "") & (_vf.cmbBoxLetraF.DataSource != null) & (_vf.txtCuit.Text != "")  & (_vf.txtDomicilio.Text != "") & (_vf.txtNroDomicilio.Text != ""))
                        {
                            _vf.btnAgregarProducto.Enabled = true;
                            CPF.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("DEBE COMPLETAR TODOS LOS DATOS SOLICITADOS DEL CLIENTE!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    if (_vf.txtSitIVA.Text == "CONSUMIDOR FINAL")
                    {
                        if ((_vf.txtNombreCliente.Text != "") & (_vf.txtDNICliente.Text != "") & (_vf.cmbBoxLetraF.DataSource != null) & (_vf.txtDomicilio.Text != "") & (_vf.txtNroDomicilio.Text != ""))
                        {
                            if (_vf.txtDNICliente.TextLength == 8)
                            {
                                _vf.btnAgregarProducto.Enabled = true;
                                CPF.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("EL DNI DEBE CONTENER 8 DIGITOS!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("DEBE COMPLETAR TODOS LOS DATOS SOLICITADOS DEL CLIENTE!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
        }
//------------------------------------------------------------------------------------------------------------------------------------------------
        public string obtengoCuitString(string a)
        {

            string guardo = string.Empty;


            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsNumber(a[i]) & (i > 2) & (i < 11))
                {
                    guardo += a[i];
                }
            }

            if (guardo.Length > 0) a = guardo;
            return a;
        }
        public string obtengoPrefijoCuitString(string a)
        {

            string guardo = string.Empty;


            for (int i = 0; i < a.Length; i++)
            {
                if (i < 2)
                {
                    if (Char.IsNumber(a[i]))
                    {
                        guardo += a[i];
                    }
                }
            }

            if (guardo.Length > 0) a = guardo;
            return a;
        }
        public string obtengoDigitoCuitString(string a)
        {

            string guardo = string.Empty;


            for (int i = 0; i < a.Length; i++)
            {
                if (i > 11)
                {
                    if (Char.IsNumber(a[i]))
                    {
                        guardo += a[i];
                    }
                }
            }

            if (guardo.Length > 0) a = guardo;
            return a;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        public void deshabilitoComponentes()
        {
            if (_vf.dgvFactura.RowCount > 0)
            {
                _vf.btnSeleccionFP.Visible = true;
            }
            else
            {
                _vf.btnSeleccionFP.Visible = false;
            }
            _vf.dgvFacturaCuotas.Rows.Clear();
            _vf.panelEfectivo.Visible = false;
            _vf.panelFacturaCuotas.Visible = false;
            _vf.panelFC.Visible = false;
            _vf.panelTC.Visible = false;
            _vf.panelTarjetaC.Visible = false;

            _vf.cmbFormaDePago.DataSource = null;
            vacioCuotas();

        }

        public void vacioCuotas()
        {
            _vf.txtImporte1.Text = "";
            _vf.txtImporte2.Text = "";
            _vf.txtImporte3.Text = "";
            _vf.txtImporte4.Text = "";
            _vf.txtImporte5.Text = "";
            _vf.txtImporte6.Text = "";

            _vf.txtFechaC1.Text = "";
            _vf.txtFechaC2.Text = "";
            _vf.txtFechaC3.Text = "";
            _vf.txtFechaC4.Text = "";
            _vf.txtFechaC5.Text = "";
            _vf.txtFechaC6.Text = "";
        }
        public void controloFacturaYhabilito2doTab(VistaFacturas _vf)
        {
            if (_vf.dgvFactura.Rows.Count <= 0)
            {
                ((Control)_vf.formaDePago).Enabled = false;
                ((Control)_vf.Observaciones).Enabled = false;
                _vf.btnGeneroRemito.Enabled = false;

                if (_vf.cmbFormaDePago.SelectedIndex == 0)
                {
                    _vf.panelEfectivo.Visible = false;
                }


                if (_vf.cmbFormaDePago.SelectedIndex == 1)
                {
                    _vf.panelTC.Visible = false;
                    _vf.panelTarjetaC.Visible = false;
                }

                if (_vf.cmbFormaDePago.SelectedIndex == 2)
                {
                    _vf.panelFacturaCuotas.Visible = false;
                }


            }
            else
            {
                ((Control)_vf.formaDePago).Enabled = true;
                ((Control)_vf.Observaciones).Enabled = true;
                _vf.btnGeneroRemito.Enabled = true;
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
                if ((sender as System.Windows.Forms.TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }

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
                System.Windows.Forms.MessageBox.Show("SOLO SE PUEDEN INGRESAR NUMEROS.");
            }
        }


    }
}
