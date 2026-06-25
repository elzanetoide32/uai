using clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cocineros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RESTAURANTE rESTAURANTE = new RESTAURANTE();
        private void Form1_Load(object sender, EventArgs e)
        {
            //SacarPlato(dos veces con un chef y una con un Repostero) y consultar el costo acumulado.
            CHEF cHEF = new CHEF();
           // RESTAURANTE rESTAURANTE = new RESTAURANTE();
            rESTAURANTE.SacarPlato(cHEF);
            rESTAURANTE.SacarPlato(cHEF);
            REPOSTERO repo = new REPOSTERO();
            rESTAURANTE.SacarPlato(repo);
            double total=rESTAURANTE.CostoTotal;
            MessageBox.Show(total.ToString());//150 ta bien

            cmbPlatos.Items.Add("Pastelero");
            cmbPlatos.Items.Add("Cocinero");

            MESA mesa = new MESA("MEsa 1");
            rESTAURANTE.AgregarMesa(mesa);

            cmbMesa.DataSource=mesa.ToList();
        }

        private void btnSacarPlato_Click(object sender, EventArgs e)
        {
            COCINERO cocinero = (COCINERO)cmbPlatos.SelectedItem; // obtenés el cocinero seleccionado
            PLATO plato = rESTAURANTE.SacarPlato(cocinero);         // el restaurante prepara el plato

            int indiceMesa = cmbMesa.SelectedIndex;                 // obtenés la mesa seleccionada
            ///rESTAURANTE[indiceMesa].AgregarPlato(plato);                  // agregás el plato a la mesa
        }

        public void Actualizar()
        {
            dataGridView1.DataSource = 0;
            dataGridView2.DataSource = 0;
            dataGridView3.DataSource = 0;

            //dataGridView1.DataSource= mesa.Take(1).ToArray();
        }/*
          8) En una pantalla de Windows se permitirá seleccionar al tipo de plato a sacar (postre o plato
principal) y un número de mesa. 

Con un botón se ordenará el plato correspondiente (pasándole
el cocinero correspondiente a Restaurante) y el plato obtenido se asignará a la mesa indicada.

La mesa se obtendrá mediante una propiedad “Mesa” de Restaurante que será indexadora y
devolverá una de las tres mesas. 

Tres grillas mostrarán los platos de cada mesa.
El formulario mostrará el costo por mesa y el total del restaurante.



9) Los ingredientes se podrán ordenar en el plato por nombre y por costo.

11) Los platos expondrán una propiedad de solo lectura Servido de tipo booleano y un método
Servir que lo establecerá en true. Cada plato preparado acumulará un puntero a ese método en
un delegado declarado en Restaurante. Un método ServirPlatos de Restaurante desencadenará el delegado por multidifusión.
    
          
          
          */
    }
}
