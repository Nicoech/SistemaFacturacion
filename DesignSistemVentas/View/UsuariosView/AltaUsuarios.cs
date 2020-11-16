using DesignSistemVentas.Controller.UserController;
using DesignSistemVentas.Controller.UsuariosController;
using DesignSistemVentas.Utilities;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View.UsuariosView
{
    public partial class AltaUsuarios : Form
    {
        private VistaUsuariosController _vu_ctr;
        private AltaUsuariosController _au_ctr;
        private usuariosView _uv;

        //------------------------------------------------------------------------------------------------------------------------------

        // CODIGO PARA MOVER FORM SIN BORDES 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        // CODIGO PARA MOVER CREAR BORDES EN FORM
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public AltaUsuarios(usuariosView uv)
        {
            InitializeComponent();
            _uv = uv;
            _vu_ctr = new VistaUsuariosController(this);
            _au_ctr = new AltaUsuariosController(this);

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

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
        //------------------------------------------------------------------------------------------------------------------------------

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

        //------------------------------------------------------------------------------------------------------------------------------

        private void AltaUsuarios_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.CENTER);
        }

        private void AltaUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmbCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            _vu_ctr.traigoCategoriasUsuarios();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            _au_ctr.AltaUsuario();
            _au_ctr.traigoUsuarios(_uv);
        }

        private void cmbCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _au_ctr.obtengoIDCategoriaString(cmbCategoria.Text);

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            _au_ctr.obtengoIDCategoriaString(cmbCategoria.Text);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            _au_ctr.muestroPassword(txtContraseña, cbPassword);
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
    }
}
