using DesignSistemVentas.Controller.FacturasController;
using DesignSistemVentas.Utilities;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View.FacturasViews
{
    public partial class facturaFPTarjetaView : Form
    {
        Constants c = new Constants();
        private VistaFacturas _vf;
        private vistaEncabezadoFacturaController _vef_ctr;

        // CODIGO PARA MOVER FORM SIN BORDES 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        // CODIGO PARA MOVER CREAR BORDES EN FORM
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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

        public facturaFPTarjetaView(VistaFacturas vf)
        {

            InitializeComponent();
            bordesRedondeadosForm();
            _vf = vf;
            _vef_ctr = new vistaEncabezadoFacturaController(this);
        }


        public Region bordesRedondeadosForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            return Region;
        }

        private void cmbBoxCantCuotas_MouseClick(object sender, MouseEventArgs e)
        {
            cmbBoxCantCuotas.DataSource = c.cuotasTarjeta();
        }

        private void cmbBoxCantCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            _vef_ctr.pagoTarjetaCalculoCuotas(_vf);
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿DESEA CERRAR ESTA VENTANA?", "CERRAR ESTA VENTANA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                ActiveForm.Close();
            }
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void facturaFPTarjetaView_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 300, WinAPI.VER_POSITIVE);

            _vf.txtEfectivo.Text = _vf.txtNetoImp.Text;
        }

        private void facturaFPTarjetaView_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
