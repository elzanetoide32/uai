using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiembrosCompatidos_Clase20260519
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Alumno> mAlumnos = new List<Alumno>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Alumno.Curso = "2A"; //Se ejecuta el constructor de clase (aunque aún no haya instancias)

            Alumno mAlumno1 = new Alumno(); //Se ejecuta el constrctor de instancia
            mAlumno1.Nombre = "Juan";
            mAlumno1.Apellido = "Perez";
            //mAlumno1.Legajo = "123123";

            Alumno mAlumno2 = new Alumno();
            mAlumno2.Nombre = "María";
            mAlumno2.Apellido = "González";
            //mAlumno2.Legajo = "2342342";

            mAlumnos.Add(mAlumno1);
            mAlumnos.Add(mAlumno2);

            grdAlumnos.DataSource = mAlumnos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno.Curso = txtCurso.Text;

            grdAlumnos.DataSource = null;
            grdAlumnos.DataSource = mAlumnos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alumno mAlumno = mAlumnos[0];
            mAlumno.CambiarCurso(txtCurso.Text);

            grdAlumnos.DataSource = null;
            grdAlumnos.DataSource = mAlumnos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alumno mAlumno1 = new Alumno();
            mAlumno1.Nombre = "Pedro";
            mAlumno1.Apellido = "Ramirez";
            //mAlumno1.Legajo = "234243234";
            mAlumnos.Add(mAlumno1);

            grdAlumnos.DataSource = null;
            grdAlumnos.DataSource = mAlumnos;
        }

       
    }
}
