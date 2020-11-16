using DesignSistemVentas.Controller;
using DesignSistemVentas.Controller.ClientesController;
using DesignSistemVentas.Model;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.Utilities;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View
{
    public partial class VistaClientes : Form
    {
        private ModificacionClientesController _mc_ctr;
        private DeleteClientesController _dc_ctr;
        private VistaClientesController _vc_ctr;
        private AltaClientesController _ac_ctr;

        private ClientesDao cln_dao = new ClientesDao();

        // CODIGO PARA MOVER FORM SIN BORDES 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        // CODIGO PARA MOVER CREAR BORDES EN FORM

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public VistaClientes()
        {
            InitializeComponent();
        }

        public VistaClientes(UserSessionModel user)
        {
            InitializeComponent();


            _vc_ctr = new VistaClientesController(this);
            _mc_ctr = new ModificacionClientesController(this);
            _dc_ctr = new DeleteClientesController(this);
            _ac_ctr = new AltaClientesController(this);

            if (user.categoria_id == 2)
            {
                _vc_ctr.setViewToSellerUser();
            }

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


        //BOTONES DE SALIR Y MINIMIZAR VENTANA
        private void botonSalir_Click_1(object sender, EventArgs e)
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

        //ANIMACION CUANDO SE ABRE FORM
        private void VistaClientes_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 360, WinAPI.VER_POSITIVE);

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        //FUNCION PARA PODER MOVER EL FORM LIBREMENTE
        private void VistaClientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //LISTAR TODOS LOS CLIENTES EN LA GRILLA
        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            dgvClientes.DefaultCellStyle.Font = new Font("ComicSans", 12);

            _vc_ctr.searchClientes();
        }

        //ABRIR FORM PARA DAR DE ALTA UN CLIENTE
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            _ac_ctr.AltaClienteView();

        }
        //ABRIR FORM PARA MODIFICAR UN CLIENTE
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            _mc_ctr.bindDataCliente();
        }
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            var result = System.Windows.Forms.MessageBox.Show("DESEA ELIMINAR CLIENTE?", "ELIMINAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                _dc_ctr.DeleteClient(dgvClientes);
            }
        }


        //EVENTOS DE BOTONES

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificarClientes.Visible = true;
            btnEliminarCliente.Visible = true;

        }


        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            btnModificarClientes.Visible = false;
            btnEliminarCliente.Visible = false;
        }

        private void txtBusquedaClientes_OnValueChanged(object sender, EventArgs e)
        {
            _vc_ctr.SearchClientsByIDorDNI();
        }


        private void dgvClientes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvClientes.RowCount > 0)
            {
                btnExportarExcel.Enabled = true;
            }
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            _vc_ctr.ExportarAExcel(dgvClientes);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("¿DESEA SALIR?", "SALIR A MENU A PRINCIPAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                ActiveForm.Close();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            _vc_ctr.generoReportClientes();
        }
    }
}
