using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace act33
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack Platos = new Stack();

        private void btnAnotar_Click(object sender, EventArgs e)
        {
            Platos.Push(txtNumserie.Text + " - " + txtPrecio.Text);
            actualizar();
        }
        void actualizar()
        {
            lstPlatos.DataSource = Platos.ToArray();
            txtPrecio.Clear();
            txtNumserie.Clear();
            txtNumserie.Focus();
            txtPrecio.Focus();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
      
            if (Platos.Count != 0)
            {
                Platos.Pop();
                actualizar();
            }
            else
            {
                MessageBox.Show("No hay platos para vender");
            }
        }
    }
}
