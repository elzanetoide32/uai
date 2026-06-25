using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Persona
    {

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Edad { get; set; }

        public bool Mayor { get; set; }


        public string Presentarse()
        {
            string mSaludo;

            try
            {
                if(int.Parse(Edad) > 30 )
                    mSaludo = "Buenas tardes, soy " + Nombre + " " + Apellido; 
                    else
                        mSaludo = "Hola, soy " + Nombre + " " + Apellido;
                    return mSaludo;
            }
            catch
            {
                //return "Error";
                //Loguear el error
                //Advertir a un adminitrador del sistema...
                throw;
            }

          
        }

        public void Contratar()
        {
            if ((Mayor && int.Parse (Edad) < 21)|| (!Mayor && int.Parse (Edad ) >= 21))
            { 
                //Error
                EdadException ex = new EdadException();
                ex.Persona = this;
                throw ex;
            }


        }

    }
}
