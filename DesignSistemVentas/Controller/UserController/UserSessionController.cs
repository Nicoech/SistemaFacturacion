using DesignSistemVentas.Model;
using DesignSistemVentas.ModelDao;
using DesignSistemVentas.Properties;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller
{
    class UserSessionController
    {
        private UserSessionModel _user = new UserSessionModel();
        private UserSessionDao _userDao = new UserSessionDao();
        private VentanaPrincipal _vp;

        public UserSessionController(VentanaPrincipal vp)
        {
            _vp = vp;
        }

        public string Login(TextBox userName, TextBox pass)
        {

            _user.Username = userName.Text;
            _user.Password = pass.Text;


            if (_userDao.getUserSession(_user))
            {
                int userID = _user.User_ID;

                VentanaPrincipal vp = new VentanaPrincipal(_user);

                Form.ActiveForm.Hide();

                vp.ShowDialog();


            }
            return _user.Username.ToString();
        }

        public void setViewToSellerUser()
        {
            _vp.btnCrearUsuario.Visible = false;
        }

        public void cierroSesion()
        {
            if (MessageBox.Show("¿DESEA SALIR?", "SALIR DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                LoginForm lf = new LoginForm();

                Form.ActiveForm.Close();

                lf.ShowDialog();

            }
        }
    }
}

