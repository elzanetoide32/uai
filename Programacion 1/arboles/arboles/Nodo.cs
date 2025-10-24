using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles
{
   public  class Nodo
    {
        public string Nombre
        { get; set; }
        public Nodo Izquierdo
        { get; set; }
        public Nodo Derecho
        { get; set;}
        /// construllo el nodo
        public Nodo(string nombre, Nodo izquierdo, Nodo derecho)
        {
            Nombre = nombre;
            Izquierdo = izquierdo;
            Derecho = derecho;
        }
    }
}
