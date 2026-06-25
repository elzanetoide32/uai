using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dominio1
{
    public partial class Alumno
    {
        ////metodos////
        ///Crear los siguientes métodos en la clase:
        //• MostrarResumen()
        //Debe devolver un texto con todos los datos del alumno
        //• Aprobo(double notaMinima)
        //Debe devolver `true` o `false`
        //• Saludar(string mensaje = "Hola")
        //Debe devolver un saludo para el alumno
        //• Sobrecargas de `CargarNotas`:
        //`CargarNotas(double nota1, double nota2)`
        //`CargarNotas(double nota1, double nota2, double extra)`d

        public void MostrarResumen()
        {

        }
        public string Aprobo(double notaMinima)
        {
            if (Promedio >= notaMinima)
            {
                return "Aprobo";
            }
            else
            {
                return "No Aprobo";
            }
        }
        public String Saludar(string mensaje = "Hola")
        { 
            return mensaje;
        }
        ////sobrecarga
        public void CargarNotas(double nota1, double nota2)
        {

        }
        public void CargarNotas(double nota1, double nota2, double extra)
        {

        }
    }
}
