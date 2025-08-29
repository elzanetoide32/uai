namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(Convert.ToInt16(txtNum1.Text) + Convert.ToInt16(txtNum2.Text));
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(Convert.ToInt16(txtNum1.Text) - Convert.ToInt16(txtNum2.Text));
        }

        private void btnDivicion_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtNum1.Text) == 0 || Convert.ToInt16(txtNum2.Text) == 0)
                MessageBox.Show("no se puede dividir por cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            lblResult.Text = Convert.ToString(Convert.ToInt16(txtNum1.Text) / Convert.ToInt16(txtNum2.Text));
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(Convert.ToInt16(txtNum1.Text) * Convert.ToInt16(txtNum2.Text));
        }
    }
}
