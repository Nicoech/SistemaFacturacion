using System;

namespace DesignSistemVentas.Model
{
    class FacturaCuotas
    {
        public int Nro_Factura { get; set; }

        public int Nro_Cuota { get; set; }

        public DateTime fecha_inicial { get; set; }
        public DateTime fecha_vto { get; set; }

        public string estado_cuota { get; set; }

        public decimal Importe { get; set; }

    }
}
