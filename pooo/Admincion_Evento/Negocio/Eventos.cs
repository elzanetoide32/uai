using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Eventos : IEnumerable<Asistente>
    {
        private List<Asistente> mAsistente = new List<Asistente>(); ///tiene que or privada
        private List<PersonalEvento> mPersonal = new List<PersonalEvento>(); //tiene que ir privada

        public List<Asistente> Asistentes { get { return mAsistente; } }
        public List<PersonalEvento> Personal { get { return mPersonal; } }


        public delegate void PersonaArribo(int pAsistentes,int pPersonal);
        public event PersonaArribo ArriboPersona;
        public void RecibirPersona(Persona persona)
        {
            // a) Chequeo de invitación vs cobro de entrada
            if (persona is Iinvitado invitado)
            {
                Console.WriteLine($"Código de invitación: {invitado.CodigoInvitacion}");
            }
            else
            {
                persona.AbonarEntrada();
            }

            // b) Chequeo de tipo concreto para agregar a la colección correspondiente
            if (persona is Asistente asistente)
            {
                mAsistente.Add(asistente);
            }
            else if (persona is PersonalEvento personalEvento)
            {
                mPersonal.Add(personalEvento);
            }


            ArriboPersona(mAsistente.Count(),mPersonal.Count());
        }

        public IEnumerator<Asistente> GetEnumerator()
        {
            return mAsistente.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
