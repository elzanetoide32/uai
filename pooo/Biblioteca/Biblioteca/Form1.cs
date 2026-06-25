using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clases;
namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PrestamoBiblioteca prestamo=new PrestamoBiblioteca();
        private void Form1_Load(object sender, EventArgs e)
        {
            prestamo.MaterialPrestado += evento_biblio;

            Tesis tesis = new Tesis("pepito","pedro sanches",1950,"UAI");
            prestamo.PrestarMaterial(tesis);

            Revista revista = new Revista("Metegol", "susana sanches", 1950,50);
            prestamo.PrestarMaterial(revista);

            Libro libro = new Libro("Corazon delator", "Cortaza", 2000,"terror");
            prestamo.PrestarMaterial(libro);

            cmbTipo.DataSource = new string[] { "libro", "revista", "tesis" };
            txtGenero.Enabled = false;
            txtUniversidad.Enabled = false;
            txtEdicion.Enabled = false;
            Actualizar();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex ==0)
            {
                
                txtGenero.Enabled = true;
                txtUniversidad.Enabled = false;
                txtEdicion.Enabled = false;
            }
            else if (cmbTipo.SelectedIndex == 2)
            {
                txtGenero.Enabled = false;
                txtUniversidad.Enabled = true;
                txtEdicion.Enabled = false;
            }
            else if (cmbTipo.SelectedIndex == 1)
            {
                txtGenero.Enabled = false;
                txtUniversidad.Enabled = false;
                txtEdicion.Enabled = true;
            }
        }


        public void Actualizar()
        {
            dataGridView1.DataSource = 0;
            dataGridView1.DataSource = prestamo.ToList();
        }
        public void evento_biblio(int materiapesP,int materialesRest ,int Devoluciones)
        {
            lblMateriales.Text = materiapesP.ToString();
            lblRest.Text = materialesRest.ToString();
            lblDevo.Text = Devoluciones.ToString();
        }
        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAño.Text, out int anio))
            {
                MessageBox.Show("El año ingresado no es válido.");
                return;
            }
            
            MaterialBiblioteca material=null;

            if(cmbTipo.SelectedIndex == 0)
            {
                material = new Libro(txtTitulo.Text,txtAutor.Text,int.Parse(txtAño.Text),txtGenero.Text);
            }else if (cmbTipo.SelectedIndex == 1)
            {
                material = new Revista(txtTitulo.Text, txtAutor.Text, int.Parse(txtAño.Text),int.Parse(txtEdicion.Text));
            }else if (cmbTipo.SelectedIndex == 2)
            {
                material = new Tesis(txtTitulo.Text, txtAutor.Text, int.Parse(txtAño.Text),txtUniversidad.Text);
            }

            try
            {
                prestamo.PrestarMaterial(material);
                MessageBox.Show($"Préstamo registrado. Devolución: {material.CalcularDiasPrestamo():d}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtUniversidad.Clear();
            txtTitulo.Clear();
            txtGenero.Clear();
            txtEdicion.Clear();
            txtAño.Clear();
            txtAutor.Clear();
            
            Actualizar();
        }
    }
}
