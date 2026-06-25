using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
namespace Complejo_Deport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ComplejoDeportivo complejo = new ComplejoDeportivo();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            complejo.ReservaAgregada += evento_pepe;
            /*
            ReservarPileta pileta = new ReservarPileta(nombre:"pedro sanches",fecha:"19/08/2026",hora:17,duracion:2,cant:5);
            complejo.AgregarReserva(pileta);

            ReservarCancha cancha=new ReservarCancha(nombre: "susana sanches", fecha: "20/08/2026", hora: 18, duracion: 1,tipo:ReservarCancha.tipo.tenis, seniaAbonada: chkSenia.Checked);
            complejo.AgregarReserva(cancha);

            ReservarSalon salon=new ReservarSalon(nombre: "gabriel sanches", fecha: "18/08/2026", hora: 16, duracion: 2,cat:false, seniaAbonada: chkSenia.Checked);
            complejo.AgregarReserva(salon);
            */
            cmbTipo.DataSource = new string[] {"cancha","pileta","salon"};
            cmbCancha.DataSource = new string[] { "futbol", "tenis", "padel" };
            cmbCancha.Enabled = false;
            txtCantPersona.Enabled = false;
            chkCatering.Enabled = false;
            chkSenia.Enabled = false;
            Actualizar();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                cmbCancha.Enabled = true;
                txtCantPersona.Enabled = false;
                chkCatering.Enabled = false;
                chkSenia.Enabled = true;
            }
            else if (cmbTipo.SelectedIndex == 1)
            {
                cmbCancha.Enabled = false;
                txtCantPersona.Enabled = true;
                chkCatering.Enabled = false;
                chkSenia.Enabled = false;
            }
            else if(cmbTipo.SelectedIndex == 2)
            {
                chkCatering.Enabled = true;
                cmbCancha.Enabled = false;
                txtCantPersona.Enabled = false;
                chkSenia.Enabled = true;
            }
        }

        public void Actualizar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource=complejo.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //{ "futbol", "tenis", "padel" }
            Reserva reserva=null;

            switch (cmbTipo.SelectedIndex)
            {
                case 0:
                    switch (cmbCancha.SelectedIndex)
                    {
                        case 0:
                            reserva = new ReservarCancha(txtNombre.Text, txtFecha.Text, int.Parse(txtHoras.Text), int.Parse(txtDuracion.Text),tipo:ReservarCancha.tipo.futbol, seniaAbonada: chkSenia.Checked);
                            break;
                        case 1:
                            reserva = new ReservarCancha(txtNombre.Text, txtFecha.Text, int.Parse(txtHoras.Text), int.Parse(txtDuracion.Text), tipo: ReservarCancha.tipo.tenis, seniaAbonada: chkSenia.Checked);
                            break;
                        case 2:
                            reserva = new ReservarCancha(txtNombre.Text, txtFecha.Text, int.Parse(txtHoras.Text), int.Parse(txtDuracion.Text), tipo: ReservarCancha.tipo.padel, seniaAbonada: chkSenia.Checked);
                            break;
                    }
                    break;
                case 1:
                    reserva = new ReservarPileta(txtNombre.Text,txtFecha.Text,int.Parse(txtHoras.Text),int.Parse(txtDuracion.Text),int.Parse(txtCantPersona.Text));
                    break;
                case 2:
                    reserva=new ReservarSalon(txtNombre.Text, txtFecha.Text, int.Parse(txtHoras.Text), int.Parse(txtDuracion.Text),chkCatering.Checked, seniaAbonada: chkSenia.Checked);
                    break;
            }

            try
            {
                complejo.AgregarReserva(reserva);
            }
            catch (SeniaRequeridaException ex)
            {
                MessageBox.Show($"No se pudo agregar la reserva de {ex.Reserva.NombreCliente}: {ex.Message}");
            }
            Actualizar();
        }

        public void evento_pepe(int p,int a,double q)
        {
            lbl4.Text = p.ToString();
            lbl5.Text = a.ToString();
            lbl6.Text = q.ToString();
        }
    }
}
