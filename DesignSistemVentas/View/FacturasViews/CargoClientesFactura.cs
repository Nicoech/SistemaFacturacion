using DesignSistemVentas.Controller.FacturasController;
using DesignSistemVentas.Model;
using DesignSistemVentas.Utilities;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View.FacturasViews
{
    public partial class cargoClientesFactura : Form
    {

        private clientesFacturaController _vtc_ctr;

        private UserSessionModel _user = new UserSessionModel();


        VistaFacturas vistaf;

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

        public cargoClientesFactura(VistaFacturas vf)
        {
            InitializeComponent();


            vistaf = vf;

            _vtc_ctr = new clientesFacturaController(this);


            bordesRedondeadosForm();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        public Region bordesRedondeadosForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            return Region;
        }



        private void CargoClientesFactura_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 300, WinAPI.VER_POSITIVE);
            _vtc_ctr.traigoClientes();
        }

        private void dgvClientesFactura_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            _vtc_ctr.bindDataCliente(vistaf);

        }

        private void txtBusquedaClientes_OnValueChanged(object sender, EventArgs e)
        {
            _vtc_ctr.SearchClientsByIDorDNI();
        }
    }
}
