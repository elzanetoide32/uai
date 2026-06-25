using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialA
{
    public class Carrito : Exception  ////hereda de exception
    {
        public List<Producto> mCarrito = new List<Producto>();
        public float total { get; set; }
        public int count {  get; set; }
        public event EventHandler LLamarPersonal; //Declaración del evento 
        public void Agregar(Producto producto) 
        {

            mCarrito.Add(producto);
            if (int.Parse(producto.Precio) > 5000)
            {
                ////llamar a personal
                LLamarPersonal(this, null);
            }
            total += float.Parse(producto.Precio);
            count += 1;          
            
            if (count >= 10)
            {
                ////lanzar excepcion
                Carrito es = new Carrito();
                throw es;
            }
        }
        public void HandlerCobrar(object Sender, EventArgs e)
        {
            foreach (Producto p in mCarrito)
                p.Cobrar();
        }

        public void Cobrar()
        {
            foreach (Producto p in mCarrito)
                p.Cobrar();
        }
        public void Cobrar(int Desc)
        {
            int pepe = 0;
            foreach (Producto p in mCarrito)
            {
                pepe += int.Parse(p.Precio) * (Desc / 100);
                p.Cobrar();
            }
            }
        }


}
