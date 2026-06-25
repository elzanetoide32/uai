using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class RESTAURANTE: Exception
    {
        private List<MESA> mMesa=new List<MESA>();
        int CantMesa=3; //hacerla con static
        public void AgregarMesa(MESA mmesa)
        {
            if (mMesa.Count() <= CantMesa)
            {
                mMesa.Add(mmesa);
            }
            else
            {
                throw new Exception("Cantidad de mesas llenas");
            }
        }

        private double costoTotal = 0;
        public double CostoTotal ///readonly
        {
            get { return costoTotal; }
        }

        public PLATO SacarPlato(COCINERO mcocinero)
        {
            PLATO plato = mcocinero.PrepararPlato();
            costoTotal += plato.Costo();
            return new PLATO();
        }
    }
}
