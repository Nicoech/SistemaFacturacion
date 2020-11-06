using System.Collections.Generic;

namespace DesignSistemVentas.Utilities
{
    class Constants
    {
        public static string stringConnection = "server=(local)\\SQLEXPRESS ; database=HogarElectrico ; integrated security = true";

        public List<string> listaCondicionesIVA()
        {
            List<string> lista = new List<string>();
            lista.Add("CONSUMIDOR FINAL");
            lista.Add("RESPONSABLE INSCRIPTO");
            //   lista.Add("EXENTO");
            //   lista.Add("MONOTRIBUTISTA");
            return lista;
        }
        public List<string> TipoCliente()
        {
            List<string> lista = new List<string>();
            lista.Add("REGISTRADO");
            lista.Add("REGISTRAR CLIENTE");
            return lista;
        }

        public List<string> TipoMovimientoCaja()
        {
            List<string> lista = new List<string>();
            lista.Add("EGRESO");
            lista.Add("INGRESO");
            return lista;
        }

        public List<string> cuotasTarjeta()
        {
            List<string> lista = new List<string>();
            lista.Add("3");
            lista.Add("6");
            return lista;
        }

        public List<string> LetrasFactura()
        {
            List<string> lista = new List<string>();
            lista.Add("A");
            lista.Add("B");
            return lista;
        }
        public List<string> FormaDePagoClientesRegistrados()
        {
            List<string> lista = new List<string>();
            lista.Add("EFECTIVO");
            lista.Add("TARJETA");
            lista.Add("CTA.CTE");

            return lista;
        }
        public List<string> mensajeFacturasCmb()
        {
            List<string> lista = new List<string>();
            lista.Add("SELECCIONE FACTURA");
            return lista;
        }
        public List<string> FormaDePagoClientesEventuales()
        {
            List<string> lista = new List<string>();
            lista.Add("EFECTIVO");
            lista.Add("TARJETA");
            return lista;
        }
        public List<string> NumeroCuitPF()
        {
            List<string> lista = new List<string>();
            lista.Add("20");
            lista.Add("23");
            lista.Add("24");
            lista.Add("27");
            lista.Add("30");
            lista.Add("33");
            lista.Add("34");

            return lista;
        }
        public List<string> DigitoVerificador()
        {
            List<string> lista = new List<string>();
            lista.Add("1");
            lista.Add("2");
            lista.Add("3");
            lista.Add("4");
            lista.Add("5");
            lista.Add("6");
            lista.Add("7");
            lista.Add("8");
            lista.Add("9");


            return lista;
        }
        public List<string> cuotasFacturaCC()
        {
            List<string> lista = new List<string>();
            lista.Add("6");
            lista.Add("8");

            return lista;
        }

    }
}
