using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados2
{
    public class Curso
    {

        private List<Estudiante> mEstudiantes = new List<Estudiante>();

        public void Ingrear(Estudiante pEstudiante)
        {
            mEstudiantes.Add(pEstudiante);
            SacarUnaHoja += pEstudiante.EscucharAlProfeInicioDeExamen;//Asociamos el destino de invocación al delegado. A partir de este momento este estudiante que ingresa está escuchando al profesor
            InformarTiemporestante += pEstudiante.EscucharAlProfeTiempoRestante;
        }

        public delegate void SacarUnaHojaDelegate();//Declaramos el tipo del delegado
        SacarUnaHojaDelegate SacarUnaHoja; //Declaramos la variable del tipo del delegado

        public delegate void InformarTiemporestanteDelegate(int pMinutos) ;//Segundo delegate (que va a necesitar un parámetro porque le tenemos que informar a los aumons el tiempo que les queda)
        InformarTiemporestanteDelegate InformarTiemporestante;

        public void IniciarExamen()
        {
            SacarUnaHoja(); //Disparamos el delegate para que los alumnos escuchen y saquen una hoja
        }

        public void InformarTiempo(int pMinutos)
        {
          

            if (InformarTiemporestante != null)
                InformarTiemporestante(pMinutos);
        }

        public List<Estudiante> Alumnos { get { return mEstudiantes; } }
    }

   
}
