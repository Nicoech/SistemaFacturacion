using DesignSistemVentas.Utilities;
using System;
using System.Data.SqlClient;

namespace DesignSistemVentas.ModelDao
{
    class Conexion
    {
        public SqlConnection _conexion;
        private static Conexion _objConexion = null;

        private Conexion()
        {
            _conexion = new SqlConnection(Constants.stringConnection);
        }
        public static Conexion validarConexion()
        {
            try
            {
                if (_objConexion == null)
                {
                    _objConexion = new Conexion();
                }
                return _objConexion;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error con la conexion a la base de datos" + ex.Message);

                throw;
            }
        }
        public SqlConnection getConexion()
        {
            return _conexion;
        }

        public void cerrarConexion()
        {
            _conexion.Close();
        }



    }
}
