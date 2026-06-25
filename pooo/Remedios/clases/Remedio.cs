using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public abstract class Remedio
    {
        public string Nombre { get; set; }
        public Single Precio { get; set; }
        public Remedio(string nombre, Single precio, ObraSocial? obraSocial = null)
        {
            Nombre = nombre;
            Precio = precio;
            this.obraSocial = obraSocial;
        }
        public enum ObraSocial { OSDE, OSPLAD, OSECAC }
        public ObraSocial? obraSocial;

        public Single ObtenerPrecio()
        {
            return Precio;
        }

        public Single ObtenerPrecio(ObraSocial obraSocial)
        {
            switch (obraSocial)
            {
                case ObraSocial.OSDE:
                    return Precio * 0.7f;
                case ObraSocial.OSPLAD:
                    return Precio * 0.5f;
                case ObraSocial.OSECAC:
                    return Precio * 0.45f;
                default:
                    return Precio*0.6f;
            }
        }
    }
}
