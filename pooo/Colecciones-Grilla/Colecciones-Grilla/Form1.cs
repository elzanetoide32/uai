using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecciones_Grilla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public enum TipoOperacion { Alta, Modificacion};
        TipoOperacion mOperacion;

        //public enum Colores {Rojo, Verde, Azul, Amarillo };
        //Colores mColor;


        //private List<string> mListatextos = new List<string>();
        //private List<int> mListaNumeros = new List<int>();

        private List<Persona> mListaPersonas = new List<Persona>();

        private void Form1_Load(object sender, EventArgs e)
        {

            //mListatextos.Add("Hola");
            //mListaNumeros.Add(5);


            //Persona p = new Persona() { Nombre = "Juan", Apellido = "Perez" };

            //mListaPersonas.Add(p);
            //mListaPersonas.Add("Juan");


            grdPersonas.Columns.Add("Nombre", "Nombre");
            grdPersonas.Columns["Nombre"].Width = 200;
            grdPersonas.Columns["Nombre"].DataPropertyName = "Nombre";

            grdPersonas.Columns.Add("Apellido", "Apellido");
            grdPersonas.Columns["Apellido"].DataPropertyName = "Apellido";

            grdPersonas.RowHeadersVisible = false;
            grdPersonas.AllowUserToAddRows = false;
            grdPersonas.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdPersonas.MultiSelect = false;

            grdPersonas.AutoGenerateColumns = false;


            mListaPersonas.Add(new Persona() {Nombre =  "Juan", Apellido = "Perez" });
            mListaPersonas.Add(new Persona() { Nombre = "María", Apellido = "González" });
            mListaPersonas.Add(new Persona() { Nombre = "Pedro", Apellido = "Gimenez" });
            mListaPersonas.Add(new Persona() { Nombre = "Ana", Apellido = "Fernández" });

            
            Actualizar();
        }

        private void Actualizar()
        {
            //grdPersonas.Rows.Clear();

            //foreach (Persona p in mListaPersonas)
            //    grdPersonas.Rows.Add(p.Nombre, p.Apellido);


            grdPersonas.DataSource = mListaPersonas;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(grdPersonas.SelectedRows.Count > 0)
            {
                txtNombre.Text = grdPersonas.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtApellido.Text = grdPersonas.SelectedRows[0].Cells["Apellido"].Value.ToString();

                mOperacion = TipoOperacion.Modificacion;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (mOperacion)
            {
                case TipoOperacion.Alta:
                    mListaPersonas.Add(new Persona() { Nombre = txtNombre.Text, Apellido = txtApellido.Text });
                    Actualizar();
                    break;

                default:
                    if (grdPersonas.SelectedRows.Count > 0)
                    {
                        int mIndice = grdPersonas.SelectedRows[0].Index;
                        Persona mPers = mListaPersonas[mIndice];

                        mPers.Nombre = txtNombre.Text;
                        mPers.Apellido = txtApellido.Text;

                        Actualizar();
                    }
                    break;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";

            mOperacion = TipoOperacion.Alta;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(grdPersonas.SelectedRows.Count > 0)
            {
                Persona p = (Persona)grdPersonas.SelectedRows[0].DataBoundItem;

                MessageBox.Show("Seleccionó a " + p.Nombre + " " + p.Apellido);
            }


        }
    }
}
