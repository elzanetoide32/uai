using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoUno
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lista lista = new Lista();//instancio la clase con el constructor
        //la lista esta vacia al principio

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            Nodo nodo = new Nodo();
            nodo.Nombre = txtNombre.Text;
            lista.AgregarAdelante(nodo); ///le paso el nodo que cree a la lista ya creada
            MostrarLista();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Nodo nodo = new Nodo();
            nodo.Nombre = txtNombre.Text;
            lista.AgregarAtras(nodo); ///le paso el nodo que cree a la lista ya creada
            MostrarLista();
        }
        ///mostrarlo
        public void MostrarLista() ///solo muestra
        {
            lstLista.Items.Clear();///limpiaar el list
            AddItems(lista.Inicio); ///le paso el nodo inicio de la lista a la funcion
        }
        ///clase para recursividar
        public void AddItems(Nodo _Nodo)
        {
            if (_Nodo != null)
            {
                lstLista.Items.Add(_Nodo.Nombre);
                AddItems(_Nodo.Siguiente);
            }
        }
    }
}
