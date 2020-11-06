using DesignSistemVentas.Controller.ClientesController;
using DesignSistemVentas.Utilities;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View
{
    public partial class ModificacionClientes : Form
    {
        private DateTime f_nac;

        private ModificacionClientesController _mc_ctr;
        private VistaClientes _vc;
        private Constants c = new Constants();

        // CODIGO PARA MOVER FORM SIN BORDES 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        // CODIGO PARA MOVER CREAR BORDES EN FORM

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public ModificacionClientes(VistaClientes vc)
        {
            InitializeComponent();

            _vc = vc;

            _mc_ctr = new ModificacionClientesController(this);


        }


        private void botonSalir_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("¿DESEA SALIR?", "SALIR A MENU A PRINCIPAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                ActiveForm.Close();
            }
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ModificacionClientes_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 300, WinAPI.VER_POSITIVE);
            dtpFechaNacimiento.Text = txtFechaNacimiento.Text;
        }

        private void cmbCondicionIVA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbCondicionIVA.Text = cmbCondicionIVA.SelectedValue.ToString();
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            txtFechaNacimiento.Text = dtpFechaNacimiento.Value.ToString("dd/MM/yyyy");
            f_nac = dtpFechaNacimiento.Value;

        }

        private void ModificacionClientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (_mc_ctr.verificoTextBoxsMC() == true)
            {
                _mc_ctr.searchClientes(_vc);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void cmbBoxNroPF_MouseClick(object sender, MouseEventArgs e)
        {
            cmbBoxNroPF.DataSource = c.NumeroCuitPF();
            cmbBoxNroPF.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void cmbDigitoVerificador_MouseClick(object sender, MouseEventArgs e)
        {
            cmbDigitoVerificador.DataSource = c.DigitoVerificador();
            cmbDigitoVerificador.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void cmbCondicionIVA_MouseClick_1(object sender, MouseEventArgs e)
        {

            cmbCondicionIVA.DataSource = c.listaCondicionesIVA();
            cmbCondicionIVA.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtNroDocumento_TextChanged(object sender, EventArgs e)
        {
            txtNroCuit.Text = txtNroDocumento.Text;
        }

        private void txtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            _mc_ctr.SoloNumeros(e);
        }

        private void txtNroCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            _mc_ctr.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            _mc_ctr.Sololetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            _mc_ctr.Sololetras(e);
        }

        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            _mc_ctr.Sololetras(e);
        }

        private void txtNroDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            _mc_ctr.SoloNumeros(e);
        }

        private void txtNroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            _mc_ctr.SoloNumeros(e);
        }

        private void cmbCondicionIVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            _mc_ctr.habilitoCuit();
        }

        private void dtpFechaNacimiento_ValueChanged_1(object sender, EventArgs e)
        {
            txtFechaNacimiento.Text = dtpFechaNacimiento.Value.ToString("dd/MM/yyyy");
            f_nac = dtpFechaNacimiento.Value;
        }


    }
}
