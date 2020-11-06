using DesignSistemVentas.Controller;
using DesignSistemVentas.Utilities;
using DesignSistemVentas.View.FacturasViews;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignSistemVentas.View
{
    public partial class AltaClientes : Form
    {
        // CODIGO PARA MOVER FORM SIN BORDES 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        // CODIGO PARA MOVER CREAR BORDES EN FORM

        //VARIABLES PRIVADAS.
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private AltaClientesController _ac_ctr;
        private VistaClientes _vc;
        private DateTime f_nac;
        Constants c = new Constants();

        //CONSTRUCTORES
        //------------------------------------------------------------------------------------------------------------------------------------------      
        public AltaClientes(VistaClientes vc)
        {

            InitializeComponent();

            _ac_ctr = new AltaClientesController(this);

            _vc = vc;


        }

        public AltaClientes()
        {
            InitializeComponent();

            _ac_ctr = new AltaClientesController(this);
        }

        //------------------------------------------------------------------------------------------------------------------------------------------      


        private void AltaClientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AltaClientes_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 300, WinAPI.VER_POSITIVE);

            dtpFechaNacimiento.Value = DateTime.Today;
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




        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            txtFechaNacimiento.Text = dtpFechaNacimiento.Value.ToString("dd/MM/yyyy");
            f_nac = dtpFechaNacimiento.Value;

        }

        private void btnAltaCliente_Click_1(object sender, EventArgs e)
        {
            if (_ac_ctr.verificoTextboxsACeInsertoCliente() == true)
            {
                _ac_ctr.searchClientes(_vc);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }


        private void cmbBoxNroPF_MouseDown(object sender, MouseEventArgs e)
        {
            cmbBoxNroPF.DataSource = c.NumeroCuitPF();
        }
        private void cmbDigitoVerificador_MouseDown(object sender, MouseEventArgs e)
        {
            cmbDigitoVerificador.DataSource = c.DigitoVerificador();
        }

        //------------------------------------------------------------------------------------------------------------------------------------------      
        //RESTRICCIONES EN LOS TEXTBOXS.
        private void txtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ac_ctr.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ac_ctr.Sololetras(e);
        }
        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ac_ctr.Sololetras(e);
        }

        private void txtNroDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ac_ctr.SoloNumeros(e);
        }

        private void txtPrefijoTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ac_ctr.SoloNumeros(e);
        }

        private void cmbCondicionIVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ac_ctr.habilitoCuit();
        }

        private void btnAltaClienteFactura_Click(object sender, EventArgs e)
        {
            _ac_ctr.verificoTextboxsACeInsertoCliente();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void cmbCondicionIVA_MouseDown(object sender, MouseEventArgs e)
        {
            Constants c = new Constants();

            cmbCondicionIVA.DataSource = c.listaCondicionesIVA();

        }

        private void txtNroDocumento_MouseLeave(object sender, EventArgs e)
        {
            if(txtNroDocumento.Text != "")
            {
                _ac_ctr.verificoDNI();
            }

        }

        private void btnSalirACFac_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void txtNroCuit_MouseLeave(object sender, EventArgs e)
        {
            if (txtNroCuit.Text != "")
            {
                _ac_ctr.verificoDNICuit();
            }

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }



        //------------------------------------------------------------------------------------------------------------------------------------------      
    }
}
