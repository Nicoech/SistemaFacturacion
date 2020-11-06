using System;

namespace DesignSistemVentas.Model
{
    public class Facturacion
    {
        public int Nro_Factura { get; set; }

        public char Letra_Factura { get; set; }

        public int ID_Cliente { get; set; }

        public int Nro_DNI { get; set; }

        public string FormaDePago { get; set; }

        public int ID_Producto { get; set; }

        public int Cod_Producto { get; set; }

        public string Descripcion { get; set; }

        public int Cantidad { get; set; }

        public DateTime Fecha_Emision { get; set; }

        public string Vendedor { get; set; }

        public string Cuit { get; set; }

        public string Condicion_IVA { get; set; }

        public string Domicilio { get; set; }

        public decimal Saldo { get; set; }

        public int Nro_Remito { get; set; }

        public decimal neto { get; set; }
        public decimal total { get; set; }

        public string iva { get; set; }

        public decimal netoIVA { get; set; }

        public string Observaciones {get;set;}


    }
}
