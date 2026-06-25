using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Asistente:Persona
    {
        public int Ubicacion { get; private set; }
        private static int contadorUbicacion = 0;
        public Asistente(string nombre,string apellido) : base(nombre,apellido)
        {
            contadorUbicacion++;           // primero incrementa el contador global
            Ubicacion = contadorUbicacion; // después se la asigna a SÍ MISMO
        }

    }
}
