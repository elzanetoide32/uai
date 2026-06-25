using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class PsicoFarmaco : Remedio, IRecetable
    {
        public PsicoFarmaco(string nombre, Single precio, ObraSocial? obraSocial = null)
        : base(nombre, precio, obraSocial)
        { }
        public string NumeroTroquel { get ; set; }
    }
}
