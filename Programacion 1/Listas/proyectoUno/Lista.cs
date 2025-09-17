using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoUno
{
    public class Lista
    {
        public Nodo Inicio;      //genero la propiedad de donde voy a partir, variable del tipo nodo
        ///metodos para los botones
        //////void porque no devuelve nada
        public void AgregarAdelante(Nodo _Nodo)
        { ///(tipo d dato, Nombre)
            //2 opciones: cuando la lista este vacia, o que tenga ya nodo
            if (Inicio == null)
            { //cuando estoy en el comienzo de la ista
                Inicio = _Nodo; //agrego ainicio los datos de _Nodo
            }
            else
            {
                Nodo aux = Inicio;///guardo en aux el nodo inicio
                Inicio = _Nodo;///el nuevo nodo lo pongo en inicio
                _Nodo.Siguiente = aux; ///el nuevo nodo apunta al viejo inicio
            }
        }
        public void AgregarAtras(Nodo _Nodo)
        {
            ///que este vacio o que este lleno
            if (Inicio == null)
            {
                Inicio = _Nodo;
            }
            else
            {
                ///se aplica recursividad para ver el ultimo de la lista
                
                Nodo aux = BuscarUltimo(Inicio);///el nodo que me devuelve lo guardo en aux
                aux.Siguiente = _Nodo;//y el ultimo apunta a mi nodo
            }
        }
        public Nodo BuscarUltimo(Nodo _Nodo) //te devulve el ultimo nodo
        {
            if (_Nodo.Siguiente == null) ///encontre el ultimo
            {
                return _Nodo; //devuelve el nodo en el que estoy osea el ultimo
            }
            else
            {
                return BuscarUltimo(_Nodo.Siguiente); //vuelvo a llamar de nuevo a la funcion con el siguiente nodo
            }
        }
    }
}
