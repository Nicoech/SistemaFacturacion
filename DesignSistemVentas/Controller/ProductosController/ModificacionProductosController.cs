using DesignSistemVentas.Model;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.View;
using DesignSistemVentas.View.ProductosViews;
using EO.Internal;
using System;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.ProductosController
{
    class ModificacionProductosController
    {
        private Productos prod_model = new Productos();
        private ProductosDao prod_Dao = new ProductosDao();
        private ModificacionesProductos _mp;
        private VistaProductos _vp;

        MsgBox msg = new MsgBox();

        public ModificacionProductosController(VistaProductos vp)
        {
            _vp = vp;
        }

        public ModificacionProductosController(ModificacionesProductos mp)
        {
            _mp = mp;
        }

        public void traigoCategoriaProductos()
        {
            prod_Dao.getProductCategories(_mp.cmbCategoria);
        }
        public void UpdateProducto()
        {

            prod_model.ID_Producto = Convert.ToInt32(_mp.txtID_P.Text);
            prod_model.Descripcion = _mp.txtDescripcion.Text;
            prod_model.Precio_Unit = Convert.ToDecimal(_mp.txtPrecio.Text);
            prod_model.Stock_Act = Convert.ToInt32(_mp.txtCantidadAct.Text);
            prod_model.Stock_Min = Convert.ToInt32(_mp.txtCantidadMin.Text);
            prod_model.Cod_Producto = _mp.txtCodProd.Text;
            if(_mp.cmbCategoria.Text != "")
            {
                prod_model.Categoria = Convert.ToInt32(obtengoIDCategoriaString(_mp.cmbCategoria.Text));
            }

            if (prod_Dao.UpdateProduct(prod_model))
            {

                msg.lblMsg.Text = "PRODUCTO MODIFICADO CON EXITO!";

                msg.ShowDialog();

            }

            Form.ActiveForm.Close();


        }
        public void searchProductsIntoDb(VistaProductos _vp)
        {
            prod_Dao.SearchProducts(_vp.dgvProductos);
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
        public void bindDataProducto()
        {
            ModificacionesProductos mp = new ModificacionesProductos(_vp);


            mp.txtID_P.Text = _vp.dgvProductos.CurrentRow.Cells[0].Value.ToString();
            mp.txtDescripcion.Text = _vp.dgvProductos.CurrentRow.Cells[1].Value.ToString();
            mp.txtPrecio.Text = _vp.dgvProductos.CurrentRow.Cells[2].Value.ToString().Replace('.', ',');
            mp.txtCantidadAct.Text = _vp.dgvProductos.CurrentRow.Cells[3].Value.ToString();
            mp.txtCantidadMin.Text = _vp.dgvProductos.CurrentRow.Cells[4].Value.ToString();
            mp.txtCodProd.Text = _vp.dgvProductos.CurrentRow.Cells[5].Value.ToString();
            mp.cmbCategoria.Text = _vp.dgvProductos.CurrentRow.Cells[6].Value.ToString();


            mp.ShowDialog();
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
        public void SoloNumerosyLetras(KeyPressEventArgs e)
        {
            // Validacion de textbox para solo letras.
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar))
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
        public void NumerosConComa(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 44)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }

        }
    }
}
