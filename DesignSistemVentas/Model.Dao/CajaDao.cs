using DesignSistemVentas.ModelDao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesignSistemVentas.Model.Dao
{
    class CajaDao
    {
        private Conexion _objConexion;
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataTable dt = new DataTable();
        public SqlCommand comand = new SqlCommand();
        private DataSet ds = new DataSet();

        public CajaDao()
        {
            _objConexion = Conexion.validarConexion();
        }
        public int obtengoNroPlanilla()
        {
            int nroPlanilla = 0;
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SP_generoNumeroPlanilla", _objConexion.getConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                nroPlanilla = int.Parse(dt.Rows[0]["Nro_Planilla"].ToString());

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
            return nroPlanilla;
        }

        public bool InsertMovimientoCaja(Caja caja)
        {
            int insertaRegistro = 0;
            try
            {

                SqlCommand _comand = new SqlCommand("SP_InsertMovimientoCaja", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                _comand.CommandType = CommandType.StoredProcedure;

                _comand.Parameters.Add("@Movimiento", SqlDbType.VarChar).Value = caja.Tipo;
                _comand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = caja.Descripcion;
                _comand.Parameters.Add("@Detalle", SqlDbType.VarChar).Value = caja.Detalle;
                _comand.Parameters.Add("@Importe", SqlDbType.Decimal).Value = caja.Valor;
                _comand.Parameters.Add("@Fecha", SqlDbType.Date).Value = caja.Fecha;

                insertaRegistro = _comand.ExecuteNonQuery();
                _comand.Connection.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                                "INFORMACION : " + ex.Message);
                _objConexion.cerrarConexion();
            }
            finally
            {

                _objConexion.cerrarConexion();

            }
            if (insertaRegistro > 0) return true;
            else return false;

        }

        public bool UpdateMovimientoCaja(Caja caja)
        {
            int insertaRegistro = 0;
            try
            {

                SqlCommand _comand = new SqlCommand("SP_UpdateMovimientoCaja", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                _comand.CommandType = CommandType.StoredProcedure;

                _comand.Parameters.Add("@Nro_Planilla", SqlDbType.Int).Value = caja.Nro_Planilla;
                _comand.Parameters.Add("@Movimiento", SqlDbType.VarChar).Value = caja.Tipo;
                _comand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = caja.Descripcion;
                _comand.Parameters.Add("@Detalle", SqlDbType.VarChar).Value = caja.Detalle;
                _comand.Parameters.Add("@Importe", SqlDbType.Decimal).Value = caja.Valor;
                _comand.Parameters.Add("@Fecha", SqlDbType.Date).Value = caja.Fecha;

                insertaRegistro = _comand.ExecuteNonQuery();
                _comand.Connection.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                                "INFORMACION : " + ex.Message);
                _objConexion.cerrarConexion();
            }
            finally
            {

                _objConexion.cerrarConexion();

            }
            if (insertaRegistro > 0) return true;
            else return false;

        }

        public bool deleteMovimientoCaja(Caja caja)
        {
            int insertaRegistro = 0;
            try
            {
                SqlCommand _comand = new SqlCommand("SP_DeleteMovimientoCaja", _objConexion.getConexion());
                _objConexion.getConexion().Open();

                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@Nro_Planilla", SqlDbType.Int).Value = caja.Nro_Planilla;

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
        public bool searchCaja(DataGridView Grid)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SP_SearchMovimientosCaja", _objConexion.getConexion());
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
        public bool searchClientesCaja(DataGridView Grid)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SP_SearchClientesCaja", _objConexion.getConexion());
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


        public DataTable searchMovimientosbyFiltro(string a)
        {
            try
            {

                comand = new SqlCommand("SP_SearchMovimientosbyFiltro", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                comand.Parameters.Add("@filtro", SqlDbType.VarChar).Value = a;
                comand.CommandType = CommandType.StoredProcedure;
                comand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
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
            return dt;
        }

        public DataTable searchMovimientosbyFecha(DateTimePicker dtp, DateTimePicker dtp2)
        {
            try
            {
                string fechaInicial = string.Format("{0:d}", dtp.Value);

                string fechaLimite = string.Format("{0:d}", dtp2.Value);

                comand = new SqlCommand("SP_SearchMovimientosbyFechas", _objConexion.getConexion());
                _objConexion.getConexion().Open();
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
                    MessageBox.Show("No se encontraron Movimientos!");
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

        public bool selectCondicion(string tabla, string condicion)

        {
            try
            {
                DataTable dt = new DataTable();
                string sb = string.Format("SELECT * FROM {0} WHERE {1}", tabla, condicion);

                if (condicion == "")
                {
                    System.Windows.Forms.MessageBox.Show("Casillero vacio");
                }
                else
                {
                    ExecuteQuery(sb.ToString(), "Caja");

                    consultaFilas(sb.ToString(), dt);

                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool ExecuteQuery(string query, string tabla)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, _objConexion.getConexion());
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Fill(ds, tabla);
                return true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error de consulta");
                return false;
            }

        }


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
    }
}
