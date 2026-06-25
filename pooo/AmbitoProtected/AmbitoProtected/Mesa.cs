using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace AmbitoProtected
{
    public class Mesa
    {

        Persona p = new Persona();

        public void Test()
        {
            //p.MiembroPrivado = "No";
            //p.MiembroInternal = "No";
            p.MiembroPublico = "Ok";
            //p.MiembroProtected = "No";
            //MiembroProtectedInternal = "No";
        }
    }
}
