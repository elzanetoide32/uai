using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public sealed class Televisor: Electrodomesticos
    {
        public int Pulgadas {  get; set; }

        public override int Consumo()
        {
            return 100 + Pulgadas;
        }
    }
}
