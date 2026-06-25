using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class AireAcondicionado : Electrodomesticos
    {
        public int frigorias { get; set; }
        public enum tipo { inverter, comun }
        public tipo Tipo { get; set; }

        public override int Consumo()
        {
            double consumo = 1000 + (frigorias / 2.0);
            if (Tipo == tipo.inverter)
                consumo *= 0.80;
            return (int)consumo;  // casteas al final
        }
        }
    }

