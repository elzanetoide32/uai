using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encuesta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su nombre es: "+ txtName.Text +" "+ txtSurname.Text +"\n"+
                "tiene: "+ numEdad.Value + " "+ "es: "+ (btnFemenino.Checked ? "femenino" : "masculino")+
                "\n es de la provincia: "+ cmbProv.Text+
                "\n sus intereses son: ",
            "Mensaje",MessageBoxButtons.OKCancel);
        }
    }
}
