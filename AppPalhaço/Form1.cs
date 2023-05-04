namespace AppPalhaço
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Palhaço palhaço = new Palhaço();
            palhaço.Nome = textBox1.Text;
            palhaço.Altura = Convert.ToDouble(textBox2.Text);
            palhaço.Endereço = textBox3.Text;
            palhaço.Telefone= textBox4.Text;
            palhaço.Email = textBox5.Text;
            palhaço.Cpf = textBox6.Text;
            palhaço.Rg= textBox7.Text;
            palhaço.FalarSobreVc();

        }
    }
}