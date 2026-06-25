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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parcial_edificio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Datos de prueba — edificio con unidades y propietarios
            Edificio e1 = Edificio.CrearEdificio("San Martin", 123);

            Unidad u1 = new Unidad(e1) { Nombre = "1A" };
            u1.AgregarPropietario("Juan", "Perez", "1234567");
            u1.AgregarPropietario("Maria", "Lopez", "7654321");

            Unidad u2 = new Unidad(e1) { Nombre = "1B" };
            u2.AgregarPropietario("Carlos", "Gomez", "1111111");

            e1.AgregarUnidad(u1);
            e1.AgregarUnidad(u2);

            mEdificio.Add(e1);
            Actulizar();
        }
        public List<Edificio> mEdificio=new List<Edificio>();
        private void txtAgregarEdificio_Click(object sender, EventArgs e)
        {
            Edificio nuevo = Edificio.CrearEdificio(txtCalle.Text, int.Parse(txtNumero.Text));
            mEdificio.Add(nuevo);
            Actulizar();
        }

        public void Actulizar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mEdificio;
        }

        private void btnAgregarUnidad_Click(object sender, EventArgs e)
        {

            Edificio edificioSeleccionado = (Edificio)dataGridView1.SelectedRows[0].DataBoundItem;

            Unidad nueva = new Unidad(edificioSeleccionado)
            {
                Nombre = txtUnidadNombre.Text
            };

            edificioSeleccionado.AgregarUnidad(new Unidad(edificioSeleccionado) { Nombre=txtUnidadNombre.Text});
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            Edificio edificioSeleccionado = (Edificio)dataGridView1.SelectedRows[0].DataBoundItem;

            // Suscribir el evento NotificarResultado al método que muestra en la grilla
            edificioSeleccionado.NotificarResultado += MostrarResultado;

            edificioSeleccionado.BuscarM(txtNombreBuscar.Text, txtApellidoBuscar.Text);
        }
        private void MostrarResultado(string datos)
        {
            // Agregar cada resultado encontrado a una lista y mostrar en grilla
            MessageBox.Show(datos);
        }

        
    }
}
