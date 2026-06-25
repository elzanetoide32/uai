using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class EdadException : Exception
    {
        public Persona Persona { get; set; }

    }
}
