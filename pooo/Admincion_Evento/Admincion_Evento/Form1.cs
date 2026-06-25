using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Negocio;
namespace Admincion_Evento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Eventos evento=new Eventos();
        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Enabled= true;
            txtCargo.Enabled= true;
            cmbPersona.DataSource = new string[] { "Asistente", "Personal" }; ///con array

            evento.ArriboPersona += event_persona;
            ///agregar personas,asistentes

            Asistente aistente = new Asistente(nombre:"pedro",apellido:"sanchez");
            evento.RecibirPersona(aistente);

            AsistenteVIP aistenteVip = new AsistenteVIP(nombre: "susana", apellido: "sanchez");
            evento.RecibirPersona(aistenteVip);

            PersonalEvento persona = new PersonalEvento(nombre: "pedro", apellido: "sanchez",cargo:"bebedor");
            evento.RecibirPersona(persona);

            Actualizar();
        }

        private void cmbPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPersona.SelectedIndex == 0)
            {
                checkBox1.Enabled = true;
                txtCargo.Enabled = false;
            }
            else if (cmbPersona.SelectedIndex == 1)
            {
                checkBox1.Enabled = false;
                txtCargo.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Persona nuevaPersona;

            if (cmbPersona.SelectedIndex == 0) // Asistente
            {
                if (checkBox1.Checked) // ¿es VIP?
                {
                    nuevaPersona = new AsistenteVIP(nombre: txtNombre.Text, apellido: txtApellido.Text);
                }
                else
                {
                    nuevaPersona = new Asistente(nombre: txtNombre.Text, apellido: txtApellido.Text);
                }
            }
            else // PersonalEvento
            {
                nuevaPersona = new PersonalEvento(nombre: txtNombre.Text, apellido: txtApellido.Text, cargo: txtCargo.Text);
            }

            evento.RecibirPersona(nuevaPersona);
            Actualizar();
        
            
        }

        public void event_persona(int asistentes,int personal)
        {
            lblAsistentes.Text = asistentes.ToString();
            lblPersonal.Text = personal.ToString();
            lblTotal.Text = (asistentes+personal).ToString();
        }


        public void Actualizar()
        {
            dataGridView1.DataSource = 0;
            dataGridView2.DataSource = 0;

            dataGridView1.DataSource = evento.Asistentes;
            dataGridView2.DataSource = evento.Personal;
        }
    }
}
