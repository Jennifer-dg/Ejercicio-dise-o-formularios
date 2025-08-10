namespace Conversor_Celsius__a_Fahrenheit
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

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");

            if (!double.TryParse(textBox1.Text, out double temperatura))
            {
                errorProvider1.SetError(textBox1, "Ingrese un valor válido.");
                return;
            }
            double resultado;
            if (comboBox1.SelectedIndex == 0)
            {
                resultado = (temperatura * 9 / 5) + 32;
                MessageBox.Show($"{temperatura} °C = {resultado:F2} °F", "Resultado");
            }
            else
            {
                resultado = (temperatura - 32) * 5 / 9;
                MessageBox.Show($"{temperatura} °F = {resultado:F2} °C", "Resultado");
            }
        }
    }
}
