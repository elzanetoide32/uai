using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class PLATO: IEnumerable<INGREDIENTE>,ICloneable
    {
        private List<INGREDIENTE> ingredientes=new List<INGREDIENTE>() ;

        public double Costo()
        {
            return ingredientes.Sum(i => i.Costo); ///el .sum lo tiene porque es una lista
        }
        public void agregar(INGREDIENTE ingrediente)
        {
            ingredientes.Add(ingrediente);
        }
        public IEnumerator<INGREDIENTE> GetEnumerator()
        {
            return ingredientes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public object Clone()
        {
            PLATO nuevo = new PLATO();
            foreach (var ingrediente in ingredientes)
            {
                nuevo.agregar((INGREDIENTE)ingrediente.Clone()); // hace la clonacion de la cllonacion y luego lo clustea
            }
            return nuevo;
        }
    }
}
