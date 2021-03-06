﻿using DesignSistemVentas.Controller;
using DesignSistemVentas.Utilities;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View.CuentasCorrientesView
{
    public partial class cuentaCorrienteAbonarCuotaView : Form
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

        public cuentaCorrienteAbonarCuotaView(cuentasCorrientesView ccv)
        {
            InitializeComponent();

            _ccv = ccv;
            _ccc_ctr = new cuentasCorrientesController(this);
        }
        private void cuentaCorrienteAbonarCuotaView_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.VER_POSITIVE);
            bordesRedondeadosForm();
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


        private void cuentaCorrienteAbonarCuotaView_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = System.Windows.Forms.MessageBox.Show("ESTA SEGURO DE ABONAR EL PAGO DE LA CUOTA?", "PAGO CUOTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _ccc_ctr.pintoFilaCuotAbonada(_ccv);
                _ccc_ctr.UpdateEstadoCuotas(_ccv);
                _ccc_ctr.generoReciboCTACTE(Convert.ToInt32(_ccv.cmbBoxNroFac.Text), txtSaldoAct.Text, txtSaldoFinal.Text, txtNroCuota.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
