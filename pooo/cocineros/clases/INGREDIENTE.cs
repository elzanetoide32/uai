using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class INGREDIENTE:ICloneable

    {
        public string Nombre {  get; set; }
        public Single Costo {  get; set; }

        public INGREDIENTE(string nombre,Single costo) { 
            Nombre= nombre;
            Costo= costo;       
        }
        public object Clone()
        {
            return new INGREDIENTE(Nombre, Costo); // clonacion profunda
        }

    }
}
