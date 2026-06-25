using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum Sector {Administracion,Sistemas,RRHH,Ventas};

        private List<Empleado> mListaEmpleado = new List<Empleado>();
        private void Form1_Load(object sender, EventArgs e)
        {

            mListaEmpleado.Add(new Empleado() { Nombre = "Juan", Legajo = "0001", Sector = "Administracion" });
            Loads();
            Actualizar();
        }
        public void Loads()
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Sector));////pone los valores del enum a el combobox

            //lo puedo obicviar pq ya lo pongo con el datasource
            grdEmpleado.Columns.Add("Nombre", "Nombre");
            grdEmpleado.Columns["Nombre"].DataPropertyName = "Nombre";

            grdEmpleado.Columns.Add("Legajo", "Legajo");
            grdEmpleado.Columns["Legajo"].DataPropertyName = "Legajo";

            grdEmpleado.Columns.Add("Sector", "Sector");
            grdEmpleado.Columns["Sector"].DataPropertyName = "Sector";

            grdEmpleado.RowHeadersVisible = false;
            grdEmpleado.AllowUserToAddRows = false;
            grdEmpleado.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdEmpleado.MultiSelect = false;

            grdEmpleado.AutoGenerateColumns = false;            
        }
        public void Actualizar()
        {
            grdEmpleado.Rows.Clear();
            foreach (Empleado p in mListaEmpleado)
                grdEmpleado.Rows.Add(p.Nombre, p.Legajo,p.Sector);
            ///grdEmpleado.DataSource = mListaEmpleado; -> con esto no puedo editar para qeu no escriba,etc
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            mListaEmpleado.Add(new Empleado() { Nombre = txtNombre.Text, Legajo = txtLegajo.Text, Sector = comboBox1.Text });
            Actualizar();
        }
    }
}
