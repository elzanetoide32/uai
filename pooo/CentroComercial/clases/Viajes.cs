using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class PaqueteTuristico : Producto
    {
        public bool PaqueteAlExterior { get; set; }

        public PaqueteTuristico(float precioBase, bool exterior)
            : base(precioBase)
        {
            PaqueteAlExterior = exterior;
        }

        public override float CalcularPrecioFinal()///yo tengo que sobreescribir a la clase abstracta
        {
            float precio = PrecioBase;

            if (PaqueteAlExterior)
            {
                precio += PrecioBase * 0.90f;
            }

            precio += Comision;

            return precio;
        }
    }
}
