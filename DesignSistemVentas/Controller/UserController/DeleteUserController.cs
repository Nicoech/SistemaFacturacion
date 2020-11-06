using DesignSistemVentas.Model;
using DesignSistemVentas.ModelDao;
using DesignSistemVentas.View;
using DesignSistemVentas.View.UsuariosView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.UserController
{
    class DeleteUserController
    {
        private usuariosView _uv;
        private Usuarios _user_model = new Usuarios();
        private UserSessionDao _user_Dao = new UserSessionDao();
        MsgBox msg = new MsgBox();

        public DeleteUserController(usuariosView uv)
        {
            _uv = uv;
        }

        public void DeleteProducto()
        {

            if (_uv.dgvUsuarios.SelectedCells.Count > 0)
            {

                int selectedRowIndex = _uv.dgvUsuarios.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = _uv.dgvUsuarios.Rows[selectedRowIndex];

                _user_model.user_id = Convert.ToInt32(selectedRow.Cells["user_id"].Value);

                if (_user_Dao.selectCondicion("Users", "user_id = " + _user_model.user_id) == true)
                {
                    var result = System.Windows.Forms.MessageBox.Show("DESEA DAR DEL BAJA USUARIO?", "BAJA USUARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                            _user_Dao.DeleteProduct(_user_model);

                            msg.lblMsg.Text = "USUARIO ELIMINADO CON EXITO!";

                            msg.ShowDialog();

                            _user_Dao.SearchUsers(_uv.dgvUsuarios);
                    }

                }
            }

        }
    }
}
