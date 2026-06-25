using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Persona
    {
        private string MiembroPrivado; //Visible desde la clase que lo declara
        internal string MiembroInternal; //Visible desde la clase que lo declara y desde otras clases del mismo assembly 
        public string MiembroPublico; //Visible desde la clase que lo delcara, desde otra clases del mismo assembly y desde otras clases de otros proyectos con referencia

        protected string MiembroProtected; //Visible desde la clase que lo declara y desde clases derivadas

        protected internal string MiembroProtectedInternal; //Visible desde la clase que lo declara, desde clases derivadas Y desde clases del mismo assembly (suma ambos ámbitos) -> Una clase debe heredar "O" debe compartir proyecto con la clase que lo declara

        public void Test()
        {
            MiembroPrivado = "Ok";
            MiembroInternal = "Ok";
            MiembroPublico = "Ok";
            MiembroProtected = "Ok";
            MiembroProtectedInternal = "Ok";
        }

    }
}
