using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holaaa
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Persona> lista = new List<Persona>();///constructor que crea un objeto del tiop listcon elementos tipo persona

        public Persona LeerPersona()
        {
            Persona newPerson = new Persona(); //creo el objeto newPerson
            newPerson.Nombre = txtNombre.Text;
            newPerson.Apellido = txtApellido.Text;
            return newPerson; //devuelve el objeto con los atributos
        }

        public void UpdateList()
        {
            lstLista.Items.Clear(); //clear es un metodo
            ///la lista ya tiene indice, x eso un for
            for(int i = 0; i <= lista.Count - 1; i++)
            {
                lstLista.Items.Add(lista[i].Nombre + " " + lista[i].Apellido);///concateno los nombre y apellidos de lalista con el indice i
            }
            txtApellido.Clear();
            txtNombre.Clear();
            txtNombre.Focus();
        }

        private void btnAgregarAdelante_Click(object sender, EventArgs e)
        {
            lista.Insert(0, LeerPersona()); ///agrega adelante en el indice 0
            UpdateList();
        }

        private void btnAgregarAtras_Click(object sender, EventArgs e)
        {
            lista.Add(LeerPersona()); ///agrega Atras en el indice 0
            UpdateList();
        }

        private void btnEliminarActual_Click(object sender, EventArgs e)
        {
            lista.RemoveAt(lstLista.SelectedIndex);//quita el elemento en el indice seleccionao
            UpdateList();
        }

        private void btnQuitarPrimero_Click(object sender, EventArgs e)
        {
            lista.RemoveAt(0);
            UpdateList();
        }

        private void btnQuitarUltimo_Click(object sender, EventArgs e)
        {
            lista.RemoveAt(lista.Count-1);
            UpdateList();
        }

        private void btnEditarActual_Click(object sender, EventArgs e)
        {
            lista[lstLista.SelectedIndex] = LeerPersona();
            UpdateList();
        }
    }
}
