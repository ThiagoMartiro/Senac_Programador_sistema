using System.Drawing;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            String us = "Thiago Martiro"; //String_Usamos_para_Texto
            String sn = "1234"; //Declaramos_Variaveis

            String usuario = TxtUsuario.Text; //Estamos_Pegando_Usuario_Do_Forms
            String senha = TxtSenha.Text; //Estamos_Pegando_Senha_Do_Forms

            if  (string.IsNullOrWhiteSpace(usuario))//Se_o_Usuario_Estiver_Nulo_Ou_Vazio//Utilizamos_IF_Para_CondiçãoVerdadeiraOuFalsa
            {
                LbResultado.Text = "Preencha o usuário";//Usamos_Para_Mostrar_O_Resultado
                LbResultado.ForeColor = Color.Red;
                return;//Faz_O_Lopin_Para_estiver_vazio
            }
            if (senha == null || senha == "")//Se_a_Senha_Estiver_Nulo_Ou_Vazio//Utilizamos_IF_Para_CondiçãoVerdadeiraOuFalsa
            {
                LbResultado.Text = "Senha é obrigatório!!!";
                LbResultado.ForeColor = Color.Red;
                return;//Faz_O_Lopin_Para_estiver_vazio
            }

            if (usuario == us & sn == senha) //Se_os_dados_estiverem_certos_ira_aparecer_a_Mensagem_abaixo
            {
                LbResultado.Text = "Autenticado com sucesso!";
                LbResultado.ForeColor = Color.Green;
            }
            else
            {
                LbResultado.Text = "Usuário ou Senha incorretos...";
                LbResultado.ForeColor = Color.Red;


            }
        }
    }
}
