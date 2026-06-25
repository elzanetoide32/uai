using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Alumno : Persona
    {

        public void Test2()
        {
            //MiembroPrivado = "No";
            MiembroInternal = "Ok";
            MiembroPublico = "Ok";
            MiembroProtected = "Ok";
            MiembroProtectedInternal = "Ok";
        }

    }
}
