using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Propietario
    {
        public string Nombre {  get; set; }
        public string Apellido { get; set; }
        public string Telefono {  get; set; }
        public Unidad UnidadFuncional { get; internal set; }

        /// <summary>
        /// delegate
        /// </summary>
        /// <param name="nombre"></param>
        public delegate void PropietarioEncontrado(string datos);
        public PropietarioEncontrado Encontrado;

        public Propietario(Unidad mUnidad)
        {
            UnidadFuncional=mUnidad;
        }

        public void Verificar(string mNombre, string mApellido)
        {
            ////lanzar evento PropietarioEncontrado con un parámetro de tipo string
            /*string mNombre= Dirección, Unidad, Telefono, Nombre y Apellido
            Encontrado();*/
            if (Nombre == mNombre && Apellido == mApellido)
            {
                string datos = $"Calle: {UnidadFuncional.Edificio.Calle} {UnidadFuncional.Edificio.Numero} " +
                               $"| Unidad: {UnidadFuncional.Nombre} " +
                               $"| Nombre: {Nombre} {Apellido} " +
                               $"| Teléfono: {Telefono}";
                Encontrado(datos);
            }
        }
    }
}
