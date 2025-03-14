namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string v1 = lbl11.Text;
            string v2 = lbl2.Text;


            double doublelbl1 = Convert.ToDouble(v1);
            double doublelbl2 = Convert.ToDouble(v2);

            double res = doublelbl1 + doublelbl2;



            resultado.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string v1 = lbl11.Text;
            string v2 = lbl2.Text;


            double doublelbl1 = Convert.ToDouble(v1);
            double doublelbl2 = Convert.ToDouble(v2);

            double res = doublelbl1 - doublelbl2;


            resultado.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string v1 = lbl11.Text;
            string v2 = lbl2.Text;


            double doublelbl1 = Convert.ToDouble(v1);
            double doublelbl2 = Convert.ToDouble(v2);

            double res = doublelbl1 / doublelbl2;


            resultado.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string v1 = lbl11.Text;
            string v2 = lbl2.Text;


            double doublelbl1 = Convert.ToDouble(v1);
            double doublelbl2 = Convert.ToDouble(v2);

            double res = doublelbl1 * doublelbl2;


            resultado.Text = res.ToString();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 novaAba = new Form1();
            this.Hide();
            novaAba.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "+";
            string v1 = lbl11.Text;
            string v2 = lbl2.Text;


            double doublelbl1 = Convert.ToDouble(v1);
            double doublelbl2 = Convert.ToDouble(v2);

            double res = doublelbl1 + doublelbl2;

            resultado.Text = res.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "-";
            string v1 = lbl11.Text;
            string v2 = lbl2.Text;


            double doublelbl1 = Convert.ToDouble(v1);
            double doublelbl2 = Convert.ToDouble(v2);

            double res = doublelbl1 - doublelbl2;

            resultado.Text = res.ToString();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "/";

            string v1 = lbl11.Text;
            string v2 = lbl2.Text;


            double doublelbl1 = Convert.ToDouble(v1);
            double doublelbl2 = Convert.ToDouble(v2);

            double res = doublelbl1 / doublelbl2;

            resultado.Text = res.ToString();

        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "*";

            string v1 = lbl11.Text;
            string v2 = lbl2.Text;


            double doublelbl1 = Convert.ToDouble(v1);
            double doublelbl2 = Convert.ToDouble(v2);

            double res = doublelbl1 * doublelbl2;

            resultado.Text = res.ToString();
        }

        private void quadradoRetanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void circunferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }
    }



}


        
            



        
    


