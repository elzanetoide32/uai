using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace preParcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RedElectrica redElectrica = new RedElectrica();
        private void Form1_Load(object sender, EventArgs e)
        {
            Televisor televisor = new Televisor();
            televisor.Pulgadas = 110;
            televisor.Nombre = "Televisor";

            AireAcondicionado aire = new AireAcondicionado();
            aire.frigorias = 1000;
            aire.Nombre = "Aire Acondicionado";

            Heladera heladera = new Heladera();
            heladera.Capacidad = 500;
            heladera.Nombre = "Heladera";


            redElectrica.agregar(heladera);
            redElectrica.agregar(aire);
            redElectrica.agregar(televisor);

            acttualizar();
        }



        public void acttualizar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = redElectrica.Electro;
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            redElectrica.Encender();
            double consumo = 0;
            foreach (Electrodomesticos a in redElectrica.Electro)
            {
                consumo += a.Consumo();
            }
            MessageBox.Show($"el consumo es de: {consumo} w");
            acttualizar();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            redElectrica.cortarCorriente();
            acttualizar();
        }
    }
}
