using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public abstract class MaterialBiblioteca
    {
        /*Titulo, Autor y AnioPublicacion.
La clase MaterialBiblioteca expondrá un método sobrescribible CalcularDiasPrestamo, que devolverá la cantidad de días por los cuales el material puede ser prestado.
*/   
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicado { get; set; }
        public MaterialBiblioteca(string titulo,string autor,int año)
        {
            Titulo = titulo;
            Autor = autor;
            AñoPublicado = año;

        }

        public virtual int CalcularDiasPrestamo()
        {
            return 5;
        }
    }
}
