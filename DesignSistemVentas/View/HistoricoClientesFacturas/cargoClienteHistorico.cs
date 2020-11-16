using DesignSistemVentas.Controller.HistoricoController;
using DesignSistemVentas.Utilities;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View.HistoricoClientesFacturas
{
    public partial class cargoClienteHistorico : Form
    {
        private cargoClientesHistoricoController _cchc;
        private HistoricoClientesView _hcv;

        public cargoClienteHistorico(HistoricoClientesView hcv)
        {
            InitializeComponent();
            _cchc = new cargoClientesHistoricoController(this);
            _hcv = hcv;
        }


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
        private void cargoClienteHistorico_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.VER_POSITIVE);
            bordesRedondeadosForm();

            _cchc.traigoClientes();
        }

        private void dgvClientesHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _cchc.bindDataCliente(_hcv);
            ActiveForm.Close();
        }
    }
}
