using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public abstract class COCINERO
    {
        internal virtual PLATO PrepararPlato()
        {
            return new PLATO();
        }

    }
}
