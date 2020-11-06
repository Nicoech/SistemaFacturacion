using DesignSistemVentas.Controller.UserController;
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

namespace DesignSistemVentas.View.UsuariosView
{
    public partial class ModificarUsuarios : Form
    {
        public usuariosView _uv;
        private ModificarUsuarioController _muc;

        //------------------------------------------------------------------------------------------------------------------------------

        // CODIGO PARA MOVER FORM SIN BORDES 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        // CODIGO PARA MOVER CREAR BORDES EN FORM
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
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

        public ModificarUsuarios(usuariosView uv)
        {
            InitializeComponent();
            _uv = uv;
            _muc = new ModificarUsuarioController(this);
        }

        private void ModificarUsuarios_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.CENTER);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("¿DESEA SALIR?", "SALIR A MENU A PRINCIPAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                ActiveForm.Close();
            }
        }

        private void ModificarUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmbCategoria_Click(object sender, EventArgs e)
        {
            _muc.traigoTiposUsuarios();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            _muc.updateUsuario();
            _muc.traigoUsuarios(_uv);
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            _muc.muestroPassword(txtContraseña, cbPassword);
        }
    }
}
