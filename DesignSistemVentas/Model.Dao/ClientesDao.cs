using DesignSistemVentas.ModelDao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesignSistemVentas.Model.Dao
{
    class ClientesDao
    {
        private Conexion _objConexion;
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataTable dt = new DataTable();
        public SqlCommand comand = new SqlCommand();
        private DataSet ds = new DataSet();
        public ClientesDao()
        {
            _objConexion = Conexion.validarConexion();

        }


        public bool InsertClient(Clientes cliente)
        {
            int insertaRegistro = 0;
            try
            {

                SqlCommand _comand = new SqlCommand("SP_InsertClient", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@Nro_DNI", SqlDbType.Int).Value = cliente.Nro_DNI;
                _comand.Parameters.Add("@Nro_cuit", SqlDbType.VarChar).Value = cliente.Nro_cuit;
                _comand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = cliente.Nombre;
                _comand.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = cliente.Apellido;
                _comand.Parameters.Add("@Domicilio", SqlDbType.VarChar).Value = cliente.Domicilio;
                _comand.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = cliente.Telefono;
                _comand.Parameters.Add("@Email", SqlDbType.VarChar).Value = cliente.Email;
                _comand.Parameters.Add("@Condicion_IVA", SqlDbType.VarChar).Value = cliente.Condicion_IVA;
                _comand.Parameters.Add("@Fecha_Nacimiento", SqlDbType.Date).Value = cliente.Fecha_Nacimiento;

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
        public bool UpdateClient(Clientes cliente)
        {
            int insertaRegistro = 0;
            try
            {

                SqlCommand _comand = new SqlCommand("SP_UpdateClients", _objConexion.getConexion());
                _objConexion.getConexion().Open();

                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@id", SqlDbType.Int).Value = cliente.Id_cliente;
                _comand.Parameters.Add("@Nro_DNI", SqlDbType.Decimal).Value = cliente.Nro_DNI;
                _comand.Parameters.Add("@Nro_cuit", SqlDbType.VarChar).Value = cliente.Nro_cuit;
                _comand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = cliente.Nombre;
                _comand.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = cliente.Apellido;
                _comand.Parameters.Add("@Domicilio", SqlDbType.VarChar).Value = cliente.Domicilio;
                _comand.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = cliente.Telefono;
                _comand.Parameters.Add("@Email", SqlDbType.VarChar).Value = cliente.Email;
                _comand.Parameters.Add("@Condicion_IVA", SqlDbType.VarChar).Value = cliente.Condicion_IVA;
                _comand.Parameters.Add("@Fecha_Nacimiento", SqlDbType.Date).Value = cliente.Fecha_Nacimiento;

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
        public bool DeleteClient(Clientes cliente)
        {
            int insertaRegistro = 0;
            try
            {
                SqlCommand _comand = new SqlCommand("SP_DeleteClients", _objConexion.getConexion());
                _objConexion.getConexion().Open();

                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@id", SqlDbType.Int).Value = cliente.Id_cliente;

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
        public void SearchClients(DataGridView Grid)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SearchClients", _objConexion.getConexion());
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
        public void SearchClientsByIDorDNI(DataGridView Grid, string buscoCliente)
        {
            try
            {

                comand = new SqlCommand("SP_SearchClientByIDorDNI", _objConexion.getConexion());
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
                    ExecuteQuery(sb.ToString(), "Clientes");

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
