namespace Calculadora_4_operaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);
            if (num2 != 0)
                lblRespuesta.Text = (num1 / num2).ToString();
            else
                lblRespuesta.Text = "Error: división por cero";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);
            lblRespuesta.Text = (num1 + num2).ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);
            lblRespuesta.Text = (num1 - num2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);
            lblRespuesta.Text = (num1 * num2).ToString();
        }
    }

}
