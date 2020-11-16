using DesignSistemVentas.Controller.FacturasController;
using DesignSistemVentas.Utilities;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View.FacturasViews.ReimprimirFactura
{
    public partial class vistaReimprimoFacturas : Form
    {
        private reimprimirFacturaController _rf_ctr;
        private vistaEncabezadoFacturaController _vef_ctr;


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

        public vistaReimprimoFacturas()
        {
            InitializeComponent();

            _rf_ctr = new reimprimirFacturaController(this);
            _vef_ctr = new vistaEncabezadoFacturaController(this);
        }

        public Region bordesRedondeadosForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            return Region;
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            cargoClienteReimprimirFac ccrf = new cargoClienteReimprimirFac(this);
            ccrf.ShowDialog();
        }

        private void cmbFacturasC_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _rf_ctr.generoFactura(Convert.ToInt32(cmbFacturasC.Text));
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            _vef_ctr.cerrarVentana();
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void vistaReimprimoFacturas_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.VER_POSITIVE);
            bordesRedondeadosForm();
        }

        private void vistaReimprimoFacturas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void cmbRemito_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _rf_ctr.generoRemito(Convert.ToInt32(cmbRemito.Text));
        }
    }
}
