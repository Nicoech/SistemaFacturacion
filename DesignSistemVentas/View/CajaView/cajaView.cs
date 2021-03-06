﻿using DesignSistemVentas.Controller.CajaController;
using DesignSistemVentas.Model;
using DesignSistemVentas.Utilities;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View.CajaView
{
    public partial class cajaView : Form
    {

        private cajaAltaMovimientoController _camc;
        private cajaModificacionMovimientosController _cmmc;
        private cajaDeleteMovimientoController _cdmc;
        private agregarClienteMovimientoModif _acm;
        private CajaController _cc;
        private Constants c = new Constants();



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


        public cajaView(UserSessionModel user)
        {
            InitializeComponent();


            _camc = new cajaAltaMovimientoController(this);

            _cmmc = new cajaModificacionMovimientosController(_acm);
            _cdmc = new cajaDeleteMovimientoController(this);
            _cc = new CajaController(this);


            if (user.categoria_id == 2)
            {
                _cc.setViewToSellerUser();
            }

        }
        private void cajaView_Load(object sender, EventArgs e)
        {
            bordesRedondeadosForm();
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.VER_POSITIVE);
        }
        public Region bordesRedondeadosForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            return Region;
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAgregarMovimiento_Click(object sender, EventArgs e)
        {
            cajaAgregar ca = new cajaAgregar(this);
            ca.ShowDialog();
        }

        private void cajaView_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            _camc.searchMovimientosCaja(this);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnModificarMovimiento_Click(object sender, EventArgs e)
        {
            _cmmc.bindDataMovimiento(this);
        }

        private void dgvCtaCte_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnModificarMovimiento.Visible = true;
            btnEliminarMovimiento.Visible = true;
        }

        private void btnEliminarMovimiento_Click(object sender, EventArgs e)
        {
            _cdmc.DeleteMovimientoCaja(this);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            _cc.generoReportCaja();
        }


        private void dtpInicial_ValueChanged(object sender, EventArgs e)
        {
            _cc.traigoMovimientosbyFechas(dgvCaja);
        }

        private void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            _cc.traigoMovimientosbyFiltro(dgvCaja);
        }

        private void cmbTipo_MouseClick(object sender, MouseEventArgs e)
        {
            cmbTipo.DataSource = c.TipoMovimientoCaja();
        }

        private void dgvCaja_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            _cc.generoTotalCaja(dgvCaja);
        }
    }
}
