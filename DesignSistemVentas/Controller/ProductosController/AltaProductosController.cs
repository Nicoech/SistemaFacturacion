using DesignSistemVentas.Model;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.View;
using DesignSistemVentas.View.ProductosViews;
using System;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller
{
    public class AltaProductosController
    {
        private Productos prod_model = new Productos();
        private ProductosDao prod_Dao = new ProductosDao();
        private AltaProductos _ap;
        private VistaProductos _vp;

        MsgBox msg = new MsgBox();

        public AltaProductosController(VistaProductos vp)
        {
            _vp = vp;
        }
        public AltaProductosController(AltaProductos ap)
        {
            _ap = ap;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------

        //FUNCIONES DEL CONTROLADOR
        public void AltaProducto()
        {

            prod_model.ID_Producto = Convert.ToInt32(_ap.txtID_Prod.Text);

            prod_model.Descripcion = _ap.txtDescripcion.Text;
            prod_model.Precio_Unit = Convert.ToDecimal(_ap.txtPrecio.Text);
            prod_model.Stock_Act = Convert.ToInt32(_ap.txtStockAct.Text);
            prod_model.Stock_Min = Convert.ToInt32(_ap.txtStockMin.Text);
            prod_model.Cod_Producto = Convert.ToString(_ap.txtCodProd.Text);
            if (_ap.cmbCategoria.Text != "")
            {
                prod_model.Categoria = Convert.ToInt32(obtengoIDCategoriaString(_ap.cmbCategoria.Text));
            }


            if (prod_Dao.InsertProducto(prod_model))
            {
                MsgBox msg = new MsgBox();

                msg.lblMsg.Text = "PRODUCTO INGRESADO CON EXITO!";

                msg.ShowDialog();


                VaciarDatos();
            }
            Form.ActiveForm.Close();

        }
        public void AltaProductoView()
        {
            AltaProductos AP = new AltaProductos(_vp);
            AP.ShowDialog();
        }
        public void searchProductsIntoDb(VistaProductos _vp)
        {
            prod_Dao.SearchProducts(_vp.dgvProductos);
        }

        public void obtengoID_NuevoProducto()
        {
            _ap.txtID_Prod.Text = prod_Dao.obtengoNroProducto().ToString();
        }
        private void VaciarDatos()
        {
            _ap.txtID_Prod.Clear();
            _ap.txtDescripcion.Clear();
            _ap.txtPrecio.Clear();
            _ap.txtStockAct.Clear();
            _ap.txtStockMin.Clear();
        }

        public void traigoCategoriaProductos()
        {
            prod_Dao.getProductCategories(_ap.cmbCategoria);
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
            if (char.IsNumber(e.KeyChar) || (char.IsLetter(e.KeyChar)))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                System.Windows.Forms.MessageBox.Show("SOLO SE PUEDEN INGRESAR NUMEROS Y LETRAS.");
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
    }
}

