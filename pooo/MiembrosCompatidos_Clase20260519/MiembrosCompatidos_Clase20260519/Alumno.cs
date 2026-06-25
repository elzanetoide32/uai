using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiembrosCompatidos_Clase20260519
{
    public class Alumno
    {

        public Alumno() // Contsructor de instancia. Se ejecuta cada vez que creamos una instancia
        {
            Legajo = "L" + UltimoLegajo.ToString();
            UltimoLegajo += 1;//Dejo preparado el próximo legao para el próximo alumno
        }

        static Alumno() //Constructor de clase. Se ejecuta la primera vez (solo una) que se USA la clase, para crear una instancia o para referenciar un miembro de clase.
        {

        }

        private static int UltimoLegajo = 1000; //Recordamos el último legajo en un miembro de clase (compartido). todas las inactancias verán el  mismo valor

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Legajo { get; set; }

        public string CursoActual { get { return Curso; } } //Expongo el miembro de clase (compartido) a través de un miembro de instancia porque sino la grilla no lo muestra

        public static string Curso { get; set; }// Miebro de clase (compartido). Todas las inatancias ven su valor


        public void CambiarCurso(string pCurso)
        {
            Alumno.Curso = pCurso; //Desde un miembro de instancia (CambiarCurso) puedo acceder a un miembro compartido (Curso)
        }

        public static void CambiarNombre(string pNombre)
        {

            //Nombre = pNombre; //No puedo acceder a un miebro de instancia desde un miembro de clase, porque no sabría a qué instancia de Alumno debo cambiarle el nombre
        }

        //public void ArruinarLegajos()
        //{
        //    UltimoLegajo = -1000;
        //}

    }
}
