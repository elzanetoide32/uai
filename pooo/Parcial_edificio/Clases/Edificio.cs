using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Edificio
    {
        private List<Unidad> mUnidad=new List<Unidad>();

        public string Calle {  get; set; }
        public int Numero {  get; set; }
        // eventos Buscar con dos parámetros de tipo string.
        public delegate void Buscar(string a, string b);
        Buscar mBuscar;

        public delegate void NotificarResultadoDelegate(string datos);
        public event NotificarResultadoDelegate NotificarResultado;
        private Edificio(string calle, int numero)
        {
            Calle = calle;
            Numero = numero;
        }
        public static Edificio CrearEdificio(string calle, int numero)
        {
            return new Edificio(calle, numero);
        }
        public void AgregarUnidad(Unidad unidad)
        {
            mUnidad.Add(unidad);
        }
        public void PropietarioEncontrado(Propietario propietario)
        {

        }
        public void BuscarM(string a, string b)
        {
            mBuscar = null; // limpiar suscripciones anteriores
            foreach (Unidad u in mUnidad)
            {
                mBuscar += u.BuscarUnida;
            }
            mBuscar(a, b);
        }
        public void PropietarioEncontrado(string prop)
        {
            NotificarResultado(prop);
        }
    }
}
