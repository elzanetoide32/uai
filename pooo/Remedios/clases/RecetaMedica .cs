using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class RecetaMedica:IRecetable
    {
        public string NumeroReceta { get; set; }
        public string MatriculaProfesional { get; set; }
        public string NumeroTroquel { get; set; }

        public RecetaMedica(string numeroReceta, string matricula, string troquel)
        {
            NumeroReceta = numeroReceta;
            MatriculaProfesional = matricula;
            NumeroTroquel = troquel;
        }
    }
}
