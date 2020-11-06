using DesignSistemVentas.Controller.ProductosController;
using DesignSistemVentas.Utilities;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View.ProductosViews
{
    public partial class ModificacionesProductos : Form
    {

        private ModificacionProductosController _mp_ctr;
        private VistaProductos _vp;

        // CODIGO PARA MOVER FORM SIN BORDES 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        // CODIGO PARA MOVER CREAR BORDES EN FORM
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public ModificacionesProductos(VistaProductos vp)
        {
            InitializeComponent();

            _vp = vp;
            _mp_ctr = new ModificacionProductosController(this);
        }

///----------------------------------------------------------------------------------------------------------------------------------------------------
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
///----------------------------------------------------------------------------------------------------------------------------------------------------
        private void botonSalir_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("¿DESEA SALIR?", "SALIR A MENU A PRINCIPAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                ActiveForm.Close();
            }
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ModificacionesProductos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ModificacionesProductos_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 300, WinAPI.VER_POSITIVE);

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if ((txtID_P.Text != "") & (txtDescripcion.Text != "") & (txtPrecio.Text != "") & (txtCantidadAct.Text != "") &
               (txtCantidadMin.Text != ""))

            {
                var result = System.Windows.Forms.MessageBox.Show("DESEA ACTUALIZAR PRODUCTO?", "MODIFICACION PRODUCTO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    _mp_ctr.UpdateProducto();
                    _mp_ctr.searchProductsIntoDb(_vp);
                }

            }
            else
            {

                System.Windows.Forms.MessageBox.Show("DEBE COMPLETAR TODOS LOS CAMPOS PARA PODER DAR DE ALTA UN PRODUCTO!", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            _mp_ctr.SoloNumeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            _mp_ctr.NumerosConComa(txtPrecio, e);
        }

        private void txtCantidadAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            _mp_ctr.SoloNumeros(e);
        }

        private void txtCodProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            _mp_ctr.SoloNumerosyLetras(e);
        }

        private void cmbCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            _mp_ctr.traigoCategoriaProductos();
        }

        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
