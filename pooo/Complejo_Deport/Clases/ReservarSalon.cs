using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ReservarSalon:Reserva, IConSenia
    {
        public bool Catering {  get; set; }

        public double ImporteSenia => CalcularImporte()*0.3;
        public bool SeniaAbonada { get; set; }
        public ReservarSalon(string nombre, string fecha, int hora, int duracion, bool cat, bool seniaAbonada) : base(nombre, fecha, hora, duracion)
        {
            Catering = cat;
            SeniaAbonada = seniaAbonada;
        }

        public override double CalcularImporte()
        {
            double bace = 20000;
            if (Catering)
            {
                bace += bace * 0.5;
            }
            return bace;
        }
    }
}
