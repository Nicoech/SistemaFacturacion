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
    public partial class cajaAgregar : Form
    {

        private cajaAltaMovimientoController _camc;
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

        public cajaAgregar(cajaView cv)
        {
            InitializeComponent();
            _cv = cv;
            _camc = new cajaAltaMovimientoController(this);
        }

        public Region bordesRedondeadosForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            return Region;
        }
        private void cajaAgregar_Load(object sender, EventArgs e)
        {
            bordesRedondeadosForm();
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.VER_POSITIVE);
            _camc.generoNroPlanilla();
            _camc.accionesCajaAltaMovimientosLoad();
        }   

        private void botonSalir_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cajaAgregar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            agregarClienteMovimiento acm = new agregarClienteMovimiento(this);
            acm.ShowDialog();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            _camc.NumerosConComa(txtMonto,e);
        }

        private void btnAltaMovimientoCaja_Click(object sender, EventArgs e)
        {
            _camc.AltaMovimientoCaja(_cv);
        }
    }
}
