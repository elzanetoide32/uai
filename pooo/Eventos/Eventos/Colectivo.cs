using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class Colectivo
    {
        int Capacidad = 8;

        public event EventHandler ColectivoLleno; //Declaración del evento que nos avisa cuando se llenó el colectivo

        private List<Pasajero> mPasajeros = new List<Pasajero>();

        public void Subir(Pasajero pPasajero)
        {
            mPasajeros.Add(pPasajero);

            if (mPasajeros.Count >= Capacidad)
                if(ColectivoLleno != null)
                    ColectivoLleno(this, null); //Disparamos el evento para notificar (al que esté suscripto) que el colectivo está lleno
        }

        public List<Pasajero> Pasajeros { get { return mPasajeros; } }

    }
}
