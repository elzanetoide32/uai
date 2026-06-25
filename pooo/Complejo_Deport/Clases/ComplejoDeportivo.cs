using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ComplejoDeportivo:IEnumerable<Reserva>
    {
        private List<Reserva> reservas=new List<Reserva>();

        public delegate void Reservas(int CantidadReservas,int CantidadReservasSeña, double TotalAcobrar);
        public event Reservas ReservaAgregada;

        int señas = 0;
        public void AgregarReserva(Reserva mReserva)
        {
            if (mReserva is IConSenia seña) {
                if (!seña.SeniaAbonada)
                {
                    throw new SeniaRequeridaException("No se abonó la seña", mReserva);
                }
                señas++;
            }
            reservas.Add(mReserva);
            ReservaAgregada(reservas.Count(), señas, reservas.Sum(i => i.CalcularImporte()));
        }

        public IEnumerator<Reserva> GetEnumerator()
        {
            return reservas.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
