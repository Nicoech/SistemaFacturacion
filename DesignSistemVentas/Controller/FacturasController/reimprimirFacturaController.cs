using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.ModelDao;
using DesignSistemVentas.View.FacturasViews;
using DesignSistemVentas.View.FacturasViews.ReimprimirFactura;
using DesignSistemVentas.View.RemitosViews;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.FacturasController
{

    class reimprimirFacturaController
    {
        private FacturasDao fac_Dao = new FacturasDao();
        private vistaReimprimoFacturas _vrf;
        private cargoClienteReimprimirFac _ccrf;
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataTable dt = new DataTable();
        public SqlCommand comand = new SqlCommand();
        private DataSet ds = new DataSet();
        private ReportDocument oRep = new ReportDocument();

        private string PATHReport;

        public reimprimirFacturaController(vistaReimprimoFacturas vrf)
        {
            _vrf = vrf;
        }

        public reimprimirFacturaController(cargoClienteReimprimirFac ccrf)
        {
            _ccrf = ccrf;
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
        public void BindData(vistaReimprimoFacturas _vrf, cargoClienteReimprimirFac _ccrf)
        {
            if (_ccrf.txtBusquedaClientes.Text == "")
            {
                _vrf.txtID_Cliente.Text = _ccrf.dgvClientesFactura.CurrentRow.Cells[0].Value.ToString();
                _vrf.txtNombreCliente.Text = _ccrf.dgvClientesFactura.CurrentRow.Cells[2].Value.ToString() + " " + _ccrf.dgvClientesFactura.CurrentRow.Cells[3].Value.ToString();
            } else
            {
                _vrf.txtID_Cliente.Text = _ccrf.dgvClientesFactura.CurrentRow.Cells[0].Value.ToString();
                _vrf.txtNombreCliente.Text = _ccrf.dgvClientesFactura.CurrentRow.Cells[1].Value.ToString() + " " + _ccrf.dgvClientesFactura.CurrentRow.Cells[2].Value.ToString();
            }

            if (_vrf.txtID_Cliente.Text != "")
            {
                traigoFacturas(_vrf);
                traigoRemitoFactura(_vrf);
            }
     
            _ccrf.Close();
        }

//--------------------------------------------------------------------------------------------------------------------------------------------------
        public void traigoFacturas(vistaReimprimoFacturas _vrf)
        {
            if (_vrf.txtID_Cliente.Text != "")
            {
                _vrf.cmbFacturasC.ValueMember = "Nro_Factura";
                _vrf.cmbFacturasC.DataSource = fac_Dao.SP_searchFacturasByIDClienteReimprimir(_vrf.txtID_Cliente.Text);
            }

        }
//--------------------------------------------------------------------------------------------------------------------------------------------------
        public void traigoRemitoFactura(vistaReimprimoFacturas _vrf)
        {
            if (_vrf.txtID_Cliente.Text != "")
            {
                _vrf.cmbRemito.ValueMember = "Nro_Remito";
                _vrf.cmbRemito.DataSource = fac_Dao.SP_searchRemitosByIDCliente(_vrf.txtID_Cliente.Text);
            }
        }
//--------------------------------------------------------------------------------------------------------------------------------------------------
        public void generoFactura(int NroFac)
        {

            _vrf.obtengoNroFac.Text = NroFac.ToString();
            var result = System.Windows.Forms.MessageBox.Show("DESEA ABRIR FACTURA DE CLIENTE?", "REIMPRESION FACTURA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
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

                fcr.crystalReport.ReportSource = oRep;

                fcr.ShowDialog();
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
        public void searchByfiltro()
        {
            fac_Dao.SearchClientsByFiltroReimprimirFacturas(_ccrf.dgvClientesFactura,_ccrf.txtBusquedaClientes.Text);
        }
    }
//--------------------------------------------------------------------------------------------------------------------------------------------------
}
