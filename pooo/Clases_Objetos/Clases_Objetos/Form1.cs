using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Dominio.Animales;

namespace Clases_Objetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona pers1 = new Persona();
            pers1.Nombre = "Juan"; // Asigno un valor a la propiedad (a través de setter)
            pers1.Apellido = "Perez";
            //pers1.Hambre = false; //no puedo escribir esta propiedad porque es de solo lectura (no tiene setter)
            pers1.Comer();

            //Persona pers2 = pers1; //Tipos por referencia. Acá estoy simplemente copiando el puntero a la misma instancia
            Persona pers2 = new Persona();
            pers2.Nombre = "María";
            pers2.Apellido = "González";
            pers2.Ayunar();
            //pers2.Hambre = true;  //no puedo escribir esta propiedad porque es de solo lectura (no tiene setter)

            MessageBox.Show(pers1.Saludar("Hola", true)); //Cada objeto mantiene su estado (valores de sus atributos) diferente al de otros objetos

            string mNombrePersona1 = pers1.Nombre; //Leo una propiedad a través del getter

            MessageBox.Show(pers2.Saludar("Buenas"));

            pers2.Comer(); //El comportamiento puede modificar el estado

            MessageBox.Show(pers2.Saludar("Hola otra vez"));


            Perro mPerro = new Perro(); //Clase parcial en dos archivos(termina compilándose y comprtándose como una sola) - Clase dentro de un sub-namespace

            //Distintas llamadas a las diferentes sobrecargas del método Despedirse
            MessageBox.Show(pers1.Despedirse());

            MessageBox.Show(pers1.Despedirse("Nos vemos"));

            MessageBox.Show(pers1.Despedirse(5));

            MessageBox.Show(pers1.Despedirse("Chauchis", 10));


        }
    }
}
