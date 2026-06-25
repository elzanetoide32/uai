using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class PrestamoBiblioteca:Exception,IEnumerable<MaterialBiblioteca>
    {
        private List<MaterialBiblioteca> materialesPresados=new List<MaterialBiblioteca>();

        public delegate void Prestado(int materiales, int Materiales_rest, int Devolucion);
        public event Prestado MaterialPrestado;

        int Materiales_rest, Devolucion;
        public void PrestarMaterial(MaterialBiblioteca materialBiblioteca)
        {
            if(materialBiblioteca is IConsultaRestringida consulta)
            {
                if (string.IsNullOrEmpty(consulta.CodigoAutorizacion))
                {
                    Materiales_rest++;
                    throw new Exception("no esta autorizado");                    
                }
            }

            materialesPresados.Add(materialBiblioteca);
            Devolucion = materialBiblioteca.CalcularDiasPrestamo();
            MaterialPrestado(materialesPresados.Count(), Materiales_rest, Devolucion);


        }
        public IEnumerator<MaterialBiblioteca> GetEnumerator()
        {
            return materialesPresados.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
