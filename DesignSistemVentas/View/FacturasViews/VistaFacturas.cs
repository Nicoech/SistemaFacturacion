using DesignSistemVentas.Controller.FacturasController;
using DesignSistemVentas.Utilities;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View.FacturasViews
{
    public partial class VistaFacturas : Form
    {
        public bool ReadOnly { get; set; }

        private productosFacturaController _pf_ctr;
        private vistaEncabezadoFacturaController _vef_ctr;
        private cargoClientesFactura _ccf;
        private AltaClientes _ac;
        private Constants c = new Constants();

        // CODIGO PARA MOVER FORM SIN BORDES 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        // CODIGO PARA MOVER CREAR BORDES EN FORM
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
             (
                int nLeftRect,     // x-coordinate of upper-left corner
                int nTopRect,      // y-coordinate of upper-left corner
                int nRightRect,    // x-coordinate of lower-right corner
                int nBottomRect,   // y-coordinate of lower-right corner
                int nWidthEllipse, // height of ellipse
                int nHeightEllipse // width of ellipse

            );

        public VistaFacturas(string nombreVendedor)
        {
            _vef_ctr = new vistaEncabezadoFacturaController(this);
            _pf_ctr = new productosFacturaController(this);
            InitializeComponent();


            txtVendedor.Text = nombreVendedor.ToUpper();
        }
        public VistaFacturas(cargoClientesFactura ccf)
        {
            _ccf = ccf;
        }
        public VistaFacturas(AltaClientes ac)
        {
            _ac = ac;
        }

        public void VistaFacturas_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.CENTER);

            bordesRedondeadosForm();

            _vef_ctr.accionesFacturasLoad();

            _vef_ctr.generoNroFactura();

            _vef_ctr.controloFacturaYhabilito2doTab(this);

        }
        private void VistaFacturas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Region bordesRedondeadosForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            return Region;
        }


        //------ACCIONES DE BOTONES DEL FORM VISTA FACTURAS----------------------------------------------------------------------------------------


        private void botonSalir_Click(object sender, EventArgs e)
        {
            _vef_ctr.cerrarVentana();
        }
        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            cargoClientesFactura CCF = new cargoClientesFactura(this);
            CCF.ShowDialog();
        }

        private void btnAgregoProd_Click(object sender, EventArgs e)
        {

            _vef_ctr.controlDatosClienteFactura();

        }

        private void btnEliminoProd_Click(object sender, EventArgs e)
        {
            if (_pf_ctr.adicionCantidad() == true)
            {
                _pf_ctr.eliminoProducto();
                txtNroRemito.Text = "";
            }
            
        }
        private void btnConfirmarFacturaRegis_Click(object sender, EventArgs e)
        {
            var result = System.Windows.Forms.MessageBox.Show("ESTA SEGURO DE GENERAR FACTURA?", "FACTURAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result != DialogResult.OK)
            {
                tabControl.SelectedTab = encabezadoFactura;
            }
            else
            {
                _vef_ctr.controloFormaDePagoFacturaRegis();
                _vef_ctr.ventanaPregunta();
            }

        }

        private void txtImportAbonado_KeyPress(object sender, KeyPressEventArgs e)
        {
            _vef_ctr.NumerosConComa(txtImporteAbonado, e);
        }
        //-------------------------------------------------------------------------------------------------------------------------------

        //RESTRICCIONES Y ACCIONES DE LOS TEXTBOXS VISTA FACTURA Y EVENTOS DE COMPONENTES.
        private void txtDNICliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            _vef_ctr.SoloNumeros(e);

        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            _vef_ctr.Sololetras(e);
        }
        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            _vef_ctr.Sololetras(e);
        }


        private void txtNroDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            _vef_ctr.SoloNumeros(e);
        }

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            _vef_ctr.SoloNumeros(e);
        }

        private void dgvFactura_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            _vef_ctr.deshabilitoComponentes();
            _vef_ctr.controloFacturaYhabilito2doTab(this);

        }


        private void cmbBoxTipoCliente_MouseClick(object sender, MouseEventArgs e)
        {
            Constants c = new Constants();
            cmbBoxTipoCliente.DataSource = c.TipoCliente();
        }

        private void cmbBoxSitIVA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _vef_ctr.habilitoEventos();
        }

        private void cmbBoxTipoCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _vef_ctr.muestroTipoDeFactura();

            _vef_ctr.vaciarDatos();
        }



        private void cmbBoxLetraF_MouseClick(object sender, MouseEventArgs e)
        {
            cmbBoxLetraF.DataSource = c.LetrasFactura();
        }

        private void tabControl_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvFactura_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            _vef_ctr.deshabilitoComponentes();
            _vef_ctr.controloFacturaYhabilito2doTab(this);
        }

        private void cmbFormaDePago_MouseClick(object sender, MouseEventArgs e)
        {
            _vef_ctr.muestroFormasDePagoCliente();

        }

        private void cmbFormaDePago_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            btnSeleccionFP.Visible = false;
            _vef_ctr.seleccionFormaDePago();
        }

        private void txtDNICliente_Leave(object sender, EventArgs e)
        {
            if(txtDNICliente.Text != "")
            {
                _vef_ctr.chequeoDNIFacEvent(txtDNICliente.Text);
            }

        }

        private void txtImportAbonado_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (Text != "")
            {
                _pf_ctr.vuelto();
            }
            else
            {
                Text = "";
            }
        }

        private void btnGeneroRemito_Click(object sender, EventArgs e)
        {
            _vef_ctr.generoNroRemito();
        }

        private void btnSeleccionFP_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = formaDePago;
        }

        private void txtNroDomicilio_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            btnSeleccionFP.Visible = false;
        }

        private void cmbBoxSitIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbBoxNroPF_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cmbDigitoVerificador_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtNombreC_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _vef_ctr.agregoDatosTarjeta(this);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
    }
}
