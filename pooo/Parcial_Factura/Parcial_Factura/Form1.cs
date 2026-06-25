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

namespace Parcial_Factura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List <Factura> factura=new List<Factura>(); ///lo tengo que instanciar para poder escrivir o leer metodos
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Factura.TipoFactura));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            factura.Add(new Factura() { Nombre = txtNombre.Text, CUIT = txtCuit.Text,Fecha=txtFecha.Value,Tipo= (Factura.TipoFactura)comboBox1.SelectedItem });

            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = factura.Select(f =>
            {
                Single total = 0;
                Single iva = 0;
                try
                {
                    total = f.Total;
                    iva = f.IVA;
                }
                catch (CUITObligatorioException ex)
                {
                    MessageBox.Show($"Factura sin CUIT: {ex.Message}");
                }

                return new
                {
                    Tipo = f.Tipo.ToString(),
                    f.Nombre,
                    f.CUIT,
                    f.Fecha,
                    Total = total,
                    IVA = iva
                };
            }).ToList();
        }

        private void txtAgregarItem_Click(object sender, EventArgs e)
        {
            FormItem formItem = new FormItem();

            if (formItem.ShowDialog() == DialogResult.OK)
            {
                Factura facturaSeleccionada = factura[dataGridView1.CurrentRow.Index];
                facturaSeleccionada.AgregarItems(formItem.Item); // usás tu método
                ActualizarGrilla();
            }
        }
        
    }
}
