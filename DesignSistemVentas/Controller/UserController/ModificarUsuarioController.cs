using DesignSistemVentas.Model;
using DesignSistemVentas.ModelDao;
using DesignSistemVentas.Utilities;
using DesignSistemVentas.View;
using DesignSistemVentas.View.UsuariosView;
using System;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.UserController
{
    class ModificarUsuarioController
    {
        private Usuarios _user_model = new Usuarios();
        private ModificarUsuarios _mu;
        private UserSessionDao _user_Dao = new UserSessionDao();
        private Constants C = new Constants();
        public usuariosView _uv;

        public ModificarUsuarioController(usuariosView uv)
        {
            _uv = uv;
        }

        public ModificarUsuarioController(ModificarUsuarios mu)
        {
            _mu = mu;
        }

        public void bindDataUsuarios(usuariosView _uv)
        {
            ModificarUsuarios mu = new ModificarUsuarios(_uv);

            mu.txtID.Text = _uv.dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            mu.txtNombreUsuario.Text = _uv.dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            mu.txtContraseña.Text = _uv.dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            mu.cmbCategoria.Text = _uv.dgvUsuarios.CurrentRow.Cells[3].Value.ToString() + "-" + _uv.dgvUsuarios.CurrentRow.Cells[4].Value.ToString();

            mu.ShowDialog();

        }

        public void traigoTiposUsuarios()
        {
            _user_Dao.getUserCategory(_mu.cmbCategoria);
        }
        public void traigoUsuarios(usuariosView _uv)
        {
            _user_Dao.SearchUsers(_uv.dgvUsuarios);
        }
        public void updateUsuario()
        {

            if ((_mu.txtNombreUsuario.Text != "") & (_mu.txtContraseña.Text != "") & (_mu.cmbCategoria.Text != ""))
            {
                _user_model.user_id = Convert.ToInt32(_mu.txtID.Text);
                _user_model.username = _mu.txtNombreUsuario.Text;
                _user_model.password = _mu.txtContraseña.Text;
                _user_model.categoria = Convert.ToInt32(obtengoIDCategoriaString(_mu.cmbCategoria.Text));

                if (_user_Dao.updateUser(_user_model))
                {
                    MsgBox msg = new MsgBox();

                    msg.lblMsg.Text = "USUARIO MODIFICADO CON EXITO!";

                    msg.ShowDialog();

                    Form.ActiveForm.Close();

                }
            }
            else
            {
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS PARA PODER CREAR UN USUARIO!", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }


        public string obtengoIDCategoriaString(string a)
        {

            string guardo = string.Empty;


            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsNumber(a[i]))
                {
                    guardo += a[i];
                }
            }

            if (guardo.Length > 0) a = guardo;
            return a;
        }

        public void muestroPassword(TextBox txt, CheckBox cb)
        {
            string text = txt.Text;

            if (cb.Checked)
            {
                txt.UseSystemPasswordChar = false;
                txt.Text = text;

            }
            else
            {
                txt.UseSystemPasswordChar = true;
                txt.Text = text;
            }
        }
    }
}
