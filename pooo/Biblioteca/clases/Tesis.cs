using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class Tesis:MaterialBiblioteca, IConsultaRestringida
    {
        public string Universidad {  get; set; }

        public string CodigoAutorizacion => Universidad;

        public Tesis(string titulo, string autor, int año, string universidad) : base(titulo, autor, año)
        {
            Universidad = universidad;
        }
        public override int CalcularDiasPrestamo()
        {
            return 3;
        }
    }
}
