using DesignSistemVentas.Model;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.View;
using System;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller
{

    public class AltaClientesController
    {
        private Clientes cln_model = new Clientes();
        private ClientesDao cln_Dao = new ClientesDao();
        private AltaClientes _ac;
        private VistaClientes _vc;

        MsgBox msg = new MsgBox();


        public AltaClientesController(AltaClientes ac)
        {
            _ac = ac;

        }

        public AltaClientesController(VistaClientes vc)
        {
            _vc = vc;
        }

        public void searchClientes(VistaClientes _vc)
        {
            cln_Dao.SearchClients(_vc.dgvClientes);
        }

        public void AltaClienteView()
        {
            AltaClientes AC = new AltaClientes(_vc);

            AC.ShowDialog();
        }

        public void AltaCliente()
        {

            cln_model.Nro_DNI = Convert.ToInt32(_ac.txtNroDocumento.Text);

            if (_ac.cmbBoxNroPF.Text != "" & _ac.cmbDigitoVerificador.Text != "")
            {
                cln_model.Nro_cuit = _ac.cmbBoxNroPF.Text + "-" + _ac.txtNroCuit.Text + "-" + _ac.cmbDigitoVerificador.Text;
            }
            else
            {
                cln_model.Nro_cuit = _ac.cmbBoxNroPF.Text + _ac.txtNroCuit.Text + _ac.cmbDigitoVerificador.Text;
            }

            cln_model.Nombre = _ac.txtNombre.Text;
            cln_model.Apellido = _ac.txtApellido.Text;
            cln_model.Domicilio = _ac.txtDomicilio.Text + "" + _ac.txtNroDomicilio.Text;
            cln_model.Telefono = _ac.txtPrefijoTelefono.Text + "-" + _ac.txtNroTelefono.Text;
            cln_model.Email = _ac.txtEmail.Text;
            cln_model.Condicion_IVA = _ac.cmbCondicionIVA.Text;
            cln_model.Fecha_Nacimiento = _ac.txtFechaNacimiento.Text;

            if (cln_Dao.InsertClient(cln_model))
            {

                msg.lblMsg.Text = "CLIENTE DADO DE ALTA CON EXITO!";

                msg.ShowDialog();

                Form.ActiveForm.Close();

            }


        }
        public void verificoDNI()
        {
            if (cln_Dao.selectCondicion("Clientes", "Nro_DNI = " + _ac.txtNroDocumento.Text) != false)
            {
                System.Windows.Forms.MessageBox.Show("EL DNI '" + _ac.txtNroDocumento.Text + "' YA PERTENECE A UN CLIENTE EXISTENTE!", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _ac.txtNroDocumento.Clear();
            }

        }
        public void verificoDNICuit()
        {
            if (cln_Dao.selectCondicion("Clientes", "Nro_DNI = " + _ac.txtNroCuit.Text) != false)
            {
                System.Windows.Forms.MessageBox.Show("EL DNI '" + _ac.txtNroCuit.Text + "' YA PERTENECE A UN CLIENTE EXISTENTE!", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _ac.txtNroCuit.Clear();
            }

        }
        public bool verificoTextboxsACeInsertoCliente()
        {
            if ((_ac.txtNroDocumento.Text != "") & (_ac.txtNombre.Text != "") & (_ac.txtApellido.Text != "") &
             (_ac.txtDomicilio.Text != "") & (_ac.txtNroDomicilio.Text != "") & (_ac.txtNroTelefono.Text != "") & (_ac.txtEmail.Text != "") &
             (_ac.txtFechaNacimiento.Text != ""))
            {
                if (_ac.cmbCondicionIVA.DataSource != null)
                {
                    if (_ac.cmbCondicionIVA.SelectedIndex == 1)
                    {
                        if ((_ac.cmbBoxNroPF.DataSource != null) & (_ac.cmbDigitoVerificador.DataSource != null) & (_ac.txtNroCuit.Text != ""))
                        {

                            if (_ac.txtNroDocumento.TextLength == 8)
                            {

                                var result = System.Windows.Forms.MessageBox.Show("DESEA DAR DEL ALTA NUEVO CLIENTE?", "ACTUALIZAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (result == DialogResult.Yes)
                                {
                                    AltaCliente();
                                    return true;
                                }
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("EL DNI DEBE CONTENER 8 NUMEROS!", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("DEBE COMPLETAR EL CUIT SI EL CLIENTE ES RESPONSABLE INSCRIPTO!", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    if (_ac.cmbCondicionIVA.SelectedIndex == 0)
                    {
                        if (_ac.txtNroDocumento.TextLength == 8)
                        {

                            var result = System.Windows.Forms.MessageBox.Show("DESEA DAR DEL ALTA NUEVO CLIENTE?", "ACTUALIZAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {
                                AltaCliente();
                                return true;
                            }
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("EL DNI DEBE CONTENER 8 NUMEROS!", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("SELECCIONE UNA CONDICION IVA DEL CLIENTE", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {

                System.Windows.Forms.MessageBox.Show("DEBE COMPLETAR TODOS LOS CAMPOS PARA PODER DAR DE ALTA AL CLIENTE!", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }



        public void habilitoCuit()
        {
            if (_ac.cmbCondicionIVA.SelectedIndex == 1)
            {
                _ac.txtNroCuit.Text = _ac.txtNroDocumento.Text;

                _ac.cmbBoxNroPF.Enabled = true;
                _ac.txtNroCuit.Enabled = true;
                _ac.cmbDigitoVerificador.Enabled = true;

            }
            else
            {
                _ac.cmbBoxNroPF.Text = "";
                _ac.txtNroCuit.Text = "";
                _ac.cmbDigitoVerificador.Text = "";
                _ac.cmbBoxNroPF.Enabled = false;
                _ac.txtNroCuit.Enabled = false;
                _ac.cmbDigitoVerificador.Enabled = false;
            }
        }

        private void VaciarDatos()
        {
            _ac.txtNroDocumento.Clear();
            _ac.cmbBoxNroPF.Text = "";
            _ac.cmbDigitoVerificador.Text = "";
            _ac.txtNroDomicilio.Clear();
            _ac.txtNroTelefono.Clear();
            _ac.txtNroCuit.Clear();
            _ac.txtNombre.Clear();
            _ac.txtApellido.Clear();
            _ac.txtDomicilio.Clear();
            _ac.txtNroTelefono.Clear();
            _ac.txtEmail.Clear();

        }

        public void Sololetras(KeyPressEventArgs e)
        {
            // Validacion de textbox para solo letras.

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO SE PUEDEN INGRESAR LETRAS.", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SoloNumeros(KeyPressEventArgs e)
        {
            // Validacion de textbox para solo letras.
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO SE PUEDEN INGRESAR NUMEROS.", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
