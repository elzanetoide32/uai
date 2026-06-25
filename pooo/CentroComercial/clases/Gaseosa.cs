using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class Gaseosa:Producto
    {
        public bool XL { get; set; }

        public Gaseosa(float precioBase, bool xl): base(precioBase) ////hereda de la base el precio base
        {
            XL = xl;
        }

        public override float CalcularPrecioFinal()
        {
            float precio = PrecioBase;

            if (XL)
            {
                precio += PrecioBase * 0.35f;
            }

            precio += Comision;

            return precio;
        }
    }
}
