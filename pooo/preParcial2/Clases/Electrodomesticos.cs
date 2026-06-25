using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Electrodomesticos
    {
        public string Nombre {  get; set; }
        public bool Encendido { get; set; }
        public string Marca { get;internal set; }
        public abstract int Consumo();

        public void Apagar()
        {
            Encendido = false;
        }
        public void Encender()
        {
            Encendido = true;
        }
    }
}
