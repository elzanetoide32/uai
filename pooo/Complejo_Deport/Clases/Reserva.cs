using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Reserva
    {
        public string NombreCliente {  get; set; }
        public string Fecha {  get; set; }
        public int Hora {  get; set; }
        public int DuracionHoras {  get; set; }
        public Reserva(string nombre,string fecha,int hora,int duracion)
        {
            NombreCliente = nombre;
            Fecha = fecha;
            Hora = hora;
            DuracionHoras = duracion;
        }
        public virtual double CalcularImporte()
        {
            return 0;
        }
    }
}
