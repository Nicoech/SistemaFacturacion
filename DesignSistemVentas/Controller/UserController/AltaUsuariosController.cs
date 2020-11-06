using DesignSistemVentas.Model;
using DesignSistemVentas.ModelDao;
using DesignSistemVentas.View;
using DesignSistemVentas.View.UsuariosView;
using System;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.UserController
{
    class AltaUsuariosController
    {

        private Usuarios user_model = new Usuarios();
        private UserSessionDao user_dao = new UserSessionDao();
        private AltaUsuarios _au;
        private usuariosView _uv;

        MsgBox msg = new MsgBox();

        public AltaUsuariosController(AltaUsuarios au)
        {
            _au = au;
        }
        public AltaUsuariosController(usuariosView uv)
        {
            _uv = uv;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------

        //FUNCIONES DEL CONTROLADOR
        public void AltaUsuario()
        {

            if ((_au.txtNombreUsuario.Text != "") & (_au.txtContraseña.Text != "") & (_au.cmbCategoria.Text != ""))
            {
                user_model.username = _au.txtNombreUsuario.Text;
                user_model.password = _au.txtContraseña.Text;
                user_model.categoria = Convert.ToInt32(obtengoIDCategoriaString(_au.cmbCategoria.Text));

                var result = System.Windows.Forms.MessageBox.Show("DESEA DAR DEL ALTA USUARIO?", "ALTA USUARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (user_dao.InsertUser(user_model))
                    {
                        MsgBox msg = new MsgBox();

                        msg.lblMsg.Text = "USUARIO CREADO CON EXITO!";

                        msg.ShowDialog();

                        Form.ActiveForm.Close();
                    }
                }
                else
                {
                    MessageBox.Show("COMPLETE TODOS LOS CAMPOS PARA PODER CREAR UN USUARIO!", "MSJ DE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }

        public void traigoUsuarios(usuariosView _uv)
        {
            user_dao.SearchUsers(_uv.dgvUsuarios);
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
