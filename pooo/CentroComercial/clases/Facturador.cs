using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class Facturador
    {
        private List<Producto> productos;

        public Facturador()
        {
            productos = new List<Producto>();
        }

        public List<Producto> Productos
        {
            get { return productos; }
        }

        public void AgregarProducto(Producto p)
        {
            productos.Add(p);
        }

        public string GenerarFactura()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CODIGO\tNOMBRE\t\tPRECIO FINAL");

            float total = 0;

            foreach (Producto p in productos)
            {
                float precioFinal = p.CalcularPrecioFinal();

                sb.AppendLine(
                    p.Codigo + "\t" +
                    p.Nombre + "\t\t" +
                    precioFinal.ToString("0.00")
                );

                total += precioFinal;
            }

            sb.AppendLine("--------------------------------");
            sb.AppendLine("TOTAL:\t\t" + total.ToString("0.00"));

            return sb.ToString();
        }
    }
}
