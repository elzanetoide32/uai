using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {

        //public string Nombre;

        private string mNombre; //variable privada que conserva el valor / Valor encapsulado
        public string Nombre
        {
            get //getter = Bloque de código que se ejecuta cuando se lee el valor
            {
                return mNombre;
            }
            set //setter = Bloque de código que se ejecuta cuando se escribe el valor
            {
                if (value == "")
                    mNombre = "Sin nombre"; //Puedo tener ocntrol del getter y setter, por ejemplo, para validaciones
                else
                    mNombre = value;
            }
        }

        //public string Apellido;
        public string Apellido { get; set; } //Forma abreviada de implementar una propiedad (getter y setter resumidos, variable provada encapsulada tácita) - Se puede implementar con prop + Tab + Tab

        //public bool Hambre;
        private bool mHambre;
        /// <summary>
        /// Propiedad de solo lectura (no tiene setter)
        /// </summary>
        public bool Hambre
        {
            get { return mHambre; }
            
        }

        private int mEdad;

        /// <summary>
        /// Propiedad con ámbito diferenciado -> setter privado, significa que se puede leer públicamente pero escribir desde dentro de la misma clase
        /// Solo se puede modificar el ámbito de uno solo de los bloques (getter O setter)
        /// El ámbito que se establezca para uno de los bloques debe ser más restrictivo que el ámbito gerenal de la propiedad (propiedad pública con setter private -> ok; a revés -> NO)
        /// </summary>
        public int Edad
        {
            get { return mEdad; }
            private set { mEdad = value; }
        }



        /// <summary>
        /// Método saludar, con 1 parámetro obligatorio y otro opcional
        /// Genera un saludo diciendo el nombre y si tiene o no hambre
        /// Los parámetros opcionales se especifican con un valor por defecto (= false o = "", etc)
        /// Los parámtros opcionales siempre se implementan después de los obligatorios
        /// </summary>
        /// <returns></returns>
        public string Saludar(string pSaludo, bool pMentirSobreHambre = false)
        {
            string hambre = " y no tengo hambre";
            if (Hambre && !pMentirSobreHambre || !Hambre && pMentirSobreHambre)
                hambre = " y tengo hambre";  

            return pSaludo + ", soy " + Nombre + " " + Apellido  + hambre;
        }

        /// <summary>
        /// Método sin parámetros
        /// </summary>
        public void Comer()
        {
            mHambre = false;
        }

        public void Ayunar()
        {
            mHambre = true;
        }


        /// <summary>
        /// Método sin parámetros
        /// </summary>
        /// <returns></returns>
        public string Despedirse()
        {
            return Despedirse("Chau");
        }

        /// <summary>
        /// Método sobrecargado
        /// Hay dos versiones del mismo método con diferencias en los parámetros de su firma
        /// 
        /// Las sobrecargas solo se logran con diferencias en la CANTIDAD Y/O TIPO de parámetros
        /// </summary>
        /// <param name="pSaludo"></param>
        /// <returns></returns>
        public string Despedirse(string pSaludo)
        {
            return Despedirse(pSaludo, 0);
        }

        /// <summary>
        /// Sobrecarga difereciada por tipo de parámetro
        /// </summary>
        /// <param name="pDias"></param>
        /// <returns></returns>
        public string Despedirse(int pDias)
        {
            return Despedirse("Chau", pDias);
        }

        /// <summary>
        /// Sobrecarga por diferenciación de CANTIDAD Y TIPO de parámetros
        /// </summary>
        /// <param name="pSaludo"></param>
        /// <param name="pDias"></param>
        /// <returns></returns>
        public string Despedirse(string pSaludo, int pDias)
        {
            string mDias = "algunos días";
            if (pDias > 0)
                mDias = pDias + " días";

            return pSaludo + ", se va " + Nombre + " " + Apellido + " por " + mDias;
        }
    }
}
