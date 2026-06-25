using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class SeniaRequeridaException : Exception
    {
        public Reserva Reserva { get; }

        public SeniaRequeridaException(string mensaje, Reserva reserva) : base(mensaje)
        {
            Reserva = reserva;
        }
    }
}
