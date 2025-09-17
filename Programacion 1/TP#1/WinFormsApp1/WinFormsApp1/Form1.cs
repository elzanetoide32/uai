namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActualizarSaldo();
        }

        public void ActualizarSaldo()
        {
            lblSaldoTotal.Text = Datos.CalcularSaldoTotal().ToString("0.00");

            // Configuramos el Panel como barra
            panelBarraNegra.BackColor = Color.Red;  // Para negativos
            panelBarraNegra.Width = 0;              // Inicialmente vacío

            panelBarraVerde.BackColor = Color.Green; // Para positivos
            panelBarraVerde.Width = 0;               // Inicialmente vacío

            // Actualizamos según saldo
            int saldo = (int)Datos.CalcularSaldoTotal();

            int max = 200000;
            if (saldo > max)
            {
                max = saldo;
            }
            if (saldo >= 0)
            {
                panelBarraVerde.Width = (int)((double)saldo / max * 200); // 200 es el ancho máximo que querés
                panelBarraNegra.Width = 0;
                lblSaldoTotal.ForeColor = Color.Green;

            }
            else
            {
                panelBarraNegra.Width = (int)((double)Math.Abs(saldo) / max * 200);
                panelBarraVerde.Width = 0;
                panelBarraNegra.Left = 20 + 200 - panelBarraNegra.Width;
                lblSaldoTotal.ForeColor = Color.Red;
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            FormABM formularioAltaModificacion = new FormABM();
            Datos.TipoOperacion = 1; // Alta
            formularioAltaModificacion.FormClosed += (s, args) => ActualizarSaldo(); // Actualizar saldo al cerrar el formulario
            formularioAltaModificacion.ShowDialog();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btVisualizar_Click(object sender, EventArgs e)
        {
            Form3 formularioConsulta = new Form3(this);
            formularioConsulta.FormClosed += (s, args) => ActualizarSaldo(); // Actualizar saldo al cerrar el formulario
            formularioConsulta.ShowDialog();
        }


    }
}
