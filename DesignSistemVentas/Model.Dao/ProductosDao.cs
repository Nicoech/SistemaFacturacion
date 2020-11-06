using DesignSistemVentas.ModelDao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesignSistemVentas.Model.Dao
{
    class ProductosDao
    {
        private Conexion _objConexion;
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataTable dt = new DataTable();
        public SqlCommand comand = new SqlCommand();
        private DataSet ds = new DataSet();
        public ProductosDao()
        {
            _objConexion = Conexion.validarConexion();

        }


        public bool InsertProducto(Productos producto)
        {
            int insertaRegistro = 0;
            try
            {

                SqlCommand _comand = new SqlCommand("SP_InsertProduct", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                _comand.CommandType = CommandType.StoredProcedure;

                _comand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = producto.Descripcion;
                _comand.Parameters.Add("@Precio_Unitario", SqlDbType.Decimal).Value = producto.Precio_Unit;
                _comand.Parameters.Add("@Stock_Actual", SqlDbType.Int).Value = producto.Stock_Act;
                _comand.Parameters.Add("@Stock_Minimo", SqlDbType.Int).Value = producto.Stock_Min;
                _comand.Parameters.Add("@Cod_Producto", SqlDbType.VarChar).Value = producto.Cod_Producto;
                _comand.Parameters.Add("@ID_Categoria", SqlDbType.Int).Value = producto.Categoria;

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
        public bool UpdateProduct(Productos producto)
        {
            int insertaRegistro = 0;
            try
            {


                SqlCommand _comand = new SqlCommand("SP_UpdateProducts", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@id", SqlDbType.Int).Value = producto.ID_Producto;
                _comand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = producto.Descripcion;
                _comand.Parameters.Add("@Precio_Unitario", SqlDbType.Decimal).Value = producto.Precio_Unit;
                _comand.Parameters.Add("@Stock_Actual", SqlDbType.Int).Value = producto.Stock_Act;
                _comand.Parameters.Add("@Stock_Minimo", SqlDbType.Int).Value = producto.Stock_Min;
                _comand.Parameters.Add("@Cod_Producto", SqlDbType.VarChar).Value = producto.Cod_Producto;
                _comand.Parameters.Add("@ID_Categoria", SqlDbType.Int).Value = producto.Categoria;

                insertaRegistro = _comand.ExecuteNonQuery();

                _comand.Connection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS " +
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
        public bool DeleteProduct(Productos producto)
        {
            int insertaRegistro = 0;
            try
            {
                SqlCommand _comand = new SqlCommand("SP_DeleteProducts", _objConexion.getConexion());
                _objConexion.getConexion().Open();

                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@id", SqlDbType.Int).Value = producto.ID_Producto;

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

        public bool insertCategoria(CategoriaProductos categoria)
        {
            int insertaRegistro = 0;
            try
            {

                SqlCommand _comand = new SqlCommand("SP_InsertCategory", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                _comand.CommandType = CommandType.StoredProcedure;

                _comand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = categoria.Descripcion;

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
        public int obtengoNroProducto()
        {
            int idProd = 0;
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SP_generoIDProducto", _objConexion.getConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                idProd = int.Parse(dt.Rows[0]["ID_Producto"].ToString());

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
            return idProd;
        }
        public int obtengoIDCategoria()
        {
            int idProd = 0;
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SP_generoIDCategoria", _objConexion.getConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                idProd = int.Parse(dt.Rows[0]["ID_Categoria"].ToString());

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
            return idProd;
        }
        public void SearchProducts(DataGridView Grid)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SearchProducts", _objConexion.getConexion());
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
        public void getProductCategories(ComboBox cmb)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SearchProductCategory", _objConexion.getConexion());
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
        public void SearchProductByCodOrDescription(DataGridView Grid, string buscoProducto)
        {
            try
            {

                comand = new SqlCommand("SP_SearchProductByCodOrDescription", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                comand.Parameters.Add("@filtro", SqlDbType.VarChar).Value = buscoProducto;
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
                    ExecuteQuery(sb.ToString(), "Productos");

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
