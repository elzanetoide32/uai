using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        private Form1 _formMenu; // Referencia al formulario principal
        public Form3(Form1 formMenu)
        {
            InitializeComponent();
            _formMenu = formMenu; // Asignar la referencia al formulario principal
        }

        private void ActualizarGrilla()
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = Datos.ListaPresupuesto;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = Datos.ListaPresupuesto;
            dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.SelectedRows.Count > 1)
            {
                MessageBox.Show("Por favor, selecciona una sola fila para modificar");
                return;
            }
            else
                if (dgvRegistros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para modificar");
                return;
            }

            Registro filaSeleccionada = (Registro)dgvRegistros.SelectedRows[0].DataBoundItem;

            FormABM formularioAltaModificacion = new FormABM(filaSeleccionada);
            Datos.TipoOperacion = 2; // Modificación
            formularioAltaModificacion.FormClosed += (s, args) => ActualizarGrilla();
            formularioAltaModificacion.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _formMenu.lblSaldoTotal.Text = Datos.CalcularSaldoTotal().ToString("0.00");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el registro seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow fila in dgvRegistros.SelectedRows)
                    {
                        Registro r = fila.DataBoundItem as Registro;
                        if (r != null)
                        {
                            Datos.ListaPresupuesto.Remove(r);
                        }
                    }

                    dgvRegistros.DataSource = null;
                    dgvRegistros.DataSource = Datos.ListaPresupuesto;

                    MessageBox.Show("Registros eliminados correctamente.");
                }
            }



        }

    
    }
}
