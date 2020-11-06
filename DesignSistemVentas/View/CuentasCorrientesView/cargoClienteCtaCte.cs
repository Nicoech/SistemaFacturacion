using DesignSistemVentas.Controller;
using DesignSistemVentas.Utilities;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View.CuentasCorrientesView
{
    public partial class cargoClienteCtaCte : Form
    {
        private cuentasCorrientesController _ccc_ctr;
        private cuentasCorrientesView _ccv;

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

        public cargoClienteCtaCte(cuentasCorrientesView ccv)
        {
            InitializeComponent();

            _ccv = ccv;
            _ccc_ctr = new cuentasCorrientesController(this);
        }


        private void botonSalir_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cargoClienteCtaCte_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.VER_POSITIVE);
            bordesRedondeadosForm();


            if (_ccc_ctr.traigoCliente() == false) {
                this.Close(); 
            }

        }

        public Region bordesRedondeadosForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            return Region;
        }
        private void dgvClientesCtaCte_MouseClick(object sender, MouseEventArgs e)
        {
            if (_ccv.dgvCtaCte.RowCount > 0)
            {
                ((DataTable)_ccv.dgvCtaCte.DataSource).Rows.Clear();

                _ccv.dgvCtaCte.Refresh();

                _ccc_ctr.bindDataCliente(_ccv);

            }
            else
            {
                _ccc_ctr.bindDataCliente(_ccv);
            }
            ActiveForm.Close();
        }

        private void txtBusquedaClientes_OnValueChanged(object sender, EventArgs e)
        {
            _ccc_ctr.traigoClienteByFiltro();
        }

    }
}
