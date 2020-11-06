using DesignSistemVentas.Controller.ClientesController;
using DesignSistemVentas.Controller.UserController;
using DesignSistemVentas.Controller.UsuariosController;
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
    public partial class usuariosView : Form
    {
        private VistaUsuariosController _vuc;
        private ModificarUsuarioController _muc;
        private DeleteUserController _duc;
        private ModificarUsuarios _mu;

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

        public usuariosView()
        {
            InitializeComponent();
            _vuc = new VistaUsuariosController(this);
            _muc = new ModificarUsuarioController(_mu);
            _duc = new DeleteUserController(this);
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AltaUsuarios au = new AltaUsuarios(this);
            au.ShowDialog();
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            _vuc.traigoUsuarios();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            _muc.bindDataUsuarios(this);
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            _duc.DeleteProducto();
        }
        private void dgvUsuarios_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnModificarUsuario.Visible = true;
            btnEliminarUsuario.Visible = true;
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

        private void usuariosView_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 50, WinAPI.CENTER);
        }

        private void usuariosView_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
