using System;

namespace DesignSistemVentas.Model
{
    class Clientes
    {
        public int Id_cliente { get; set; }

        public int Nro_DNI { get; set; }

        public string Nro_cuit { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Domicilio { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string Condicion_IVA { get; set; }

        public string Fecha_Nacimiento { get; set; }

        public DateTime Fecha_Alta { get; set; }

        public int CodigoPostal { get; set; }


    }
}
