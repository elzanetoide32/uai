using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Heladera:Electrodomesticos
    {
        public int Capacidad {  get; set; }

        public sealed override int Consumo()
        {
            if (Capacidad < 500)
            {
                return 300;
            }
            else
            {
                return 350;
            }
        }
        public void Sumar(int Entero)
        {
            Capacidad += Entero;
        }
    }
}
