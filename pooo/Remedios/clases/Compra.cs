using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public delegate void RecetaVerificadaHandler(string Troquel, string Matricula, string NumeroReceta);
    public class Compra:IEnumerable<Remedio>
    {        
        private List<Remedio> mCarrito = new List<Remedio>();
        public RecetaMedica Receta;
        public event RecetaVerificadaHandler RecetaVerificada;
        public void agregar(Remedio mremedio)
        {
            if (mremedio is IRecetable) {

                if (Receta != null) {
                    RecetaVerificada(Receta.NumeroTroquel, Receta.MatriculaProfesional, Receta.NumeroReceta);
                    mCarrito.Add(mremedio);
                } 
                else { throw new Exception("No es posible agregarlo, faltan datos"); }

                    
            }
            
        }

        IEnumerator<Remedio> IEnumerable<Remedio>.GetEnumerator()
        {
            return mCarrito.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return mCarrito.GetEnumerator();
        }

        public IEnumerable<object> ObtenerParaGrilla()
        {
            foreach (Remedio r in mCarrito)
            {
                string infoReceta = "Sin receta";
                if (r is IRecetable)
                {
                    infoReceta = Receta != null ? Receta.NumeroReceta : "Sin receta asignada";
                }
                yield return new
                {
                    r.Nombre,
                    r.Precio,
                    PrecioFinal = r.obraSocial != null ? r.ObtenerPrecio(r.obraSocial.Value) : r.ObtenerPrecio(),
                    ObraSocial = r.obraSocial?.ToString() ?? "Sin obra social",
                    NumeroReceta = infoReceta
                };
            }
        }

        public Single Total()
        {
            Single total = 0;
            foreach (Remedio r in mCarrito)
            {
                if (r.obraSocial != null)
                    total += r.ObtenerPrecio(r.obraSocial.Value); // con descuento
                else
                    total += r.ObtenerPrecio(); // precio normal
            }
            return total;
        }
    }
}
