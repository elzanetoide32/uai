using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class Hamburguesa : Producto
    {
        public bool Completa { get; set; }

        public Hamburguesa(float precioBase, bool completa)
            : base(precioBase)
        {
            Completa = completa;
        }

        public override float CalcularPrecioFinal()
        {
            float precio = PrecioBase;

            if (Completa)
            {
                precio += PrecioBase * 0.50f;
            }

            precio += Comision;

            return precio;
        }
    }
}
