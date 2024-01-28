using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_IMC
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtIMC.Text = "";
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);
            txtIMC.Text = imc.ToString("0.00");
            if (imc <= 18.49)
                MessageBox.Show("Você está abaixo do peso", "Resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            else if (imc >= 18.5 && imc <= 24.99)
                MessageBox.Show("Você está no peso ideal", "Resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            else if (imc >= 25 && imc <= 29.99)
                MessageBox.Show("Você está acima do peso ideal", "Resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            else if (imc >= 30 && imc <= 34.99)
                MessageBox.Show("Atenção, você está com Obesidade Grau 1", "Resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else if (imc >= 35 && imc <= 39.99)
                MessageBox.Show("Atenção, você está com Obesidade Grau 2 (Severa)", "Resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
                MessageBox.Show("Atenção, você está com obesidade Grau 3 (Mórbida)", "Resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
