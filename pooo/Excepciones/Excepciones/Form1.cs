using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x = int.Parse("Esto no es un número");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Persona mPer = new Persona();
                mPer.Nombre = txtNombre.Text;
                mPer.Apellido = txtApellido.Text;
                mPer.Edad = txtEdad.Text;

                MessageBox.Show(mPer.Presentarse());
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Ha ocurrido un error. Desea ver más información?", "Error", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show(ex.Message);
                }
            }

           
        }



        bool mConectado = false;

        private void button3_Click(object sender, EventArgs e)
        {
            int x;
            try
            {
                mConectado = true;
                x = int.Parse( txtNumero.Text);
                //mConectado = false;
            }
            catch
            {
                //mConectado = false;
                MessageBox.Show("No es un número");
                //Application.Exit();
            }
            finally //Este bloque se ejecuta siempre, haya o no haya habido excepción.
            {
                mConectado = false;
            }

            //mConectado = false;
            if (mConectado)
                MessageBox.Show("Sigue conectado!!!!");
            else
                MessageBox.Show("Perfecto");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                Persona mPer = new Persona();
                mPer.Nombre = txtNombre.Text;
                mPer.Apellido = txtApellido.Text;
                mPer.Edad = txtEdad.Text;
                mPer.Mayor = chkMayor.Checked;

                mPer.Contratar();
            }
            catch (EdadException ex)
            {
                string mMayor;
                if (ex.Persona.Mayor)
                    mMayor = "mayor";
                else
                    mMayor = "menor";
                MessageBox.Show("Ha ingresado a la persona " + ex.Persona.Nombre + " como " + mMayor + " siendo que tiene " + ex.Persona.Edad);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de tipo: " + ex.Message);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("Ocurrió un error de aplicación: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }

        }
    }
}
