using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class REPOSTERO : COCINERO
    {
        internal override PLATO PrepararPlato()
        {
            PLATO plato = new PLATO();
            plato.agregar(new INGREDIENTE("Azucar ", 8));
            plato.agregar(new INGREDIENTE("Azucar ", 8));
            plato.agregar(new INGREDIENTE("Azucar ", 8));
            plato.agregar(new INGREDIENTE("Harina  ", 4));
            plato.agregar(new INGREDIENTE("Harina  ", 4));
            plato.agregar(new INGREDIENTE("Harina  ", 4));
            plato.agregar(new INGREDIENTE("Huevo  ", 3));
            plato.agregar(new INGREDIENTE("Huevo  ", 3));
            //total: 42
            return plato;
        }
    }
}
