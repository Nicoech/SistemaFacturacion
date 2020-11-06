using DesignSistemVentas.Controller;
using DesignSistemVentas.Utilities;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View.ProductosViews
{
    public partial class AltaProductos : Form
    {
        // CODIGO PARA MOVER FORM SIN BORDES 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        // CODIGO PARA MOVER CREAR BORDES EN FORM

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        ///----------------------------------------------------------------------------------------------------------------------------------------------------
        private AltaProductosController _ap_ctr;
        private VistaProductos _vp;

        //INICIALIZADOR DE COMPONENTES
        public AltaProductos(VistaProductos vp)
        {
            InitializeComponent();

            _vp = vp;
            _ap_ctr = new AltaProductosController(this);

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

        //BOTONES PARA SALIR Y MINIMIZAR DEL FORM
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
        ///----------------------------------------------------------------------------------------------------------------------------------------------------
        //BOTON PARA DAR DE ALTA PRODUCTO

        ///----------------------------------------------------------------------------------------------------------------------------------------------------
        //FUNCIONALIDADES DE FORM
        private void AltaProductos_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 300, WinAPI.VER_POSITIVE);

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            _ap_ctr.obtengoID_NuevoProducto();
        }

        private void AltaProductos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        ///----------------------------------------------------------------------------------------------------------------------------------------------------
        //BOTONES.
        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            if ((txtID_Prod.Text != "") & (txtDescripcion.Text != "") & (txtStockMin.Text != "") & (txtStockAct.Text != "") & (txtPrecio.Text != "") &
            (txtDescripcion.Text != ""))

            {
                var result = System.Windows.Forms.MessageBox.Show("DESEA DAR DEL ALTA NUEVO PRODUCTO?", "ALTA PRODUCTO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    _ap_ctr.AltaProducto();
                    _ap_ctr.searchProductsIntoDb(_vp);
                }

            }
            else
            {

                System.Windows.Forms.MessageBox.Show("DEBE COMPLETAR TODOS LOS CAMPOS PARA PODER DAR DE ALTA UN PRODUCTO!", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        ///----------------------------------------------------------------------------------------------------------------------------------------------------
        //RESTRICCIONES DE TEXTBOXS

        private void txtCodProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ap_ctr.SoloNumeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ap_ctr.NumerosConComa(txtPrecio, e);
        }

        private void txtStockAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ap_ctr.SoloNumeros(e);
        }

        private void txtStockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ap_ctr.SoloNumeros(e);
        }

        private void txtCodProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ap_ctr.SoloNumerosyLetras(e);
        }

        private void cmbCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            _ap_ctr.traigoCategoriaProductos();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            AltaCategoriaProducto acp = new AltaCategoriaProducto();
            acp.ShowDialog();
        }

        ///----------------------------------------------------------------------------------------------------------------------------------------------------

    }
}
