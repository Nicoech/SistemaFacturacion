using DesignSistemVentas.Model;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.Utilities;
using DesignSistemVentas.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.ClientesController
{
    class ModificacionClientesController
    {
        private Clientes cln_model = new Clientes();
        private ClientesDao cln_Dao = new ClientesDao();
        private ModificacionClientes _mc;
        private VistaClientes _vc;
        Constants c = new Constants();
        MsgBox msg = new MsgBox();

        public ModificacionClientesController(VistaClientes vc)
        {
            _vc = vc;

        }

        public ModificacionClientesController(ModificacionClientes mc)
        {
            _mc = mc;
        }

        public void searchClientes(VistaClientes _vc)
        {
            cln_Dao.SearchClients(_vc.dgvClientes);
        }

        public void UpdateCliente()
        {
            cln_model.Id_cliente = Convert.ToInt32(_mc.txtID_C.Text);
            cln_model.Nro_DNI = Convert.ToInt32(_mc.txtNroDocumento.Text);

            if (_mc.cmbBoxNroPF.Text != "" & _mc.cmbDigitoVerificador.Text != "")
            {
                cln_model.Nro_cuit = _mc.cmbBoxNroPF.Text + "-" + _mc.txtNroCuit.Text + "-" + _mc.cmbDigitoVerificador.Text;
            }
            else
            {
                cln_model.Nro_cuit = _mc.cmbBoxNroPF.Text + _mc.txtNroCuit.Text + _mc.cmbDigitoVerificador.Text;
            }

            cln_model.Nombre = _mc.txtNombre.Text;
            cln_model.Apellido = _mc.txtApellido.Text;
            cln_model.Domicilio = _mc.txtDomicilio.Text + " " + _mc.txtNroDomicilio.Text;
            cln_model.Telefono = _mc.txtNroTelefono.Text;
            cln_model.Email = _mc.txtEmail.Text;
            cln_model.Condicion_IVA = _mc.cmbCondicionIVA.Text;
            cln_model.Fecha_Nacimiento = _mc.txtFechaNacimiento.Text;

            if (cln_Dao.UpdateClient(cln_model))
            {

                msg.lblMsg.Text = "CLIENTE MODIFICADO CON EXITO!";

                msg.ShowDialog();

                Form.ActiveForm.Close();
            }

        }
        public bool verificoTextBoxsMC()
        {
            if ((_mc.txtNroDocumento.Text != "") & (_mc.txtNombre.Text != "") & (_mc.txtApellido.Text != "") &
                    (_mc.txtDomicilio.Text != "") & (_mc.txtNroDomicilio.Text != "") & (_mc.txtNroTelefono.Text != "") & (_mc.txtEmail.Text != "") &
                    (_mc.txtFechaNacimiento.Text != ""))
            {
                if (_mc.cmbCondicionIVA.Text != "")
                {
                    if (_mc.cmbCondicionIVA.SelectedIndex == 1)
                    {
                        if ((_mc.cmbBoxNroPF.DataSource != null) & (_mc.cmbDigitoVerificador.DataSource != null) & (_mc.txtNroCuit.Text != ""))
                        {

                            if (_mc.txtNroDocumento.TextLength == 8)
                            {

                                var result = System.Windows.Forms.MessageBox.Show("DESEA MODIFICAR CLIENTE?", "ACTUALIZAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (result == DialogResult.Yes)
                                {
                                    UpdateCliente();
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

                    if (_mc.cmbCondicionIVA.SelectedIndex == 0)
                    {
                        if (_mc.txtNroDocumento.TextLength == 8)
                        {

                            var result = System.Windows.Forms.MessageBox.Show("DESEA MODIFICAR CLIENTE?", "ACTUALIZAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {
                                UpdateCliente();
                                return true;
                            }
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("EL DNI DEBE CONTENER 8 NUMEROS!", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    if (_mc.cmbCondicionIVA.SelectedIndex == -1)
                    {
                        if (_mc.txtNroDocumento.TextLength == 8)
                        {

                            var result = System.Windows.Forms.MessageBox.Show("DESEA MODIFICAR CLIENTE?", "ACTUALIZAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {
                                UpdateCliente();
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

 
        public void bindDataCliente()
        {
            ModificacionClientes mc = new ModificacionClientes(_vc);

            mc.txtID_C.Text = _vc.dgvClientes.CurrentRow.Cells[0].Value.ToString();
            mc.txtNroDocumento.Text = _vc.dgvClientes.CurrentRow.Cells[1].Value.ToString();

            mc.cmbBoxNroPF.Text = obtengoPrefijoCuitString(_vc.dgvClientes.CurrentRow.Cells[2].Value.ToString());
            mc.txtNroCuit.Text = obtengoCuitString(_vc.dgvClientes.CurrentRow.Cells[2].Value.ToString());
            mc.cmbDigitoVerificador.Text = obtengoDigitoCuitString(_vc.dgvClientes.CurrentRow.Cells[2].Value.ToString());

            mc.txtNombre.Text = _vc.dgvClientes.CurrentRow.Cells[3].Value.ToString();
            mc.txtApellido.Text = _vc.dgvClientes.CurrentRow.Cells[4].Value.ToString();
            mc.txtDomicilio.Text = obtengoLetrasString(_vc.dgvClientes.CurrentRow.Cells[5].Value.ToString());
            mc.txtNroDomicilio.Text = obtengoNumerosString(_vc.dgvClientes.CurrentRow.Cells[5].Value.ToString());

            mc.txtNroTelefono.Text = _vc.dgvClientes.CurrentRow.Cells[6].Value.ToString();

            mc.txtEmail.Text = _vc.dgvClientes.CurrentRow.Cells[7].Value.ToString();

            mc.cmbCondicionIVA.Text = _vc.dgvClientes.CurrentRow.Cells[8].Value.ToString();

            string a = _vc.dgvClientes.CurrentRow.Cells[9].Value.ToString().Substring(0, 11);
            int p = a.IndexOf(" ");
            mc.txtFechaNacimiento.Text = _vc.dgvClientes.CurrentRow.Cells[9].Value.ToString().Substring(0, p);


            mc.ShowDialog();

        }


        public void habilitoCuit()
        {
            if (_mc.cmbCondicionIVA.SelectedIndex == 1)
            {
                _mc.txtNroCuit.Text = _mc.txtNroDocumento.Text;
                _mc.cmbBoxNroPF.Enabled = true;
                _mc.txtNroCuit.Enabled = true;
                _mc.cmbDigitoVerificador.Enabled = true;

            }
            else
            {
                _mc.cmbBoxNroPF.Text = "";
                _mc.txtNroCuit.Text = "";
                _mc.cmbDigitoVerificador.Text = "";
                _mc.cmbBoxNroPF.Enabled = false;
                _mc.txtNroCuit.Enabled = false;
                _mc.cmbDigitoVerificador.Enabled = false;
            }
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
                System.Windows.Forms.MessageBox.Show("SOLO SE PUEDEN INGRESAR LETRAS.");
            }
        }

        public string obtengoLetrasString(string a)
        {

            string guardo = string.Empty;

            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsLetter(a[i]))
                    guardo += a[i];
                if (Char.IsWhiteSpace(a[i]))
                    guardo += a[i];

            }

            if (guardo.Length > 0)
            {
                a = guardo;
            }


            return a;
        }

        public string obtengoCuitString(string a)
        {

            string guardo = string.Empty;


            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsNumber(a[i]) & (i > 2) & (i < 11))
                {
                    guardo += a[i];
                }
            }

            if (guardo.Length > 0) a = guardo;
            return a;
        }
        public string obtengoPrefijoCuitString(string a)
        {

            string guardo = string.Empty;


            for (int i = 0; i < a.Length; i++)
            {
                if (i < 2)
                {
                    if (Char.IsNumber(a[i]))
                    {
                        guardo += a[i];
                    }
                }
            }

            if (guardo.Length > 0) a = guardo;
            return a;
        }
        public string obtengoDigitoCuitString(string a)
        {

            string guardo = string.Empty;


            for (int i = 0; i < a.Length; i++)
            {
                if (i > 11)
                {
                    if (Char.IsNumber(a[i]))
                    {
                        guardo += a[i];
                    }
                }
            }

            if (guardo.Length > 0) a = guardo;
            return a;
        }

        public string obtengoNumerosString(string a)
        {

            int val = 0;
            string guardo = string.Empty;

            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsDigit(a[i]))
                    guardo += a[i];
            }

            if (guardo.Length > 0)
                val = int.Parse(guardo);
            a = val.ToString();

            return a;
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
                System.Windows.Forms.MessageBox.Show("SOLO SE PUEDEN INGRESAR NUMEROS.");
            }
        }

    }
}
