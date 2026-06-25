using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace AmbitoProtected
{
    public class Docente : Persona
    {

        public void Test2()
        {
            //MiembroPrivado = "No";
            //MiembroInternal = "No";
            MiembroPublico = "Ok";
            MiembroProtected = "Ok";
            MiembroProtectedInternal = "Ok";
        }
    }
}
