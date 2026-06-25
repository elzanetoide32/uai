using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class MESA: IEnumerable<PLATO>
    {
        public string Nombre { get; }
        public MESA(string pNombre) { 
            Nombre = pNombre;
        }
        private List<PLATO> Platos=new List<PLATO>();
        public void AgregarPlato(PLATO plato)
        {
            Platos.Add(plato);
        }

        public IEnumerator<PLATO> GetEnumerator()
        {
           return Platos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
