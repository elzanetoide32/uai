using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class CUITObligatorioException : Exception
    {
        private Factura mFactura;
        public Factura Factura => mFactura;

        public CUITObligatorioException(Factura factura)

        : base("El CUIT es obligatorio para facturas tipo A o B.")
        {
            mFactura = factura;
        }

    }
}

