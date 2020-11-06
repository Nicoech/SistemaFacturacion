using System;

namespace DesignSistemVentas.Model
{
    class RemitoModel
    {
        public int Nro_Remito { get; set; }

        public int Nro_Factura { get; set; }

        public int ID_Producto { get; set; }

        public int Cantidad { get; set; }

        public DateTime Fecha_Emision { get; set; }
    }
}
