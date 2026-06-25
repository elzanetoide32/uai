using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class Libre:Remedio
    {
        public Libre(string nombre, Single precio, ObraSocial? obraSocial = null)
        : base(nombre, precio, obraSocial)
        { }
    }
}
