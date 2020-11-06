using System;

namespace DesignSistemVentas.Model
{
    class Productos
    {
        public int ID_Producto { get; set; }
        public string Descripcion { get; set; }

        public Decimal Precio_Unit { get; set; }

        public int Stock_Act { get; set; }

        public int Stock_Min { get; set; }

        public string Cod_Producto { get; set; }

        public int Categoria { get; set; }
    }
}
