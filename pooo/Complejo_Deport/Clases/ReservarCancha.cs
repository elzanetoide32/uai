using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ReservarCancha:Reserva,IConSenia
    {
        public enum tipo { futbol,tenis,padel}
        public tipo Tipo;

        public double ImporteSenia => CalcularImporte() * 0.3;
        public bool SeniaAbonada { get; set; }
        public ReservarCancha(string nombre, string fecha, int hora, int duracion,tipo tipo, bool seniaAbonada) :base(nombre,fecha,hora,duracion)
        {
            Tipo = tipo;
            SeniaAbonada = seniaAbonada;
        }

        public override double CalcularImporte()
        {
            double bace = 8000;
            switch (Tipo) { 
            case tipo.tenis:
                    bace += bace * 0.2;
                    break;
            case tipo.padel:
                    bace += bace * 0.3;
                    break;            
            }
            return bace;
        }
    }
}
