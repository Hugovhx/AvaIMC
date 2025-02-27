namespace Avaliação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {




            txtPeso.BackColor = Color.Red;
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.Red;
        }

        private void txtIMC_TextChanged(object sender, EventArgs e)
        {
            txtIMC.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarNumeros(object sender, EventArgs e)
        {
            Button numeros = sender as Button;
            if { (txtAltura.Tag.Equals(true))
            



                txtAltura.Text += numeros.Text;
            }
        }
        private void PesoEnter(object sender, EventArgs e)
        {

        }

        private void AlturaEnter(object sender, EventArgs e)
        {

        }
    }
}