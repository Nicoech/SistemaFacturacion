using DesignSistemVentas.Controller.FacturasController;
using DesignSistemVentas.Model.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignSistemVentas.View.FacturasViews.ReimprimirFactura
{
    public partial class cargoClienteReimprimirFac : Form
    {
        private FacturasDao fac_Dao = new FacturasDao();
        private vistaReimprimoFacturas _vrf;
        private reimprimirFacturaController _rfc;

        public cargoClienteReimprimirFac(vistaReimprimoFacturas vrf)
        {
            InitializeComponent();

            _vrf = vrf;

            _rfc = new reimprimirFacturaController(this);
        }
        private void cargoClienteReimprimirFac_Load(object sender, EventArgs e)
        {
            fac_Dao.searchClientesReimprimirFactura(dgvClientesFactura);
        }

        private void dgvClientesFactura_MouseClick(object sender, MouseEventArgs e)
        {
            _rfc.BindData(_vrf,this);
        }
        private void txtBusquedaClientes_OnValueChanged(object sender, EventArgs e)
        {
            _rfc.searchByfiltro();
        }
        private void botonSalir_Click(object sender, EventArgs e)
        {
            _rfc.cerrarVentana();
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


    }
}
