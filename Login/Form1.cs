using System.Drawing;

namespace Login
{
    public partial class Form1 : Form
    {

        List<string> listaUsuario = new List<string>() { "neymar.jr", "pablo.vitar","naruto"};
        List<string> listaSenha = new List<string>() { "Bruna", "1234","7777" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
           
            String usuarioBuscado = TxtUsuario.Text; //Estamos_Pegando_Usuario_Do_Forms
            String senha = TxtSenha.Text; //Estamos_Pegando_Senha_Do_Forms

            if  (string.IsNullOrWhiteSpace(usuarioBuscado))//Se_o_Usuario_Estiver_Nulo_Ou_Vazio//Utilizamos_IF_Para_Condi��oVerdadeiraOuFalsa
            {
                LbResultado.Text = "Preencha o usu�rio";//Usamos_Para_Mostrar_O_Resultado
                LbResultado.ForeColor = Color.Red;
                return;//Faz_O_Lopin_Para_estiver_vazio
            }
            if (senha == null || senha == "")//Se_a_Senha_Estiver_Nulo_Ou_Vazio//Utilizamos_IF_Para_Condi��oVerdadeiraOuFalsa
            {
                LbResultado.Text = "Senha � obrigat�rio!!!";
                LbResultado.ForeColor = Color.Red;
                return;//Faz_O_Lopin_Para_estiver_vazio
            }

            int posicaoUsuarioEncontrado = -1;
            for (int i = 0; i < listaUsuario.Count; i++)
            {
                if (usuarioBuscado == listaUsuario[i])
                {
                    posicaoUsuarioEncontrado = i;
                  
                }
            }
            if (posicaoUsuarioEncontrado == -1 || senha != "1234")
            {
                LbResultado.Text = "Usu�rio ou Senha incorretos...";
                LbResultado.ForeColor = Color.Red;
                return;
            }
            else
            {
                LbResultado.Text = "Autenticado com sucesso!";
                LbResultado.ForeColor = Color.Green;
            }

            
        }
    }
}
