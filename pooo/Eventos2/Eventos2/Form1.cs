using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Curso mCurso = new Curso();
        private void Form1_Load(object sender, EventArgs e)
        {
            grdEstudiantes.Columns.Add("Nombre", "Nombre");
            grdEstudiantes.Columns.Add("HojaSacada", "Hoja sacada");
            grdEstudiantes.Columns.Add("TiempoRestante", "Tiempo R.");
            grdEstudiantes.AllowUserToAddRows = false;
            grdEstudiantes.RowHeadersVisible = false;
            
            mCurso.Ingrear(new Estudiante() { Nombre = "Juan" });
            mCurso.Ingrear(new Estudiante() { Nombre = "María" });
            mCurso.Ingrear(new Estudiante() { Nombre = "Pedro" });

            Actualizar();
        }

        private void Actualizar()
        {
            grdEstudiantes.Rows.Clear();

            foreach (Estudiante mEst in mCurso.Alumnos)
            {
                grdEstudiantes.Rows.Add(mEst.Nombre, mEst.HojaSacada, mEst.TiempoRestante);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante mEstudiante = new Estudiante();
            mEstudiante.Nombre = txtNombre.Text;
            mCurso.Ingrear(mEstudiante);

            Actualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mCurso.IniciarExamen();
            Actualizar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mCurso.InformarTiempo(int.Parse(txtMinutos.Text));
            Actualizar();
        }
    }
}
