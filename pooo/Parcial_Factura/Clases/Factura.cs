using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Clases.Factura;

namespace Clases
{
    
   
    public class Factura 
    {
        public List<ItemFactura> mItems = new List<ItemFactura>();
        public enum TipoFactura { A, B, C }
        public TipoFactura Tipo { get; set; }
        public string Nombre { get; set; }
        public string CUIT {  get; set; }
        public Single Total { 
            get { 
                if ((Tipo == TipoFactura.A || Tipo==TipoFactura.B)&&CUIT==null)
                {
                    throw new CUITObligatorioException(this);
                }
                return mItems.Sum(i => i.Subtotal);
            } }
        public DateTime Fecha { get; set; }
        public Single IVA
        {
            get
            {
                if (Tipo == TipoFactura.A || Tipo == TipoFactura.B)
                    return Total * 0.21f;
                else
                    return 0;
            }
        }
      
        public delegate void DescuentoAplicadoHandler(byte descuento, int cantidadMinima);
        public event DescuentoAplicadoHandler DescuentoAplicado;
        public void AgregarItems(ItemFactura item)
        {
            DescuentoAplicado += item.AplicarDescuento;
            mItems.Add(item);
        }
        public void AplicarDescuento(byte descuento)
        {
            DescuentoAplicado?.Invoke(descuento, 0); // sin cantidad mínima
        }

        public void AplicarDescuento(byte descuento, int cantidadMinima)
        {
            DescuentoAplicado?.Invoke(descuento, cantidadMinima);
        }

    }
}
