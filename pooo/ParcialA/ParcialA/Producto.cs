using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialA
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Codigo { get; }
        public bool Cobrado { get; private set; }


        public Producto(string codigo)
        {
            Codigo = codigo;
            Cobrado=false;
        }
        public void Cobrar()
        {
            Cobrado=true;
        }
    }
}

