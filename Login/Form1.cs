using System.DirectoryServices.ActiveDirectory;
using System.Drawing;

namespace Login
{
    public partial class Form1 : Form
    {

        List<string> listaUsuario = new List<string>() { "neymar.jr", "Thiago", "naruto" };
        List<string> listaSenha = new List<string>() { "Bruna", "1234", "7777" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {

            String usuarioBuscado = TxtUsuario.Text; //Estamos_Pegando_Usuario_Do_Forms
            String senha = TxtSenha.Text; //Estamos_Pegando_Senha_Do_Forms

            if (string.IsNullOrWhiteSpace(usuarioBuscado))//Se_o_Usuario_Estiver_Nulo_Ou_Vazio//Utilizamos_IF_Para_CondiçãoVerdadeiraOuFalsa
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
                LbResultado.Text = "Usuário ou Senha incorretos...";
                LbResultado.ForeColor = Color.Red;
                return;
            }
            else
            {
                LbResultado.Text = "Autenticado com sucesso!";
                LbResultado.ForeColor = Color.Green;
            }


        }



        private void New_Click(object sender, EventArgs e)
        {
            String NovoUs = Newus.Text;
            String NovaSe = Novasenha.Text;
            
            if (string.IsNullOrWhiteSpace(NovoUs))
            {
                resultado.Text = "Usuario obrigatorio";
            }
            if (string.IsNullOrWhiteSpace(NovaSe))
            {
                resultado.Text = "Senha Obrigatoria";
                return;
            }

            if (NovaSe.Length < 8)
            {
                resultado.Text = "É necessario a senha ter pelo menos 8 digitos";
                return;
            }

            if (!NovaSe.Any(char.IsUpper))
            {
                resultado.Text = "Senha precisa ter no mínimo uma letra maiuscula";
                return;
            }

            if (!NovaSe.Any(char.IsLower))
            {
                resultado.Text = "Senha precisa ter no mínimo uma letra minuscula";
                return;
            }

            if (!NovaSe.Any(char.IsNumber))
            {
                resultado.Text = "Senha precisa ter no mínimo um número";
                return;
            }

            if (!NovaSe.Any(char.IsPunctuation))
            {
                resultado.Text = "Senha precisa ter um caracter especial ";
                return;
            }


            Boolean Usuario_encontrado = false;
            for (int i = 0; i < listaUsuario.Count; i++)
            {
                if (NovoUs == listaUsuario[i])
                {
                    Usuario_encontrado = true;
                }
            }
            if (Usuario_encontrado == false)
            {
                listaUsuario.Add(NovoUs);
                listaSenha.Add(NovaSe);
                resultado.Text = "Cadastrado com sucesso";
            }
            else
            {
                resultado.Text = "Ja existe";
            }

        }

    }
}
