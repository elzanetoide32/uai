using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PersonalEvento:Persona,Iinvitado
    {
        public string Cargo { get; set; }
        public string CodigoInvitacion => Cargo;
        public PersonalEvento(string nombre, string apellido,string cargo) : base(nombre, apellido)
        {
            Cargo = cargo;
        }
        

        public override string AbonarEntrada()
        {
            throw new Exception("No tengo que abonar");
        }
    }
}
