namespace DesignSistemVentas.Model
{
    class cuentaCorriente
    {
        public int Nro_Factura { get; set; }

        public int Nro_Cuota { get; set; }
        public string Estado { get; set; }

        public decimal Saldo { get; set; }
    }
}
