using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio1;

namespace Objeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Alumno alumno = new Alumno();
        private void Form1_Load(object sender, EventArgs e)
        {
   
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Saludar());
            MessageBox.Show(alumno.Saludar("Bienvenido"));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int legajo = rnd.Next(1, 100);
            alumno.Nombre = txtNombre.Text;
            alumno.Apellido=txtApellido.Text;
            alumno.Edad = int.Parse(txtEdad.Text);
            alumno.Nota1=int.Parse(txtNota1.Text);
            alumno.Nota2=int.Parse(txtNota2.Text);
            alumno.pepe = legajo;
            MessageBox.Show("Alumno Creado Correctamente");
        }

        private void btnAprobo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Aprobo(4));
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    $"Nombre: {alumno.Nombre}\n" +
    $"Apellido: {alumno.Apellido}\n" +
    $"Edad: {alumno.Edad}\n" +
    $"Nota 1: {alumno.Nota1}\n" +
    $"Nota 2: {alumno.Nota2}"
);
        }
    }
}
