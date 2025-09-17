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
    public partial class FormABM : Form
    {
        //private Form1 _formMenu; // Referencia al formulario principal

        private Registro registroEditando; // null si es para alta.

        public FormABM()
        {
            InitializeComponent();
        }

        public FormABM(Registro registro) : this()
        {
            registroEditando = registro;

            cbCategoria.Text = registro.Categoria;
            txtImporte.Text = registro.Importe.ToString("0.00");
            txtFecha.Text = registro.Fecha.ToString("dd/MM/yyyy");

            if (registro.Tipo == "Ingreso")
            {
                rbIngreso.Checked = true;
            }
            else if (registro.Tipo == "Gasto")
            {
                rbGasto.Checked = true;
            }
        }


        private void CargarCategorias()
        {
            if (rbIngreso.Checked)
            {
                // Aquí deberías cargar las categorías desde una fuente de datos real
                List<string> categorias = new List<string> { "Sueldo", "Intereses", "Otros" };
                cbCategoria.Items.Clear();
                cbCategoria.Items.AddRange(categorias.ToArray());
            }
            else if (rbGasto.Checked)
            {
                // Aquí deberías cargar las categorías desde una fuente de datos real
                List<string> categorias = new List<string> { "Alquiler", "Comida", "Servicios", "Educación", "Otros" };
                cbCategoria.Items.Clear();
                cbCategoria.Items.AddRange(categorias.ToArray());
            }
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(cbCategoria.Text)) // Verifica si no se ha seleccionado ninguna categoría
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFecha.Text)) // Verifica si no se ha ingresado una fecha
            {
                MessageBox.Show("Debe ingresar una fecha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtImporte.Text)) // Verifica si no se ha ingresado un importe
            {
                MessageBox.Show("Debe ingresar un importe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txtImporte.Text, out decimal importe) || importe <= 0) // Verifica si el importe es un número positivo
            {
                MessageBox.Show("El importe debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!DateTime.TryParse(txtFecha.Text, out DateTime fecha)) // Verifica si la fecha es válida
            {
                MessageBox.Show("Ingresá una fecha válida en formato dd/mm/aaaa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (fecha > DateTime.Now) // Verifica si la fecha no es futura
            {
                MessageBox.Show("La fecha no puede ser futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (fecha.Year != DateTime.Today.Year) // Verifica si la fecha pertenece al año en curso
            {
                MessageBox.Show("La fecha debe pertenecer al año en curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void GuardarDatos(int tipoOperacion)
        {
            if (tipoOperacion == 1) // Alta
            {
                Registro r = new Registro
                {
                    Id = Datos.ProximoId++,
                    Categoria = cbCategoria.Text,
                    Fecha = DateTime.Parse(txtFecha.Text),
                    Importe = decimal.Parse(txtImporte.Text),
                    Tipo = rbIngreso.Checked ? "Ingreso" : "Gasto"
                };

                Datos.ListaPresupuesto.Add(r);

                MessageBox.Show("Registro agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar campos para un nuevo ingreso
                cbCategoria.SelectedIndex = -1;
                txtFecha.Clear();
                txtImporte.Clear();
                rbIngreso.Checked = true;
                CargarCategorias();

            }
            else if (tipoOperacion == 2) // Modificación
            {
                registroEditando.Categoria = cbCategoria.Text;
                registroEditando.Fecha = DateTime.Parse(txtFecha.Text); 
                registroEditando.Importe = decimal.Parse(txtImporte.Text);
                registroEditando.Tipo = rbIngreso.Checked ? "Ingreso" : "Gasto";

                MessageBox.Show("Registro modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void FormABM_Load(object sender, EventArgs e)
        {
            if (Datos.TipoOperacion == 1) // Alta
            {
                this.Text = "Agregar Registro";
                btGuardar.Text = "Agregar";
                rbIngreso.Checked = true;
                CargarCategorias();

            }
            else if (Datos.TipoOperacion == 2) // Modificación
            {
                this.Text = "Modificar Registro";
                btGuardar.Text = "Guardar";
                // Cargar datos del registro a modificar (no implementada en este ejemplo)
            }


        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                GuardarDatos(Datos.TipoOperacion);
            }
        }

        private void tbImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir números
            if (char.IsDigit(e.KeyChar))
            {
                // Si ya hay coma y tiene dos decimales, bloquear más números
                if (txtImporte.Text.Contains(","))
                {
                    string[] partes = txtImporte.Text.Split(',');
                    if (txtImporte.SelectionStart > txtImporte.Text.IndexOf(',') &&
                        partes.Length > 1 &&
                        partes[1].Length >= 2)
                    {
                        e.Handled = true;
                        return;
                    }
                }

                return;
            }

            // Permitir solo una coma o punto decimal
            if ((e.KeyChar == '.' || e.KeyChar == ',') && !txtImporte.Text.Contains(","))
            {
                e.KeyChar = ','; // fuerza coma como separador
                return;
            }

            e.Handled = true; // Bloquear cualquier otro carácter
        }

        private void rbIngreso_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIngreso.Checked)
            {
                CargarCategorias();
            }
        }

        private void rbGasto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGasto.Checked)
            {
                CargarCategorias();
            }

        }
    }
}
