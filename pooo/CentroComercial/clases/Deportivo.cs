using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class Zapatilla : Producto
    {
        public enum TipoZapatilla
        {
            Urbana,
            Running,
            Football,
            Basquet
        }

        public TipoZapatilla Tipo { get; set; }
        public int Talle { get; set; }

        public Zapatilla(float precioBase, TipoZapatilla tipo, int talle)
            : base(precioBase)
        {
            Tipo = tipo;
            Talle = talle;
        }

        public override float CalcularPrecioFinal()
        {
            float precio = PrecioBase;

            // 10% descuento urbanas
            if (Tipo == TipoZapatilla.Urbana)
            {
                precio -= PrecioBase * 0.10f;
            }

            // 10% descuento talle > 48
            if (Talle > 48)
            {
                precio -= PrecioBase * 0.10f;
            }

            precio += Comision;

            return precio;
        }
    }
}
