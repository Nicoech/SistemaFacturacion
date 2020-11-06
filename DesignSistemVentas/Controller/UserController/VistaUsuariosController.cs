using DesignSistemVentas.ModelDao;
using DesignSistemVentas.View.UsuariosView;

namespace DesignSistemVentas.Controller.UsuariosController
{
    class VistaUsuariosController
    {
        private UserSessionDao _user_dao;
        private AltaUsuarios _au;
        private usuariosView _uv;
        public VistaUsuariosController(UserSessionDao user_dao)
        {
            _user_dao = user_dao;
            _user_dao = new UserSessionDao();
        }

        public VistaUsuariosController(AltaUsuarios au)
        {
            _au = au;
            _user_dao = new UserSessionDao();
        }

        public VistaUsuariosController(usuariosView uv)
        {
            _uv = uv;
            _user_dao = new UserSessionDao();
        }

        public void traigoCategoriasUsuarios()
        {
            _user_dao.getUserCategory(_au.cmbCategoria);
        }

        public void traigoUsuarios()
        {
            _user_dao.SearchUsers(_uv.dgvUsuarios);
        }

    }
}
