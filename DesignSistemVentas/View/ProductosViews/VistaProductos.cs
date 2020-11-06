using DesignSistemVentas.Controller;
using DesignSistemVentas.Controller.ProductosController;
using DesignSistemVentas.Model;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.Utilities;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View
{
    public partial class VistaProductos : Form
    {
        private AltaProductosController _ap_ctr;
        private VistaProductosController _vp_ctr;
        private ModificacionProductosController _mp_ctr;
        private DeleteProductosController _dp_ctr;

        private ProductosDao prod_Dao = new ProductosDao();

        // CODIGO PARA MOVER FORM SIN BORDES 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        // CODIGO PARA MOVER CREAR BORDES EN FORM

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public VistaProductos(UserSessionModel user)
        {
            InitializeComponent();

            _ap_ctr = new AltaProductosController(this);
            _vp_ctr = new VistaProductosController(this);
            _mp_ctr = new ModificacionProductosController(this);
            _dp_ctr = new DeleteProductosController(this);

            if (user.categoria_id == 2)
            {
                _vp_ctr.setViewToSellerUser();
            }
        }
        private void VistaProductos_Load(object sender, EventArgs e)
        {
            btnModificarProducto.Visible = false;
            btnEliminarProducto.Visible = false;
            WinAPI.AnimateWindow(this.Handle, 300, WinAPI.VER_POSITIVE);

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

        }



        //------------------------------------------------------------------------------------------------------------------------------

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
            if (System.Windows.Forms.MessageBox.Show("¿DESEA SALIR?", "SALIR A MENU A PRINCIPAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                ActiveForm.Close();
            }
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            _mp_ctr.bindDataProducto();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            _ap_ctr.AltaProductoView();
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            dgvProductos.DefaultCellStyle.Font = new Font("ComicSans", 12);

            _vp_ctr.searchProductsIntoDb();
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            btnModificarProducto.Visible = false;
            btnEliminarProducto.Visible = false;
        }

        private void dgvProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnModificarProducto.Visible = true;
            btnEliminarProducto.Visible = true;
        }


        private void VistaProductos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtBusquedaProductos_OnValueChanged(object sender, EventArgs e)
        {
            _vp_ctr.searchProductosIntoDbByCodOrDescripcion();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            var result = System.Windows.Forms.MessageBox.Show("DESEA ELIMINAR PRODUCTO?", "ELIMINAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                _dp_ctr.DeleteProducto();
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            _vp_ctr.ExportarAExcel(dgvProductos);
        }

        private void dgvProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvProductos.RowCount > 0)
            {
                btnExportarExcel.Enabled = true;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            _vp_ctr.generoReportProductos();
        }
    }
}
