using DesignSistemVentas.Controller;
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

namespace DesignSistemVentas.View.CuentasCorrientesView
{
    public partial class morososView : Form
    {
        cuentasCorrientesController _ccc;

        public morososView()
        {
            InitializeComponent();
            _ccc = new cuentasCorrientesController(this);
        }

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
        private void morososView_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 360, WinAPI.VER_POSITIVE);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            _ccc.traigoMorosos();
        }

        private void dgvMorosos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in dgvMorosos.Rows)
            {

                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.SelectionBackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;

            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
                ActiveForm.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void morososView_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
