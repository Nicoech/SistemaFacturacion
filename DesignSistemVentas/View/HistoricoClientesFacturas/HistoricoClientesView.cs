using DesignSistemVentas.Controller.HistoricoController;
using DesignSistemVentas.Utilities;
using EO.Internal;
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

namespace DesignSistemVentas.View.HistoricoClientesFacturas
{
    public partial class HistoricoClientesView : Form
    {
        private historicoController _hc;

        public HistoricoClientesView()
        {
            InitializeComponent();
            _hc = new historicoController(this);
        }
    
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
        private void btnClientes_Click(object sender, EventArgs e)
        {
            if(dgvHistorico.Rows.Count > 0)
            {
                dgvHistorico.DataSource = null;
            }
            cargoClienteHistorico cch = new cargoClienteHistorico(this);
            cch.ShowDialog();
        }

        private void HistoricoClientesView_Load(object sender, EventArgs e)
        {
            bordesRedondeadosForm();
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.CENTER);
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        public Region bordesRedondeadosForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            return Region;
        }
        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnListarHistoricoCliente_Click(object sender, EventArgs e)
        {
           if(txtDNICliente.Text != "" && txtNombre.Text != "")
            {
                _hc.traigoFacturasHistoricoByDniCliente(dgvHistorico);
            } else
            {
                MessageBox.Show("DEBE CARGAR UN CLIENTE PARA VER SU HISTORICO");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _hc.traigoFacturasHistoricoByFechas(dgvHistorico);
        }

        private void dtpInicial_ValueChanged(object sender, EventArgs e)
        {
            _hc.traigoFacturasHistoricoByFechas(dgvHistorico);
        }

        private void HistoricoClientesView_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if(dgvHistorico.Rows.Count > 0)
            {
                _hc.ExportarAExcel(dgvHistorico);
            } else
            {
                MessageBox.Show("No hay registros para exportar!");
            }
        }

        private void dgvHistorico_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnExportarExcel.Enabled = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            _hc.generoFacturaHistorico(txtDNICliente.Text);
        }
    }
}
