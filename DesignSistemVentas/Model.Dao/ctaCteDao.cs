using DesignSistemVentas.ModelDao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesignSistemVentas.Model.Dao
{
    class ctaCteDao
    {

        private Conexion _objConexion;
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataTable dt = new DataTable();
        public SqlCommand comand = new SqlCommand();
        private DataSet ds = new DataSet();

        public ctaCteDao()
        {
            _objConexion = Conexion.validarConexion();
        }


        public bool searchClientesCtaCte(DataGridView Grid)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SP_SearchClientesParaCtaCte", _objConexion.getConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);

                Grid.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                               "INFORMACION : " + ex.Message);
                return false;
            }

            finally
            {
                _objConexion.cerrarConexion();
            }
        }

        public DataTable searchFacturasByIDCliente(string buscoCliente)
        {
            try
            {

                comand = new SqlCommand("SP_searchFacturasByIDCliente", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                comand.Parameters.Add("@filtro", SqlDbType.VarChar).Value = buscoCliente;
                comand.CommandType = CommandType.StoredProcedure;
                comand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(dt);

                return dt;


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
        //----------------------------------------------------------------------------------------------------------------
        public void SearchClientsByIDorDNI(DataGridView Grid, string buscoCliente)
        {
            try
            {

                comand = new SqlCommand("SP_SearchClientByIDorNombre", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                comand.Parameters.Add("@filtro", SqlDbType.VarChar).Value = buscoCliente;
                comand.CommandType = CommandType.StoredProcedure;
                comand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comand);
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

                comand.Connection.Close();
                _objConexion.cerrarConexion();
            }
        }
        //----------------------------------------------------------------------------------------------------------------
        public string consultaFilas(string query, DataTable tabla)
        {
            string s = "OK";
            try
            {
                comand.CommandText = query;
                comand.CommandType = CommandType.Text;
                comand.Connection = _objConexion.getConexion();
                da.SelectCommand = comand;
                da.Fill(tabla);
                return s;
            }
            catch (Exception ex)
            {
                s = ex.Message;
                return s;
            }

        }
        public string searchSaldoByFactura(string nroFac, string txt)
        {
            try
            {

                comand = new SqlCommand("SP_searchSaldoByFactura", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                comand.Parameters.Add("@filtro", SqlDbType.VarChar).Value = nroFac;
                comand.CommandType = CommandType.StoredProcedure;
                //comand.ExecuteNonQuery();


                SqlDataReader dr = comand.ExecuteReader();

                if (dr.Read())
                {
                    txt = dr["Saldo"].ToString();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("NO SE ENCONTRO SALDO DEUDOR RELACIONADO A LA FACTURA");
                }


                return txt;

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                               "INFORMACION : " + ex.Message);
                return txt;
            }
            finally
            {

                comand.Connection.Close();
                _objConexion.cerrarConexion();
            }

        }
        public DataTable searchFacturaCuotas(string buscoFactura, DataGridView Grid)
        {
            try
            {

                comand = new SqlCommand("SP_searchFacturaCuotasCC", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                comand.Parameters.Add("@filtro", SqlDbType.VarChar).Value = buscoFactura;
                comand.CommandType = CommandType.StoredProcedure;
                comand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(dt);
                Grid.DataSource = dt;

                return dt;
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
        public bool UpdateSaldoCtaCte(cuentaCorriente CC)
        {
            int insertaRegistro = 0;
            try
            {

                SqlCommand _comand = new SqlCommand("UpdateCuentaCorriente", _objConexion.getConexion());
                _objConexion.getConexion().Open();

                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@Nro_Fac", SqlDbType.Int).Value = CC.Nro_Factura;
                _comand.Parameters.Add("@Saldo", SqlDbType.Decimal).Value = CC.Saldo;

                insertaRegistro = _comand.ExecuteNonQuery();

                _comand.Connection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                               "INFORMACION : " + ex.Message);
                _objConexion.getConexion().Close();
            }
            finally
            {

                _objConexion.cerrarConexion();

            }
            if (insertaRegistro > 0) return true;
            else return false;

        }
        public bool UpdateEstadoCuota(cuentaCorriente CC)
        {
            int insertaRegistro = 0;
            try
            {

                SqlCommand _comand = new SqlCommand("UpdateFacturaCuota", _objConexion.getConexion());
                _objConexion.getConexion().Open();

                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@Nro_Fac", SqlDbType.Int).Value = CC.Nro_Factura;
                _comand.Parameters.Add("@NroCuota", SqlDbType.Int).Value = CC.Nro_Cuota;
                _comand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = CC.Estado;

                insertaRegistro = _comand.ExecuteNonQuery();

                _comand.Connection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                               "INFORMACION : " + ex.Message);
                _objConexion.getConexion().Close();
            }
            finally
            {

                _objConexion.cerrarConexion();

            }
            if (insertaRegistro > 0) return true;
            else return false;

        }
    }
}
