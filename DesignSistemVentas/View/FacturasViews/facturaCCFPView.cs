using DesignSistemVentas.Controller.FacturasController;
using DesignSistemVentas.Utilities;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View.FacturasViews
{
    public partial class facturaCCFPView : Form
    {
        private VistaFacturas _vf;
        private vistaFacturaCuotasCC_Controller _vfcc;
        Constants c = new Constants();

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

        public facturaCCFPView(VistaFacturas vf)
        {
            InitializeComponent();

            _vf = vf;

            _vfcc = new vistaFacturaCuotasCC_Controller(this);
        }


        private void facturaCCFPView_Load(object sender, EventArgs e)
        {

            _vfcc.traigoDatosnecesarios(_vf);

            bordesRedondeadosForm();
        }

        public Region bordesRedondeadosForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            return Region;
        }

        private void cmbBoxCantCuotas_MouseClick(object sender, MouseEventArgs e)
        {
            cmbBoxCantCuotas.DataSource = c.cuotasFacturaCC();
        }

        private void cmbBoxCantCuotas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // _vfcc.generoCuotasDGV(_vf);
        }

        private void cmbBoxCantCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            _vfcc.cambioSeleccionCuotas(_vf);
        }

        private void dgvFacturaCuotas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnAgregarCuotasFactura.Enabled = true;
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿DESEA CERRAR ESTA VENTANA?", "CERRAR ESTA VENTANA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                ActiveForm.Close();
            }
        }

        private void facturaCCFPView_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAgregarCuotasFactura_Click(object sender, EventArgs e)
        {
            if (cmbBoxCantCuotas.SelectedIndex >= 0)
            {
                _vfcc.generoCuotasDGV(_vf);
                _vfcc.pagoCC_CalculoCuotas_Observaciones(_vf);
                _vfcc.habilitoConfirmar(_vf);

                ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR LA CANTIDAD DE CUOTAS!", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
