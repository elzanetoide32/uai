using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public abstract class Producto  //nose puede instanciar sino atraves de sus derivadas
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public float PrecioBase { get; }

        // Comisión general
        public static int Comision { get; set; }

        public Producto(float precioBase)
        {
            PrecioBase = precioBase;
        }

        public abstract float CalcularPrecioFinal();
    }
}
