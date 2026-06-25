using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Clases.ReservarCancha;

namespace Clases
{
    public class ReservarPileta:Reserva
    {
        public int CantidadPersona {  get; set; }
        public ReservarPileta(string nombre, string fecha, int hora, int duracion, int cant) : base(nombre, fecha, hora, duracion)
        {
            CantidadPersona = cant;
        }
        public override double CalcularImporte()
        {
            double importe = 3000 * CantidadPersona;
            return importe;
        }
    }
}
