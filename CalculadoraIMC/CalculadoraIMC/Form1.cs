using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btDel_Click(object sender, EventArgs e)
        //Limpar a Àrea txt Peso e Altura
        {
            
            if (txtPeso.Focused) // Apaga apenas na área do Peso 
            {
                txtPeso.Clear();
            }
            else if (txtAltura.Focused)
            {
                txtAltura.Clear(); // Apaga apenas na área do Altura
            }
            else
            {
                // Mensagem caso não tiver selecionado a área para apagar
                MessageBox.Show("Selecione o campo que deseja apagar (Peso ou Altura).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AdicionarNumeros(object sender, EventArgs e)
        // Digitar os numeros dentro das areas Peso e Altura
        {
            Button numeros = sender as Button;

            string textoNumero = numeros.Text.Replace(',', '.');

            if (txtPeso.Tag.Equals(true))
            {
                txtPeso.Text += numeros.Text;
            }
            else
            {
                txtAltura.Text += numeros.Text;
            }
        }




        private void txtPeso_Enter(object sender, EventArgs e)
        {
            txtPeso.Tag = true;
            txtAltura.Tag = false;

            {
                txtPeso.BackColor = Color.Red; // Altera a cor da Area txtPeso
            }
        }
        private void txtPeso_Leave(object sender, EventArgs e)
        {
            {
                txtPeso.BackColor = Color.Red; // Altera a cor da Area txtPeso
            }
        }
        private void txtAltura_Enter(object sender, EventArgs e)
        {
            txtAltura.Tag = true;
            txtPeso.Tag = false;

            txtAltura.BackColor = Color.Red; // Altera a cor da Area txtAltura
        }
        private void txtAltura_Leave(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.White; // Altera a cor da Area txAltura
        }



        private void btCalcular_Click(object sender, EventArgs e)
        {
            {
                if (txtPeso.Text == "" || txtAltura.Text == "")
                {
                    MessageBox.Show("Por favor, insira o Peso e a Altura!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Mensagem caso se a area não tiver nenhum valor
                }

                double peso = Convert.ToDouble(txtPeso.Text);
                double altura = Convert.ToDouble(txtAltura.Text);
                double imc = peso / (altura * altura);

                txtIMC.Text = imc.ToString("F2"); // Mostra o IMC com 2 casas decimais


                { // Mostrar ao Usuário o Resultado do Cálculo IMC

                    if (imc < 19.1)
                    {
                        lblSituacao.Text = "Abaixo do Peso";
                    }
                    else if (imc < 23.8)
                    {
                        lblSituacao.Text = "Peso Normal";
                    }
                    else if (imc < 32.3)
                    {
                        lblSituacao.Text = "Acima do Peso";
                    }
                    else if (imc < 32.3)
                    {
                        lblSituacao.Text = "Obeso";
                    }
                    MessageBox.Show($"Seu IMC é {imc:F2} - {lblSituacao.Text}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }
    }
}
