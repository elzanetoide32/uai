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
namespace Remedios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Compra mCompra = new Compra();
        private void Form1_Load(object sender, EventArgs e)
        {
            mCompra.RecetaVerificada += Compra_RecetaVerificada;

            
            
        }
        private void Compra_RecetaVerificada(string troquel, string matricula, string numeroReceta)
        {
            MessageBox.Show($"Receta verificada:\nTroquel: {troquel}\nMatrícula: {matricula}\nN° Receta: {numeroReceta}");
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("se ha realizado la compra");
            Borrar();
        }

        public void actualizar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource= mCompra.ObtenerParaGrilla().ToList(); 
            lblTotal.Text = $"Total: ${mCompra.Total()}";
        }

        public void Borrar()
        { 
            dataGridView1.DataSource = null;
            lblTotal.Text = "Total: 0";
            actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {           
            try
            {
                mCompra.Receta= new RecetaMedica("123", "456", "789");
                mCompra.agregar(new Oncologico("Metotrexato", 5000, Remedio.ObraSocial.OSDE));
                actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
