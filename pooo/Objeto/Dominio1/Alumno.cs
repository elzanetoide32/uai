using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio1
{
    public partial class Alumno
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string NombreCompleto { 
            get {
                return Apellido + "," + Nombre;
            } }
        public float Promedio
        {
            get
            {
                float Prom = (Nota1 + Nota2) / 2;
                return Prom;
            }
        }
        public int Lejago {get; private set; }
        public int pepe { set
            {
                Lejago = value;
            }
        }
        public int Edad { get; set; }
        public float Nota1 {  get; set; }
        public float Nota2 { get; set; }
    
    }
}
