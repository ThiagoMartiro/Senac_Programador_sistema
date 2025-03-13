using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string v1 = textBox1.Text;
            string v2 = textBox2.Text;
            string v3 = textBox3.Text;
            string v4 = textBox4.Text;

            // Converte os valores para double
            double doublelbl1 = Convert.ToDouble(v1);
            double doublelbl2 = Convert.ToDouble(v2);
            double doublelbl3 = Convert.ToDouble(v3);
            double doublelbl4 = Convert.ToDouble(v4);

            // Verifica se é um quadrado (todos os lados iguais)
            if (doublelbl1 == doublelbl2 && doublelbl2 == doublelbl3 && doublelbl3 == doublelbl4)
            {
                Resultado.Text = "Quadrado";
                double perimetroQuadrado = 4 * doublelbl1;  // Perímetro de um quadrado
                double areaQuadrado = Math.Pow(doublelbl1, 2);  // Área de um quadrado
                Resultado.Text += $"\nPerímetro: {perimetroQuadrado}";
                Resultado.Text += $"\nÁrea: {areaQuadrado}";
            }
            // Verifica se é um retângulo (dois lados iguais e dois diferentes)
            else if (doublelbl1 == doublelbl3 && doublelbl2 == doublelbl4)
            {
                Resultado.Text = "Retângulo";
                double perimetroRetangulo = 2 * (doublelbl1 + doublelbl2);  // Perímetro de um retângulo
                double areaRetangulo = doublelbl1 * doublelbl2;  // Área de um retângulo
                Resultado.Text += $"\nPerímetro: {perimetroRetangulo}";
                Resultado.Text += $"\nÁrea: {areaRetangulo}";
            }
            else
            {
                Resultado.Text = "Os valores não formam um quadrado nem um retângulo. Verifique os valores!";
            }

            // Soma de todos os valores fornecidos
            double res = doublelbl1 + doublelbl2 + doublelbl3 + doublelbl4;
            // Exibe o resultado da soma
            Resultado.Text += $"\nSoma dos valores: {res}";




        }
    }
}  
