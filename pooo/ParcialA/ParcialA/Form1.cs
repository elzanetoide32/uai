using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Carrito mCarrito = new Carrito();
        public event EventHandler Cobrar;
        private void Form1_Load(object sender, EventArgs e)
        {
            mCarrito.LLamarPersonal += HandlerLLamarPersonal; ///asociamos el evento
            Cobrar += mCarrito.HandlerCobrar;
        }







        



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            Producto producto=new Producto(txtCodigo.Text) { Nombre=txtNombre.Text, Precio=txtPrecio.Text};
            try { 
                mCarrito.Agregar(producto); 
            } catch(Carrito es){
                MessageBox.Show("YA SON 10");
                btnAgregar.Enabled = false;
            }
            

            Actualizar1 ();
        }
        public void Actualizar1()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mCarrito.mCarrito;
            lblTotal.Text = mCarrito.total.ToString();  // le tengo que poner el .text
            lblCant.Text = mCarrito.count.ToString();   
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            Cobrar(this,null);
        }
        private void HandlerLLamarPersonal(object Sender, EventArgs e)
        {
            MessageBox.Show("Se solicita la asistencia del personal de seguridad");///lo mostramos
        }
    }
}
