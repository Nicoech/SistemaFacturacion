using DesignSistemVentas.Model;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.View;
using System;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.ProductosController
{
    class DeleteProductosController
    {

        private Productos prod_model = new Productos();
        private ProductosDao prod_Dao = new ProductosDao();
        private VistaProductos _dp;


        MsgBox msg = new MsgBox();

        public DeleteProductosController(VistaProductos dp)
        {
            _dp = dp;
        }

        public void DeleteProducto()
        {

            if (_dp.dgvProductos.SelectedCells.Count > 0)
            {

                int selectedRowIndex = _dp.dgvProductos.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = _dp.dgvProductos.Rows[selectedRowIndex];

                prod_model.ID_Producto = Convert.ToInt32(selectedRow.Cells["ID_Producto"].Value);

                if (prod_Dao.selectCondicion("DetalleFactura", "ID_Producto = " + prod_model.ID_Producto) == false)
                {

                    prod_Dao.DeleteProduct(prod_model);

                    msg.lblMsg.Text = "Producto eliminado con exito!";

                    msg.ShowDialog();

                    prod_Dao.SearchProducts(_dp.dgvProductos);
                }
                else
                {
                    MessageBox.Show("EL PRODUCTO QUE DESEA BORRAR ESTA RELACIONADO CON DOCUMENTACION DENTRO DEL SISTEMA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}
