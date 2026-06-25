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

namespace CentroComercial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Facturador facturador = new Facturador();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Comisión general
            Producto.Comision = 100;

            // PRODUCTOS
            Hamburguesa h1 = new Hamburguesa(2000, true);
            h1.Codigo = "H001";
            h1.Nombre = "Hamburguesa Completa";

            Gaseosa g1 = new Gaseosa(1000, true);
            g1.Codigo = "G001";
            g1.Nombre = "Gaseosa XL";

            Zapatilla z1 = new Zapatilla(
                50000,
                Zapatilla.TipoZapatilla.Urbana,
                49
            );

            z1.Codigo = "Z001";
            z1.Nombre = "Nike Urbana";

            PaqueteTuristico p1 = new PaqueteTuristico(300000, true);
            p1.Codigo = "P001";
            p1.Nombre = "Viaje Brasil";

            
            // AGREGAR AL FACTURADOR
            facturador.AgregarProducto(h1);
            facturador.AgregarProducto(g1);
            facturador.AgregarProducto(z1);
            facturador.AgregarProducto(p1);

            // MOSTRAR EN GRILLA
            dataGridView1.DataSource = null;

            List<dynamic> lista = new List<dynamic>();

            foreach (Producto p in facturador.Productos)
            {
                lista.Add(new
                {
                    p.Codigo,
                    p.Nombre,
                    PrecioFinal = p.CalcularPrecioFinal()
                });
            }

            dataGridView1.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFactura.Text = facturador.GenerarFactura();
        }
    }
}
