using DesignSistemVentas.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesignSistemVentas.ModelDao
{
    class UserSessionDao
    {
        private Conexion _objConexion;
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataTable dt = new DataTable();
        public SqlCommand comand = new SqlCommand();
        private DataSet ds = new DataSet();
        public UserSessionDao()
        {
            _objConexion = Conexion.validarConexion();
        }

        public bool getUserSession(UserSessionModel user)
        {
            bool validoRegistro = false;

            string query = "SELECT us.user_id, us.username, us.password,uc.tipo_usuario,uc.categoria_id FROM Users us INNER JOIN User_Category" +
                           " uc on us.categoria_id = uc.categoria_id where username = '" + user.Username + "' and password = '" + user.Password + "'";

            try
            {
                var command = new SqlCommand(query, _objConexion.getConexion());


                _objConexion.getConexion().Open();

                SqlDataReader read = command.ExecuteReader();
                validoRegistro = read.Read();


                if (validoRegistro)
                {
                    user.User_ID = Convert.ToInt32(read[0]);
                    user.Username = read[1].ToString();
                    user.Password = read[2].ToString();
                    user.TipoUsuario = read[3].ToString();
                    user.categoria_id = Convert.ToInt32(read[4]);
                    read.Close();

                    System.Windows.Forms.MessageBox.Show("BIENVENIDO AL SISTEMA " + (user.Username).ToUpper(), "INGRESO DE USUARIO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);

                }
                else { System.Windows.Forms.MessageBox.Show("USUARIO INCORRECTO, VERIFIQUE LOS DATOS!", "INGRESO DE USUARIO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Hay un conflicto con la base de datos!" + "Información : " + ex.Message);
            }

            finally
            {
                _objConexion.getConexion().Close();
            }
            return validoRegistro;
        }


        public void getUserCategory(ComboBox cmb)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SearchUserCategory", _objConexion.getConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmb.ValueMember = dt.Columns[0].ToString();
                cmb.DataSource = dt;
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

        public void SearchUsers(DataGridView Grid)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SP_SearchUsers", _objConexion.getConexion());
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
        public bool InsertUser(Usuarios user)
        {
            int insertaRegistro = 0;
            try
            {

                SqlCommand _comand = new SqlCommand("SP_InsertUser", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@username", SqlDbType.VarChar).Value = user.username;
                _comand.Parameters.Add("@password", SqlDbType.VarChar).Value = user.password;
                _comand.Parameters.Add("@ID_Categoria", SqlDbType.Int).Value = user.categoria;


                if (selectCondicion("Users", " username = '" + user.username + "'") == false)
                {
                    insertaRegistro = _comand.ExecuteNonQuery();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("YA EXISTE ESE NOMBRE DE USUARIO: '" + user.username + " ' EL CUAL DESEA AGREGAR");
                }

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

        public bool updateUser(Usuarios user)
        {
            int insertaRegistro = 0;
            try
            {

                SqlCommand _comand = new SqlCommand("SP_UpdateUser", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@id", SqlDbType.Int).Value = user.user_id;
                _comand.Parameters.Add("@username", SqlDbType.VarChar).Value = user.username;
                _comand.Parameters.Add("@password", SqlDbType.VarChar).Value = user.password;
                _comand.Parameters.Add("@ID_Categoria", SqlDbType.Int).Value = user.categoria;


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

        public bool DeleteProduct(Usuarios user)
        {
            int insertaRegistro = 0;
            try
            {
                SqlCommand _comand = new SqlCommand("SP_DeleteUsers", _objConexion.getConexion());
                _objConexion.getConexion().Open();

                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@id", SqlDbType.Int).Value = user.user_id;

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
                    ExecuteQuery(sb.ToString(), "Users");

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