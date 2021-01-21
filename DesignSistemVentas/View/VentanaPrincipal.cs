using DesignSistemVentas.Controller;
using DesignSistemVentas.Model;
using DesignSistemVentas.View;
using DesignSistemVentas.View.CajaView;
using DesignSistemVentas.View.CuentasCorrientesView;
using DesignSistemVentas.View.FacturasViews;
using DesignSistemVentas.View.FacturasViews.ReimprimirFactura;
using DesignSistemVentas.View.HistoricoClientesFacturas;
using DesignSistemVentas.View.UsuariosView;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.Properties
{
    public partial class VentanaPrincipal : Form
    {

        // CODIGO PARA MOVER FORM SIN BORDES 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        // CODIGO PARA MOVER CREAR BORDES EN FORM
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private UserSessionModel _user;
        private VistaFacturas vistaf;
        private UserSessionController _user_ctr;
        LoginForm _lf;
        public VentanaPrincipal(VistaFacturas vf)
        {
            vistaf = vf;

        }
        public VentanaPrincipal(LoginForm lf)
        {
            _lf = lf;
        }


        public VentanaPrincipal(UserSessionModel User)
        {
            InitializeComponent();

            _user = User;

            _user_ctr = new UserSessionController(this);

            if (User.categoria_id == 2)
            {
                _user_ctr.setViewToSellerUser();
            }
            FormBorderStyle = FormBorderStyle.None;

            nombreUsuario.Text = String.Format("Bienvenido {0}", User.Username);
            tipoUsuario.Text = String.Format("Tipo de usuario: {0}", User.TipoUsuario);

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

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
        private void FechaHora_Tick(object sender, EventArgs e)
        {
            DiaMesAño.Text = "Fecha: " + DateTime.Now.ToString("D").ToUpper();
            Reloj.Text = "Hora: " + DateTime.Now.ToLongTimeString();
        }

        private void VentanaPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            msjBotones.SetToolTip(btnSalir, "SALIR DEL SISTEMA");
        }

        private void panelBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("¿DESEA SALIR?", "SALIR A MENU DE INGRESO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();

                LoginForm lf = new LoginForm();

                lf.Show();

            }
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

            VistaClientes VC = new VistaClientes(_user);

            VC.Show();

        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            VistaProductos VP = new VistaProductos(_user);

            VP.Show();
        }
        private void btnFacturacion_Click(object sender, EventArgs e)
        {

            VistaFacturas VF = new VistaFacturas(_user.Username);

            VF.Show();
        }
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            usuariosView uv = new usuariosView();
            uv.ShowDialog();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("¿DESEA SALIR?", "SALIR DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCrearUsuario_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("CREAR USUARIOS", btnCrearUsuario);
        }

        private void btnCuentasCorrientes_Click(object sender, EventArgs e)
        {
            cuentasCorrientesView ccv = new cuentasCorrientesView();
            ccv.ShowDialog();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReimprimirFacturas_Click(object sender, EventArgs e)
        {
            vistaReimprimoFacturas vrf = new vistaReimprimoFacturas();
            vrf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cajaView cv = new cajaView(_user);
            cv.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HistoricoClientesView hcv = new HistoricoClientesView();
            hcv.ShowDialog();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            morososView mv = new morososView();
            mv.ShowDialog();
        }
    }
}
