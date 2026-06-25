using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class Libro:MaterialBiblioteca
    {
        public string Genero {  get; set; }
        public Libro(string titulo, string autor,int año,string genero):base(titulo,autor,año)
        {
            Genero = genero;   
        }

        public override int CalcularDiasPrestamo()
        {
            return 15;
        }
    }
}
