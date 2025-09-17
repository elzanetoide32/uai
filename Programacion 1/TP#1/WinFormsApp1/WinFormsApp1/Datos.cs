using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace WinFormsApp1
{
    public static class Datos
    {
        public static List<Registro> ListaPresupuesto = new List<Registro>();
        public static int ProximoId = 1; // Para generar IDs únicos
        public static int TipoOperacion = 0; // 1: Alta, 2: Modificación
        public static decimal CalcularSaldoTotal()
        {
            decimal saldo = 0;

            foreach (var r in Datos.ListaPresupuesto)
            {
                if (r.Tipo == "Ingreso")
                {
                    saldo += r.Importe;
                }
                else if (r.Tipo == "Gasto")
                {
                    saldo -= r.Importe;
                }
            }

            return saldo;
        }
    }

    public class Registro
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public decimal Importe { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; } // "Ingreso" o "Gasto"
    }


}
