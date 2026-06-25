using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class RedElectrica
    {
        public delegate void CorteDeCorriente();
        public event CorteDeCorriente OnCorteDeCorriente;

        public delegate void Encendido();
        public event Encendido encedidoDeCorriente;

        private List<Electrodomesticos> mElectrodomesticos = new List<Electrodomesticos>();
        public List<Electrodomesticos> Electro {get{ return mElectrodomesticos; } }
        public void agregar(Electrodomesticos electro)
        {
            electro.Marca = "ACME ";
            mElectrodomesticos.Add(electro);
            OnCorteDeCorriente += electro.Apagar;
            encedidoDeCorriente += electro.Encender;
        }
        public void cortarCorriente()
        {
            OnCorteDeCorriente.Invoke();
        }
        public void Encender()
        {
            encedidoDeCorriente.Invoke();
        }
    }
}
