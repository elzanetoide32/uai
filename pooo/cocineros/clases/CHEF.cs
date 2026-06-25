using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class CHEF:COCINERO
    {
        internal override PLATO PrepararPlato()
        {
            PLATO plato = new PLATO();
            plato.agregar(new INGREDIENTE("Carne", 15));
            plato.agregar(new INGREDIENTE("Carne", 15));
            plato.agregar(new INGREDIENTE("Papa", 9));
            plato.agregar(new INGREDIENTE("Papa", 9));
            plato.agregar(new INGREDIENTE("Cebolla", 6));
            ///total: 54
            return plato;
        }
    }
}
