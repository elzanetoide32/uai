using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; ///para no usar el tipo d datos <string>, osea te toma solo el tipo de datos de la pila
namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ////pilassss -> stack
        ///instanciamos una pila usando la clase stack
        Stack PilaCamion = new Stack();
        int Tam = 5; ///tamaño de la lista


        private void button2_Click(object sender, EventArgs e)
        {
            if (PilaCamion.Count < Tam )
            {
                if (txtCarga.Text!= "")
                {
                    PilaCamion.Push(txtCarga.Text.ToUpper());//le paso el elemento
                    progressBar1.Value = progressBar1.Value + 1;
                    Listar();
                }
                else
                {
                    MessageBox.Show("debe escribir algo en el elemento");
                }
                
            }
            else
            {
                MessageBox.Show("ya no hay espacio");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PilaCamion.Count != 0)
            {
                PilaCamion.Pop(); ///sin elementos porque es el ultimo
                Listar();
            }
            else
            {
                MessageBox.Show("ya no hay mas elementos en el camion");
            }
        }
        public void Listar()
        {
            lstCamion.DataSource = PilaCamion.ToArray(); /////ya me referencia el 0->0 para poder ponerlo en el lst
            txtCarga.Clear();
            txtCarga.Focus();
            lblExist.Text = "";
            lblProx.Text = "";
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            lblProx.Text = PilaCamion.Peek().ToString();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            if (PilaCamion.Contains(txtExist.Text.ToUpper()))//el upper para poner tyodo a mayuscula se usa tanto para validar como para cargar
            {
                lblExist.Text = "el elemento esta en el camion";
            }
            else
            {
                lblExist.Text = "el elemento no esta en el camion";
            }
        }
    }
}
