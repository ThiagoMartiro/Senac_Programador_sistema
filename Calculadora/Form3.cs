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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            double raio;
            if (double.TryParse(raioTextBox.Text, out raio) && raio > 0)
            {
                if (radioButton1.Checked)
                {
                    double perimetro = 2 * Math.PI * raio;
                    resultadoLabel.Text = $"Perímetro: {perimetro:F2}";
                }
                else if (radioButton3.Checked)
                {
                    double diametro = 2 * raio;
                    resultadoLabel.Text = $"Diâmetro: {diametro:F2}";
                }
                else if (radioButton4.Checked)
                {
                    double area = Math.PI * Math.Pow(raio, 2);
                    resultadoLabel.Text = $"Área: {area:F2}";
                }
                else if (radioButton2.Checked)
                {
                    double volume = (4 / 3.0) * Math.PI * Math.Pow(raio, 3);
                    resultadoLabel.Text = $"Volume: {volume:F2}";
                }
                else
                {
                    resultadoLabel.Text = "Selecione uma opção.";
                }
            }
            else
            {
                resultadoLabel.Text = "Insira um raio válido.";
            }
        }

        private void esferaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void quadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}