using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pepe
{
    public partial class btnUp: Form
    {
        public btnUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream archivo = new FileStream("D:/archvo.txt", FileMode.Append);///ruta(relativa o explicita),filemode   ///crear el archivo
                StreamWriter escritor = new StreamWriter(archivo);
                string registro;
                registro = txtLegajo.Text + ";" + txtApellido.Text + ";" + txtCat.Text;
                escritor.WriteLine(registro);
                escritor.Close();
                archivo.Close();
                Listar();
                Limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("no se pudo dar de alta al usuario", "mesaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Limpiar()
        {
            txtCat.Clear();
            txtLegajo.Clear();
            txtApellido.Clear();
            txtLegajo.Focus();
        }
        public void Listar()
        {
            FileStream archivo = new FileStream("D:/archvo.txt", FileMode.OpenOrCreate));
            StreamReader lector = new StreamReader(archivo);
            lstListado.Items.Clear();
            string registro;
            String[] vectorAux;
            string legajo, nombre, cat,renglon;
            while (lector.Peek() > -1){
                registro = lector.ReadLine();
                vectorAux = registro.Split(';');///le paso el valor que me separa los valores
                legajo = vectorAux[0];
                nombre = vectorAux[1];
                cat = vectorAux[2];
                renglon = legajo +";"+ nombre +";"+ cat;
                lstListado.Items.Add(renglon);
            }
            lector.Close();
            archivo.Close();
        }

        private void btnUp_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream("D:/archvo.txt", FileMode.Open);
            FileStream archivoAux = new FileStream("D:/archvAuxo.txt", FileMode.Create);///archivo temp
            StreamReader lector = new StreamReader(archivo);///leo el original
            StreamWriter escritor = new StreamWriter(archivoAux);///escribo el aux
            string[] vectorAux;
            string legajo,registro;
            while (lector.Peek() > -1)
            {
                registro = lector.ReadLine();
                vectorAux = registro.Split(';');
                legajo = vectorAux[0];
                if (legajo != txtLegajo.Text)
                {
                    escritor.WriteLine(registro);
                }
            }
            lector.Close();
            escritor.Close();
            archivoAux.Close();
            archivo.Close();
            ////el archivoAux ahora archivo
            File.Delete("D:/archvo.txt");
            File.Move("D:/archvoAux.txt", "D:/archvo.txt");
            Listar();
            Limpiar();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream("D:/archvo.txt", FileMode.Open);
            FileStream archivoAux = new FileStream("D:/archvAuxo.txt", FileMode.Create);///archivo temp
            StreamReader lector = new StreamReader(archivo);///leo el original
            StreamWriter escritor = new StreamWriter(archivoAux);///escribo el aux
            string[] vectorAux;
            string legajo, registro;
            while (lector.Peek() > -1)
            {
                registro = lector.ReadLine();
                vectorAux = registro.Split(';');
                legajo = vectorAux[0];
                if (legajo == txtLegajo.Text)
                {
                    registro = txtLegajo.Text + ";" + txtApellido.Text + ";" + txtCat.Text;
                }
            }
            lector.Close();
            escritor.Close();
            archivoAux.Close();
            archivo.Close();
            ////el archivoAux ahora archivo
            File.Delete("D:/archvo.txt");
            File.Move("D:/archvoAux.txt", "D:/archvo.txt");
            Listar();
            Limpiar();
        }

        private void lstListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string renglon;
            string[] vectorAux;
            renglon = lstListado.SelectedItem.ToString();
            vectorAux = renglon.Split(';');
            txtLegajo.Text = vectorAux[0];
            txtApellido.Text = vectorAux[1];
            txtCat.Text = vectorAux[2];
        }
    }
}
