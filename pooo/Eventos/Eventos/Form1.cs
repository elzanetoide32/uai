using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Click en botón");
        }

        private void OtroHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Click en botón desde otro handler");
        }

        private void OtroHandlerMas(object sender, EventArgs e)
        {
            Button mBoton = (Button)sender;

            MessageBox.Show("Click en botón desde otro handler más, desde el botón " + mBoton.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += OtroHandler;
            button1.Click += OtroHandlerMas;
            button2.Click += OtroHandlerMas;


            mColectivo.ColectivoLleno += HandlerParaColectivoLleno; //Asociamos el puntero del método hanlder al evento al que queremos suscribirlo

        }



        Colectivo mColectivo = new Colectivo();
        private void button3_Click(object sender, EventArgs e)
        {
            Pasajero mPasajero = new Pasajero();
            mColectivo.Subir(mPasajero);
            Actualizar();
        }

        private void Actualizar()
        {
            grdPasajeros.DataSource = null;
            grdPasajeros.DataSource = mColectivo.Pasajeros;

            label1.Text = mColectivo.Pasajeros.Count + " pasajeros";
        }

        /// <summary>
        /// Handler para el evento del colectivo.
        /// Debe tener la misma firma del evento del colectivo (object + EventArgs)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandlerParaColectivoLleno(object sender, EventArgs e)
        {
            MessageBox.Show("El colectivero dice que el colectivo está lleno");
            button3.Enabled = false;
        }
    }
}
