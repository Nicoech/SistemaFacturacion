using DesignSistemVentas.Controller;
using DesignSistemVentas.Utilities;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View.CuentasCorrientesView
{
    public partial class cuentasCorrientesView : Form
    {
        private cuentasCorrientesController _ccc_ctr;


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

        public cuentasCorrientesView()
        {
            InitializeComponent();

            _ccc_ctr = new cuentasCorrientesController(this);
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            cargoClienteCtaCte cargoC = new cargoClienteCtaCte(this);

            cargoC.ShowDialog();

            txtSaldo.Text = "0.00";
        }

        private void cuentasCorrientesView_Load(object sender, EventArgs e)
        {
            bordesRedondeadosForm();
            desahibilitoEventos();

            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.VER_POSITIVE);
        }

        public Region bordesRedondeadosForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            return Region;
        }
        public void desahibilitoEventos()
        {
            cmbBoxNroFac.Enabled = false;
        }
        private void cmbBoxNroFac_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _ccc_ctr.traigoFacturaCuotas();
            _ccc_ctr.traigoSaldo();

            foreach (DataGridViewRow row in dgvCtaCte.Rows)
            {
                if (row.Cells[4].Value.ToString() == "Abonada")
                {

                    row.DefaultCellStyle.BackColor = Color.Blue;
                    row.DefaultCellStyle.SelectionBackColor = Color.Blue;
                    row.DefaultCellStyle.ForeColor = Color.White;

                }
                else if (row.Cells[4].Value.ToString() == "Pendiente")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.SelectionBackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }

        }

        private void cmbBoxNroFac_MouseClick(object sender, MouseEventArgs e)
        {

            _ccc_ctr.traigoFacturas(this);
        }

        private void cmbBoxNroFac_SelectedValueChanged(object sender, EventArgs e)
        {
            _ccc_ctr.traigoSaldo();
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

        private void dgvCtaCte_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            base.OnClick(e);
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dgvCtaCte_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvCtaCte.CurrentRow.Cells[4].Value.ToString() != "Abonada")
            {
                _ccc_ctr.bindDataPagoCuota();
            }
            else
            {
                MessageBox.Show("ESTA CUOTA YA HA SIDO ABONADA", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cuentasCorrientesView_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            _ccc_ctr.UpdateEstadoCuotas(this);


        }

        private void cuentasCorrientesView_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void botonSalir_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void botonMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
