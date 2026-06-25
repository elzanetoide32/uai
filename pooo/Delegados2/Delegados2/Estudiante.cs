using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados2
{
    public class Estudiante
    {
        public string Nombre { get; set; }

        public int TiempoRestante { get; private set; }
        public bool HojaSacada { get; private set; } = false;


        /// <summary>
        ///Destino de invocación para el delegado del examen. Todos los alumnos escuchan al profe y cuando dice que arranca el examen, sacan una hoja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EscucharAlProfeInicioDeExamen()
        {
            HojaSacada = true;
        }

        public void EscucharAlProfeTiempoRestante(int pMinutos) //Debe coincidir la firma del destino con la del delegado
        {
          
            TiempoRestante = pMinutos;
        }

    }
}


