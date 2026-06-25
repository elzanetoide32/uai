using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public  class Revista: MaterialBiblioteca, IConsultaRestringida
    {
        public int NumeroEdicion {  get; set; }

        public string CodigoAutorizacion => "Autorización hemeroteca";

        public Revista(string titulo, string autor, int año, int Numeroedicion) : base(titulo, autor, año)
        {
            NumeroEdicion = Numeroedicion;
        }
        public override int CalcularDiasPrestamo()
        {
            return 7;
        }
    }
}
