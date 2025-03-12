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
            button1.Text = "+";
            string v1 = textBox1.Text;
            string v2 = textBox2.Text;
            string v3 = textBox3.Text;
            string v4 = textBox4.Text;



            double doublelbl1 = Convert.ToDouble(v1);
            double doublelbl2 = Convert.ToDouble(v2);
            double doublelbl3 = Convert.ToDouble(v3);
            double doublelbl4 = Convert.ToDouble(v4);


            double res = doublelbl1 + doublelbl2 + doublelbl3 + doublelbl4;

            Resultado.Text = res.ToString();
        }
    }
}
