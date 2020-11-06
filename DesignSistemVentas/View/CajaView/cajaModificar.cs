using DesignSistemVentas.Controller.CajaController;
using DesignSistemVentas.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignSistemVentas.View.CajaView
{


    public partial class cajaModificar : Form
    {
        Constants c = new Constants();
        private cajaModificacionMovimientosController _cmmc;
        private cajaView _cv;

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
//----------------------------------------------------------------------------------------------------------------
        public Region bordesRedondeadosForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10,10));

            return Region;
        }

        public cajaModificar(cajaView cv)
        {
            InitializeComponent();
            _cmmc = new cajaModificacionMovimientosController(this);
            _cv = cv;
        }


        private void cajaModificar_Load(object sender, EventArgs e)
        {
            bordesRedondeadosForm();
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.VER_POSITIVE);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cajaModificar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmbTipoMovimiento_Click(object sender, EventArgs e)
        {

            cmbTipoMovimiento.DataSource = c.TipoMovimientoCaja();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            agregarClienteMovimientoModif acm = new agregarClienteMovimientoModif(this);
            acm.ShowDialog();
        }

        private void btnAltaMovimientoCaja_Click(object sender, EventArgs e)
        {
            _cmmc.updateMovimientoCaja(_cv);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            _cmmc.NumerosConComa(txtMonto, e);
        }
    }
}
