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
namespace cola
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue colaPacientes = new Queue();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            colaPacientes.Enqueue(txtName.Text + " " + txtSurname.Text + "-" + txtObra.Text);
            Listar();
        }
        public void Listar()
        {
            listBox1.DataSource = colaPacientes.ToArray();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            colaPacientes.Dequeue();
            Listar();
        }
    }
}
