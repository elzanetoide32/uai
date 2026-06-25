using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    
    public class ItemFactura
    {
        private byte mDescuento;
        public string Producto { get; }
        public int Cantidad { get; set; }
        public Single PrecioUnitario { get; set; }
        public byte Descuento => mDescuento;
        public Single Subtotal {  get; set; }
        /// <summary>
        /// constructor con parametros produccto
        /// </summary>
        public ItemFactura(string mProducto)
        {
            Producto=mProducto;
        }
        /// <summary>
        /// constructor con parametros producto y cantidad
        /// </summary>
        public ItemFactura(string mProducto,int mCantidad)
        {
            Producto = mProducto;
            Cantidad=mCantidad;
        }
        public void AplicarDescuento(byte descuento, int cantidadMinima)
        {
            if (cantidadMinima == 0 || Cantidad >= cantidadMinima)
                mDescuento = descuento;
        }
    }
}
