using DesignSistemVentas.Controller.CategoriaProductosController;
using DesignSistemVentas.Utilities;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View.ProductosViews
{

    public partial class AltaCategoriaProducto : Form
    {
        private categoriaProductosController _cpc;

        // CODIGO PARA MOVER FORM SIN BORDES 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        // CODIGO PARA MOVER CREAR BORDES EN FORM

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public AltaCategoriaProducto()
        {
            InitializeComponent();
            _cpc = new categoriaProductosController(this);

        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            _cpc.AltaCategoriaController();
        }

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

        private void AltaCategoriaProducto_Load(object sender, EventArgs e)
        {
            _cpc.obtengoIDCategoria();

            WinAPI.AnimateWindow(this.Handle, 300, WinAPI.VER_POSITIVE);

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

        }
        private void botonSalir_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AltaCategoriaProducto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
