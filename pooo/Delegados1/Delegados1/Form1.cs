using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegados1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void HacerAlgoDelegate(); //Declaramos el tipo del delegado. Decidimos que no va a devolver nada (void) y que no va a tener parámetros

        HacerAlgoDelegate mEsteEsElDelegado; //Declaramos una variable con el tipo definido para el delegate

        private void Form1_Load(object sender, EventArgs e)
        {
            mEsteEsElDelegado += DestinoDeInvocacion; //Asociamos el destino de invocación al delegado
            mEsteEsElDelegado += DestinoDeInvocacion2;
        }

        /// <summary>
        /// Destino de invocación para el delegate. TIENE QUE COINCIDIR la firma de este método con la firma definida para el delegate
        /// </summary>
        private void DestinoDeInvocacion()
        {
            MessageBox.Show("Delegate invocado");
        }

        private void DestinoDeInvocacion2()
        {
            MessageBox.Show("Delegate invocado en otro destino");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mEsteEsElDelegado(); //invocamos el delegado
        }
    }
}
