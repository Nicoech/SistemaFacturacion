using DesignSistemVentas.Controller;
using DesignSistemVentas.Properties;
using DesignSistemVentas.View.FacturasViews;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas
{
    public partial class LoginForm : Form
    {
        private UserSessionController _UserController = null;
        private VistaFacturas _vf;
        private VentanaPrincipal _vp;
        public object UsuarioLogueado { get; private set; }


        //CODIGO PARA MOVER FORM SIN BORDES 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]


        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public LoginForm()
        {
            InitializeComponent();

            _UserController = new UserSessionController(_vp);

            FormBorderStyle = FormBorderStyle.None;

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        public LoginForm(VistaFacturas vf)
        {
            _vf = vf;
        }
        public LoginForm(VentanaPrincipal vp)
        {
            _vp = vp;
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


        private void btnLogin_Click(object sender, EventArgs e)
        {
            _UserController.Login(txtUsuario, txtContraseña);
        }



        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            txtUsuario.Size = new Size(280, 280);
            txtContraseña.Size = new Size(280, 280);
        }

        private void btnIngresoUsuario_Click(object sender, EventArgs e)
        {
            _UserController.Login(txtUsuario, txtContraseña);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿DESEA SALIR?", "SALIR DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnIngresoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)13)
            {
                btnIngresoUsuario_Click(sender, e);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿DESEA SALIR?", "SALIR DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            _UserController.Login(txtUsuario, txtContraseña);
        }
    }
}

