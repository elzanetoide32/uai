using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Perro
    {
        Persona p = new Persona();

        public void Test()
        {
            //p.MiembroPrivado = "No";
            p.MiembroInternal = "Ok";
            p.MiembroPublico = "Ok";
            //p.MiembroProtected = "No";
            p.MiembroProtectedInternal = "Ok";
        }
    }
}
