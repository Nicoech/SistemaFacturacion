using DesignSistemVentas.Model;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.View;
using DesignSistemVentas.View.ProductosViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.CategoriaProductosController
{
    class categoriaProductosController
    {
        private CategoriaProductos catProdModel = new CategoriaProductos();
        private AltaCategoriaProducto _acp;
        private ProductosDao prod_Dao = new ProductosDao();
        public categoriaProductosController(AltaCategoriaProducto acp)
        {
            _acp = acp;
        }

        public void AltaCategoriaController()
        {
            catProdModel.ID_Categoria = Convert.ToInt32(_acp.txtIDCategoria.Text);

            if (_acp.txtDescripcion.Text != "")
            {
                catProdModel.Descripcion = _acp.txtDescripcion.Text;

                if (prod_Dao.insertCategoria(catProdModel))
                {
                    MsgBox msg = new MsgBox();

                    msg.lblMsg.Text = "CATEGORIA INGRESADA CON EXITO!";

                    msg.ShowDialog();


                    VaciarDatos();
                }
                Form.ActiveForm.Close();
            } else
            {
                MessageBox.Show("AGREGE UNA DESCRIPCION A LA CATEGORIA");
            }




        }

        public void obtengoIDCategoria()
        {
            _acp.txtIDCategoria.Text = prod_Dao.obtengoIDCategoria().ToString();
        }
        public void VaciarDatos()
        {
            _acp.txtIDCategoria.Clear();
            _acp.txtDescripcion.Clear();
        }
    }
}
