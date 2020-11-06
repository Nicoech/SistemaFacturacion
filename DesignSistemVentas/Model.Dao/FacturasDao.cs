using DesignSistemVentas.ModelDao;
using DesignSistemVentas.View.FacturasViews;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesignSistemVentas.Model.Dao
{
    class FacturasDao
    {
        //VARIABLES

        private Conexion _objConexion;
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataTable dt = new DataTable();
        public SqlCommand comand = new SqlCommand();
        private DataSet ds = new DataSet();
        private VistaFacturas _vf;

        //----------CONSTRUCTORES--------------------------------------------------------------------------------
        public FacturasDao()
        {
            _objConexion = Conexion.validarConexion();

        }

        public FacturasDao(VistaFacturas vf)
        {
            _vf = vf;
        }

        //----------------------------------------------------------------------------------------------------------------
        public void searchClientesFactura(DataGridView Grid)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SP_SearchClientesParaFactura", _objConexion.getConexion());
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

        

//--------------------------------------------------------------------------------------------------
            public DataTable SP_searchFacturasByIDClienteReimprimir(string buscoFacturas)
        {
            try
            {

                comand = new SqlCommand("SP_searchFacturasByIDClienteReimprimir", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                comand.Parameters.Add("@filtro", SqlDbType.VarChar).Value = buscoFacturas;
                comand.CommandType = CommandType.StoredProcedure;
                comand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comand);
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    return dt;
                } else
                {
                    MessageBox.Show("El Cliente no posee facturas ni remitos dentro del sistema.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
//--------------------------------------------------------------------------------------------------
        public DataTable SP_searchRemitosByIDCliente(string buscoRemitos)
        {
            try
            {

                comand = new SqlCommand("SP_searchRemitoByNroFactura", _objConexion.getConexion());
                _objConexion.getConexion().Open();
                comand.Parameters.Add("@filtro", SqlDbType.VarChar).Value = buscoRemitos;
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
        //---------------------------------------------------------------------------------------------------------------------
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
        //---------------------------------------------------------------------------------------------------------

        public DataTable searchClienteByFiltro(string buscoCliente)
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
        public void searchClientesReimprimirFactura(DataGridView Grid)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SP_SearchClientesParaReimpresion", _objConexion.getConexion());
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
        //----------------------------------------------------------------------------------------------------------------
        public void searchProductosFactura(DataGridView Grid)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SP_SearchProductosParaFactura", _objConexion.getConexion());
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
        //----------------------------------------------------------------------------------------------------------------
        public int obtengoNroFactura()
        {
            int nroFac = 0;
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SP_generoNumeroFactura", _objConexion.getConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                nroFac = int.Parse(dt.Rows[0]["Nro_Factura"].ToString());

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
            return nroFac;
        }

        //----------------------------------------------------------------------------------------------------------------
        public int obtengoNroRemito()
        {
            int nroFac = 0;
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("SP_generoNumeroRemito", _objConexion.getConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                nroFac = int.Parse(dt.Rows[0]["Nro_Factura"].ToString());

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
            return nroFac;
        }

        //----------------------------------------------------------------------------------------------------------------
        public bool insertoFacturaDao(Facturacion producto)
        {
            SqlCommand _comand = null;
            bool inserteFactura = false;
            try
            {
                _comand = new SqlCommand("insertEncabezadoFactura", _objConexion.getConexion());
                _objConexion.getConexion().Open();

                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@Nro_Factura", SqlDbType.Int).Value = producto.Nro_Factura;
                _comand.Parameters.Add("@ID_Producto", SqlDbType.Int).Value = producto.ID_Producto;
                _comand.Parameters.Add("@Cantidad", SqlDbType.Int).Value = producto.Cantidad;
                _comand.Parameters.Add("@Letra_Factura", SqlDbType.Char).Value = producto.Letra_Factura;
                _comand.Parameters.Add("@ID_Cliente", SqlDbType.Int).Value = producto.ID_Cliente;
                _comand.Parameters.Add("@Nro_DNI", SqlDbType.Int).Value = producto.Nro_DNI;
                _comand.Parameters.Add("@FormaDePago", SqlDbType.VarChar).Value = producto.FormaDePago;
                _comand.Parameters.Add("@Fecha_Emision", SqlDbType.Date).Value = producto.Fecha_Emision;
                _comand.Parameters.Add("@Vendedor", SqlDbType.VarChar).Value = producto.Vendedor;
                _comand.Parameters.Add("@Nro_Remito", SqlDbType.Int).Value = producto.Nro_Remito;
                _comand.Parameters.Add("@Total", SqlDbType.Decimal).Value = producto.total;

                _comand.ExecuteNonQuery();

                inserteFactura = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                               "INFORMACION : " + ex.Message);

                inserteFactura = false;

                _objConexion.getConexion().Close();
            }
            finally
            {
                _comand.Connection.Close();
                _objConexion.cerrarConexion();

            }
            return inserteFactura;
        }

        public bool insertoFacturaDaoCC(Facturacion producto)
        {
            SqlCommand _comand = null;
            bool inserteFactura = false;
            try
            {
                _comand = new SqlCommand("insertEncabezadoFacturaCC", _objConexion.getConexion());
                _objConexion.getConexion().Open();

                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@Nro_Factura", SqlDbType.Int).Value = producto.Nro_Factura;
                _comand.Parameters.Add("@ID_Producto", SqlDbType.Int).Value = producto.ID_Producto;
                _comand.Parameters.Add("@Cantidad", SqlDbType.Int).Value = producto.Cantidad;
                _comand.Parameters.Add("@Letra_Factura", SqlDbType.Char).Value = producto.Letra_Factura;
                _comand.Parameters.Add("@ID_Cliente", SqlDbType.Int).Value = producto.ID_Cliente;
                _comand.Parameters.Add("@Nro_DNI", SqlDbType.Int).Value = producto.Nro_DNI;
                _comand.Parameters.Add("@FormaDePago", SqlDbType.VarChar).Value = producto.FormaDePago;
                _comand.Parameters.Add("@Fecha_Emision", SqlDbType.Date).Value = producto.Fecha_Emision;
                _comand.Parameters.Add("@Vendedor", SqlDbType.VarChar).Value = producto.Vendedor;
                _comand.Parameters.Add("@Saldo", SqlDbType.Decimal).Value = producto.Saldo;
                _comand.Parameters.Add("@Total", SqlDbType.Decimal).Value = producto.total;

                _comand.ExecuteNonQuery();

                inserteFactura = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                               "INFORMACION : " + ex.Message);

                inserteFactura = false;

                _objConexion.getConexion().Close();
            }
            finally
            {
                _comand.Connection.Close();
                _objConexion.cerrarConexion();

            }
            return inserteFactura;
        }


        public bool descuentoCantidad(Productos producto)
        {
            SqlCommand _comand = null;
            bool inserteFactura = false;
            try
            {
                _comand = new SqlCommand("descuentoCantidad", _objConexion.getConexion());
                _objConexion.getConexion().Open();

                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@ID_Prod", SqlDbType.Int).Value = producto.ID_Producto;
                _comand.Parameters.Add("@Cant", SqlDbType.Int).Value = producto.Stock_Act;

                _comand.ExecuteNonQuery();

                inserteFactura = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                               "INFORMACION : " + ex.Message);

                inserteFactura = false;

                _objConexion.getConexion().Close();
            }
            finally
            {
                _comand.Connection.Close();
                _objConexion.cerrarConexion();

            }
            return inserteFactura;
        }

        public bool adicionCantidad(Productos producto)
        {
            SqlCommand _comand = null;
            bool inserteFactura = false;
            try
            {
                _comand = new SqlCommand("adiciondeCantidad", _objConexion.getConexion());
                _objConexion.getConexion().Open();

                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@ID_Prod", SqlDbType.Int).Value = producto.ID_Producto;
                _comand.Parameters.Add("@Cant", SqlDbType.Int).Value = producto.Stock_Act;

                _comand.ExecuteNonQuery();

                inserteFactura = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                               "INFORMACION : " + ex.Message);

                inserteFactura = false;

                _objConexion.getConexion().Close();
            }
            finally
            {
                _comand.Connection.Close();
                _objConexion.cerrarConexion();

            }
            return inserteFactura;
        }
        //----------------------------------------------------------------------------------------------------------------
       
       
        public bool InsertEncabezadoRemito(RemitoModel R)
        {
            SqlCommand _comand = null;
            bool inserteFactura = false;
            try
            {
                _comand = new SqlCommand("insertEncabezadoRemito", _objConexion.getConexion());
                _objConexion.getConexion().Open();

                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@Nro_Factura", SqlDbType.Int).Value = R.Nro_Factura;
                _comand.Parameters.Add("@Nro_Remito", SqlDbType.Int).Value = R.Nro_Remito;
                _comand.Parameters.Add("@Fecha_Emision", SqlDbType.Date).Value = R.Fecha_Emision;

                _comand.Parameters.Add("@ID_Producto", SqlDbType.Int).Value = R.ID_Producto;
                _comand.Parameters.Add("@Cantidad", SqlDbType.Int).Value = R.Cantidad;


                _comand.ExecuteNonQuery();

                inserteFactura = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                               "INFORMACION : " + ex.Message);

                inserteFactura = false;

                _objConexion.getConexion().Close();
            }
            finally
            {
                _comand.Connection.Close();
                _objConexion.cerrarConexion();

            }
            return inserteFactura;
        }
        //----------------------------------------------------------------------------------------------------------------
        public void guardoTotalFactura(int nroFac, decimal total,string iva,decimal neto,decimal netoiva, string obs)
        {
            SqlCommand _comand = null;
            try
            {
                _comand = new SqlCommand("SP_generoTotalFactura", _objConexion.getConexion());
                _objConexion.getConexion().Open();

                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@Nro_Factura", SqlDbType.Int).Value = nroFac;
                _comand.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = obs;
                _comand.Parameters.Add("@neto", SqlDbType.Decimal).Value = neto;
                _comand.Parameters.Add("@iva", SqlDbType.VarChar).Value = iva;
                _comand.Parameters.Add("@netoiva", SqlDbType.Decimal).Value = netoiva;


                _comand.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                               "INFORMACION : " + ex.Message);
                _objConexion.getConexion().Close();
            }
            finally
            {
                _comand.Connection.Close();

                _objConexion.cerrarConexion();

            }
        }

        //----------------------------------------------------------------------------------------------------------------
        public bool insertFacturaCuotas(FacturaCuotas FC)
        {
            SqlCommand _comand = null;
            bool inserteFactura = false;
            try
            {
                _comand = new SqlCommand("insertFacturaCuotas", _objConexion.getConexion());
                _objConexion.getConexion().Open();

                _comand.CommandType = CommandType.StoredProcedure;
                _comand.Parameters.Add("@Nro_Fac", SqlDbType.Int).Value = FC.Nro_Factura;
                _comand.Parameters.Add("@Nro_Cuota", SqlDbType.Int).Value = FC.Nro_Cuota;
                _comand.Parameters.Add("@Fecha_Inicial", SqlDbType.Date).Value = FC.fecha_inicial;
                _comand.Parameters.Add("@Fecha_Vto", SqlDbType.Date).Value = FC.fecha_vto.ToShortDateString();
                _comand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = FC.estado_cuota;
                _comand.Parameters.Add("@Importe", SqlDbType.Decimal).Value = FC.Importe;

                _comand.ExecuteNonQuery();

                inserteFactura = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                               "INFORMACION : " + ex.Message);

                inserteFactura = false;

                _objConexion.getConexion().Close();
            }
            finally
            {
                _comand.Connection.Close();
                _objConexion.cerrarConexion();

            }
            return inserteFactura;
        }

        //----------------------------------------------------------------------------------------------------------------
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
                    ExecuteQuery(sb.ToString(), tabla);

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

        //----------------------------------------------------------------------------------------------------------------
        public bool ExecuteQuery(string query, string tabla)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, _objConexion.getConexion());
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Fill(ds, tabla);
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("HAY UN PROBLEMA CON LA BASE DE DATOS" +
                               "INFORMACION : " + ex.Message);
                return false;
            }

        }

        //----------------------------------------------------------------------------------------------------------------
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
        //----------------------------------------------------------------------------------------------------------------
        public void SearchClientsByFiltroReimprimirFacturas(DataGridView Grid, string buscoCliente)
        {
            try
            {

                comand = new SqlCommand("SP_buscarClienteReimprimirByFiltro", _objConexion.getConexion());
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
        //----------------------------------------------------------------------------------------------------------------

    }
}
