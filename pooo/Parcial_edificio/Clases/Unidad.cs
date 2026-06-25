using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Unidad
    {
        private List<Propietario> propietarios=new List<Propietario>();
        public string Nombre {  get; set; }
        public Edificio Edificio { get; }
        public delegate void BuscarDelegate(string a, string b);
        BuscarDelegate mBuscar;


        //constructor
        public Unidad(Edificio edificio)
        {
            Edificio = edificio;
        }

        public void AgregarPropietario(string nombre, string apellido, string telefono)
        {
            propietarios.Add(new Propietario(this) { Nombre = nombre, Apellido = apellido, Telefono = telefono});
        }
        public void AgregarPropietario(Propietario mPropietario)
        {
            mPropietario.UnidadFuncional = this;
            propietarios.Add(mPropietario);
        }

        public void BuscarUnida(string a, string b)
        {
            foreach (Propietario p in propietarios)
            {
                // suscribir el evento de cada propietario al método de Edificio
                p.Encontrado += Edificio.PropietarioEncontrado;
                p.Verificar(a, b);
                p.Encontrado -= Edificio.PropietarioEncontrado; // limpiar después
            }
        }
    }
}
