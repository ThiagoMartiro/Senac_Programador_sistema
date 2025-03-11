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
    }

}
