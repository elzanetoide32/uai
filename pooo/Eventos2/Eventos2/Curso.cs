using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos2
{
    public class Curso
    {

        private List<Estudiante> mEstudiantes = new List<Estudiante>();

        public void Ingrear(Estudiante pEstudiante)
        {
            mEstudiantes.Add(pEstudiante);
            SacarUnaHoja += pEstudiante.EscucharAlProfeInicioDeExamen;//Asociamos el handler al evento. A partir de este momento este estudiante que ingresa está escuchando al profesor
            InformarTiemporestante += pEstudiante.EscucharAlProfeTiempoRestante;
        }

        public event EventHandler SacarUnaHoja;//Declaramos el evento

        public event EventHandler InformarTiemporestante;//Segundo evento (que va a necesitar un parámetro porque le tenemos que informar a los aumons el tiempo que les queda)


        public void IniciarExamen()
        {
            SacarUnaHoja(this, null); //Disparamos el evento para que los alumnos escuchen y saquen una hoja
        }

        public void InformarTiempo(int pMinutos)
        {
            EventArgsTiempo e = new EventArgsTiempo(); //Para mandar un parámetro por el evento, tengo que encapsular (meter) el parámetro en algo que sea del tipo EventArgs. Uso mi propia clase que hereda de EventAgrs
            e.Tiempo = pMinutos; 

            if(InformarTiemporestante != null)
                InformarTiemporestante(this, e); //Envío mi propio objeto EventArgsTiempo con el tiempo dentro
        }

        public List<Estudiante> Alumnos { get { return mEstudiantes; } }
    }

    public class EventArgsTiempo : EventArgs
    {
        public int Tiempo { get; set; }
    }
}
