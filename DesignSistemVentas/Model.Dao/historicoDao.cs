using DesignSistemVentas.ModelDao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesignSistemVentas.Model.Dao
{
    class historicoDao
    {
        private Conexion _objConexion;
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataTable dt = new DataTable();
        public SqlCommand comand = new SqlCommand();
        private DataSet ds = new DataSet();
        public historicoDao()
        {
            _objConexion = Conexion.validarConexion();
        }
        public void searchClientes(DataGridView Grid)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SP_SearchClientesHistorico", _objConexion.getConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);

                Grid.DataSource = dt;

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                               "INFORMACION : " + ex.Message);
            }

            finally
            {
                _objConexion.cerrarConexion();
            }

        }

        public DataTable searchFacturasByDNICliente(string buscoFacturas)
        {
            try
            {

                comand = new SqlCommand("SP_SearchFacturasHistoricoByDNI", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                comand.Parameters.Add("@dni", SqlDbType.VarChar).Value = buscoFacturas;
                comand.CommandType = CommandType.StoredProcedure;
                comand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    MessageBox.Show("No se encontraron facturas de este cliente!");
                    return dt;
                }



            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                               "INFORMACION : " + ex.Message);
                return dt;
            }
            finally
            {

                comand.Connection.Close();
                _objConexion.cerrarConexion();
            }

        }

        public DataTable searchFacturasByFechas(string buscoFacturas, DateTimePicker dtp, DateTimePicker dtp2)
        {
            try
            {
                string fechaInicial = string.Format("{0:d}", dtp.Value);

                string fechaLimite = string.Format("{0:d}", dtp2.Value);

                comand = new SqlCommand("SP_SearchFacturasHistoricoByDNIyFechas", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                comand.Parameters.Add("@dni", SqlDbType.VarChar).Value = buscoFacturas;
                comand.Parameters.Add("@fechainicial", SqlDbType.DateTime).Value = fechaInicial;
                comand.Parameters.Add("@fechafinal", SqlDbType.DateTime).Value = fechaLimite;
                comand.CommandType = CommandType.StoredProcedure;
                comand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    MessageBox.Show("No se encontraron facturas de este cliente!");
                    return dt;
                }



            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                               "INFORMACION : " + ex.Message);
                return dt;
            }
            finally
            {

                comand.Connection.Close();
                _objConexion.cerrarConexion();
            }

        }
    }
}
