using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperaturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                if (celsius < 5)
                {
                    this.BackColor = Color.LightBlue; // Frío ❄️
                }
                else if (celsius > 30)
                {
                    this.BackColor = Color.OrangeRed; // Calor 🔥
                }
                else
                {
                    this.BackColor = SystemColors.Control; // Temperatura normal
                }
                if (cmb1.SelectedItem.ToString() == "Fahrenheit")
                {
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    lblFahrenheit.Text = $"Fahrenheit: {fahrenheit}";
                    lblKelvin.Text = ""; // Limpiar si no se usa
                }
                else if (cmb1.SelectedItem.ToString() == "Kelvin")
                {
                    double kelvin = celsius + 273.15;
                    lblKelvin.Text = $"Kelvin: {kelvin}";
                    lblFahrenheit.Text = ""; // Limpiar si no se usa
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una opcion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Por favor, ingrese una temperatura válida en Celsius.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
