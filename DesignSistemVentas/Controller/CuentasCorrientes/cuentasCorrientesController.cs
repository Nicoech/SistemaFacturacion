using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DesignSistemVentas.Model;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.Utilities;
using DesignSistemVentas.View;
using DesignSistemVentas.View.CuentasCorrientesView;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller
{

    class cuentasCorrientesController
    {
        private cuentaCorrienteAbonarCuotaView _ccacv;
        private cuentasCorrientesView _ccv;
        private morososView _mv;

        private cargoClienteCtaCte _cargoC;
        private Constants c = new Constants();

        private ctaCteDao _ccDao = new ctaCteDao();

        public string PATHReport { get; private set; }

        public cuentasCorrientesController(cuentaCorrienteAbonarCuotaView ccacv)
        {
            _ccacv = ccacv;

        }
        public cuentasCorrientesController(cuentasCorrientesView ccv)
        {
            _ccv = ccv;

        }

        public cuentasCorrientesController(cargoClienteCtaCte cargoC)
        {
            _cargoC = cargoC;
        }

        public cuentasCorrientesController(morososView mv)
        {
            _mv = mv;
        }
        public bool traigoCliente()
        {
            if (_ccDao.searchClientesCtaCte(_cargoC.dgvClientesCtaCte) == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show("NO SE ENCONTRARON CLIENTES QUE ADEUDEN FACTURAS!");
                Form.ActiveForm.Close();
                return false;
            }

        }

        public void generoReciboCTACTE(int NroFac, string saldoAnt, string saldoAct, string nroCuota)
        {

            _ccacv.txtNroFac.Text = NroFac.ToString();
            var result = System.Windows.Forms.MessageBox.Show("DESEA IMPRIMIR RECIBO DE PAGO?", "IMPRESION RECIBO CTA.CTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                reciboCTACTEReporteForm rccf = new reciboCTACTEReporteForm();
                ReportDocument oRep = new ReportDocument();
                ParameterField pf = new ParameterField();
                ParameterFields pfs = new ParameterFields();
                ParameterDiscreteValue pdv = new ParameterDiscreteValue();

                pf.Name = "@Nro_Fac";
                pdv.Value = NroFac;
                pf.CurrentValues.Add(pdv);
                pfs.Add(pf);

                rccf.reporte.ParameterFieldInfo = pfs;

                PATHReport = Environment.CurrentDirectory + @"\reciboCTACTE.rpt";

                oRep.Load(PATHReport);


                TextObject saldoAnterior;
                TextObject saldoActual;
                TextObject nroC;

                if (oRep.ReportDefinition.ReportObjects["saldoAnt"] != null)
                {
                    saldoAnterior = (TextObject)oRep.ReportDefinition.ReportObjects["saldoAnt"];
                    saldoAnterior.Text = saldoAnt;
                }

                if (oRep.ReportDefinition.ReportObjects["saldoAct"] != null)
                {
                    saldoActual = (TextObject)oRep.ReportDefinition.ReportObjects["saldoAct"];
                    saldoActual.Text = saldoAct;
                }

                if (oRep.ReportDefinition.ReportObjects["nroCuota"] != null)
                {
                    nroC = (TextObject)oRep.ReportDefinition.ReportObjects["nroCuota"];
                    nroC.Text = nroCuota;
                }

                rccf.reporte.ReportSource = oRep;

                rccf.ShowDialog();
            }


        }
        public void traigoClienteByFiltro()
        {
            _ccDao.SearchClientsByIDorDNI(_cargoC.dgvClientesCtaCte, _cargoC.txtBusquedaClientes.Text);
        }

        public void traigoMorosos()
        {
            _ccDao.searchClientesMorosos(_mv.dgvMorosos);
        }

        public void bindDataCliente(cuentasCorrientesView _ccv)
        {
            _ccv.txtIDCliente.Text = _cargoC.dgvClientesCtaCte.CurrentRow.Cells[0].Value.ToString();
            _ccv.txtNombre.Text = _cargoC.dgvClientesCtaCte.CurrentRow.Cells[1].Value.ToString() + " " + _cargoC.dgvClientesCtaCte.CurrentRow.Cells[2].Value.ToString();

            _ccv.cmbBoxNroFac.Enabled = true;

            traigoFacturas(_ccv);

            if (_ccv.cmbBoxNroFac.DataSource == null)
            {
                MessageBox.Show("El Cliente no posee facturas adeudadas");
            }

        }



        public void bindDataPagoCuota()
        {
            decimal saldoFinal;
            cuentaCorrienteAbonarCuotaView ccacv = new cuentaCorrienteAbonarCuotaView(_ccv);

            ccacv.txtNroFac.Text = _ccv.dgvCtaCte.CurrentRow.Cells[0].Value.ToString();
            ccacv.txtNroCuota.Text = _ccv.dgvCtaCte.CurrentRow.Cells[1].Value.ToString();
            ccacv.txtFechaInicial.Text = _ccv.dgvCtaCte.CurrentRow.Cells[2].Value.ToString();
            ccacv.txtFechaVto.Text = _ccv.dgvCtaCte.CurrentRow.Cells[3].Value.ToString();
            ccacv.txtMonto.Text = _ccv.dgvCtaCte.CurrentRow.Cells[5].Value.ToString();
            ccacv.txtSaldoAct.Text = _ccv.txtSaldo.Text;

            saldoFinal = Convert.ToDecimal(ccacv.txtSaldoAct.Text) - Convert.ToDecimal(ccacv.txtMonto.Text);
            ccacv.txtSaldoFinal.Text = saldoFinal.ToString();

            ccacv.ShowDialog();

        }

        public void traigoFacturas(cuentasCorrientesView _ccv)
        {
            if (_ccv.txtIDCliente.Text != "")
            {
                _ccv.cmbBoxNroFac.ValueMember = "Nro_Factura";
                _ccv.cmbBoxNroFac.DataSource = _ccDao.searchFacturasByIDCliente(_ccv.txtIDCliente.Text);
            }

        }

        public void traigoSaldo()
        {
            _ccv.txtSaldo.Text = _ccDao.searchSaldoByFactura(_ccv.cmbBoxNroFac.SelectedValue.ToString(), _ccv.txtSaldo.Text);

        }

        public void traigoFacturaCuotas()
        {
            _ccDao.searchFacturaCuotas(_ccv.cmbBoxNroFac.SelectedValue.ToString(), _ccv.dgvCtaCte);
        }

        public void pintoFilaCuotAbonada(cuentasCorrientesView _ccv)
        {

            _ccv.dgvCtaCte.CurrentRow.DefaultCellStyle.BackColor = Color.Blue;
            _ccv.dgvCtaCte.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Blue;
            _ccv.dgvCtaCte.CurrentRow.Cells[4].Value = "Abonada";

            _ccv.txtSaldo.Text = _ccacv.txtSaldoFinal.Text;

            Form.ActiveForm.Close();

        }

        public void UpdateEstadoCuotas(cuentasCorrientesView _ccv)
        {
            var CC = new cuentaCorriente();


            CC.Nro_Factura = Convert.ToInt16(_ccv.dgvCtaCte.CurrentRow.Cells[0].Value);
            CC.Nro_Cuota = Convert.ToInt16(_ccacv.txtNroCuota.Text);
            CC.Saldo = Convert.ToDecimal(_ccv.txtSaldo.Text);
            CC.Estado = "Abonada";

            if (_ccDao.UpdateEstadoCuota(CC) == true)
            {
                _ccDao.UpdateSaldoCtaCte(CC);

                MsgBox msg = new MsgBox();

                msg.lblMsg.Text = "PAGO INGRESADO CORRECTAMENTE!";

                msg.ShowDialog();
            }
        }
    }
}
