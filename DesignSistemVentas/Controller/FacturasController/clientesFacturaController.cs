using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.Properties;
using DesignSistemVentas.View.FacturasViews;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace DesignSistemVentas.Controller.FacturasController
{
    class clientesFacturaController
    {

        private FacturasDao fac_Dao = new FacturasDao();
        private VistaFacturas _vf;
        private cargoClientesFactura _ccf;
        private VentanaPrincipal _vp;

        public clientesFacturaController(VistaFacturas vf)
        {
            _vf = vf;
        }
        public clientesFacturaController(cargoClientesFactura ccf)
        {
            _ccf = ccf;
        }

        public clientesFacturaController(VentanaPrincipal vp)
        {
            _vp = vp;
        }

        public void traigoClientes()
        {
            fac_Dao.searchClientesFactura(_ccf.dgvClientesFactura);
        }



        public void bindDataCliente(VistaFacturas _vf)
        {
            _vf.txtIDCliente.Text = _ccf.dgvClientesFactura.CurrentRow.Cells[0].Value.ToString();
            _vf.txtDNICliente.Text = _ccf.dgvClientesFactura.CurrentRow.Cells[1].Value.ToString();


            _vf.txtCuit.Text = _ccf.dgvClientesFactura.CurrentRow.Cells[2].Value.ToString();

            _vf.txtSitIVA.Text = _ccf.dgvClientesFactura.CurrentRow.Cells[6].Value.ToString();

            _vf.txtNombreCliente.Text = _ccf.dgvClientesFactura.CurrentRow.Cells[3].Value.ToString() + ' ' + _ccf.dgvClientesFactura.CurrentRow.Cells[4].Value.ToString();
            _vf.txtDomicilio.Text = obtengoLetrasString(_ccf.dgvClientesFactura.CurrentRow.Cells[5].Value.ToString().ToUpper());
            _vf.txtNroDomicilio.Text = obtengoNumerosString(_ccf.dgvClientesFactura.CurrentRow.Cells[5].Value.ToString());

            _ccf.Close();

            _vf.txtSitIVA.Enabled = true;

            _vf.btnAgregarProducto.Enabled = true;
        }
        public void SearchClientsByIDorDNI()
        {
            fac_Dao.SearchClientsByIDorDNI(_ccf.dgvClientesFactura, _ccf.txtBusquedaClientes.Text);
        }

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
        public string obtengoNumerosString(string a)
        {

            int val = 0;
            string guardo = string.Empty;

            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsDigit(a[i]))
                    guardo += a[i];
            }

            if (guardo.Length > 0)
                val = int.Parse(guardo);
            a = val.ToString();

            return a;
        }
        public string obtengoLetrasString(string a)
        {

            string guardo = string.Empty;

            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsLetter(a[i]))
                    guardo += a[i];
                if (Char.IsWhiteSpace(a[i]))
                    guardo += a[i];

            }

            if (guardo.Length > 0)
            {
                a = guardo;
            }


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
    }
}
