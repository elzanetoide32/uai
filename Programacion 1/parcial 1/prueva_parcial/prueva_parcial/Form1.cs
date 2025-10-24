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
namespace prueva_parcial
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack Stock = new Stack();
        int Camion = 0;
        private void btnAlmacenar_Click(object sender, EventArgs e)
        {
            Stock.Push(txtCodigo.Text.ToUpper());//le paso el texto del codigo en mayusculas
            actualizar();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            
            if (Stock.Count != 0)
            {
                Stock.Pop();
                actualizar();
                Camion++;
                if (Camion == 4)
                {
                    MessageBox.Show("has llenado 1 camion");
                    Camion = 0;
                }
            }
            else
            {
                MessageBox.Show("no hay mas lotes");
            }
        }
        void actualizar()
        {
            lstStock.DataSource = Stock.ToArray();
            txtCodigo.Clear();
            txtCodigo.Focus();
        }
    }
}
