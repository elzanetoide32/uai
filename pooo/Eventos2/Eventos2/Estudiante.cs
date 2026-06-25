using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos2
{
    public class Estudiante
    {
        public string Nombre { get; set; }

        public int TiempoRestante { get; private set; }
        public bool HojaSacada { get; private set; } = false;


        /// <summary>
        /// Handler para el evento del examen. Todos los alumnos escuchan al profe y cuando dice que arranca el examen, sacan una hoja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EscucharAlProfeInicioDeExamen(object sender, EventArgs e)
        {
            HojaSacada = true;
        }

        public void EscucharAlProfeTiempoRestante(object sender, EventArgs e) //recibe el EventArgsTiempo en la parámetro e
        {
            int pTiempo = ((EventArgsTiempo)e).Tiempo; //Extraigo el tiempo de la propiedad de EventArgsTiempo (e los casteo a mi tipo EventsArgsTiempo para poder ver la propiedad Tiempo)

            TiempoRestante = pTiempo;
        }

    }
}
