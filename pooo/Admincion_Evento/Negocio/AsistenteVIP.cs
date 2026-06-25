using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AsistenteVIP:Asistente,Iinvitado
    {
        public AsistenteVIP(string nombre,string apellido):base(nombre,apellido)
        {

        }
        public string CodigoInvitacion => "Codigo de Asistente Vip";
        public override string AbonarEntrada()
        {
            throw new Exception("No tengo que abonar");
        }
    }
}
