using DesignSistemVentas.Model;
using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.View;
using System;
using System.Data;
using System.Windows.Forms;

namespace DesignSistemVentas.Controller.ClientesController
{
    class DeleteClientesController
    {
        private VistaClientes _vc;
        private Clientes cln_model = new Clientes();
        private ClientesDao cln_Dao = new ClientesDao();

        DataTable dt = new DataTable();

        MsgBox msg = new MsgBox();

        public DeleteClientesController(VistaClientes vc)
        {
            _vc = vc;
        }
        public void DeleteClient(DataGridView dgv)
        {
            if (dgv.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv.Rows[selectedrowindex];

                cln_model.Id_cliente = Convert.ToInt32(selectedRow.Cells["ID_Cliente"].Value);

                if (cln_Dao.selectCondicion("EncabezadoFactura", "ID_Cliente = " + cln_model.Id_cliente) == false)
                {

                    cln_Dao.DeleteClient(cln_model);

                    msg.lblMsg.Text = "Cliente eliminado con exito!";

                    msg.ShowDialog();

                    cln_Dao.SearchClients(dgv);

                }
                else
                {
                    MessageBox.Show("EL CLIENTE QUE DESEA BORRAR ESTA RELACIONADO CON DOCUMENTACION DENTRO DEL SISTEMA!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }

        }
    }
}
