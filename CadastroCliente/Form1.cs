using System.Diagnostics.Eventing.Reader;
using System.Net.Sockets;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = [];

        public Form1()
        {
            InitializeComponent();

            ClassEndereco enderecoMartiro = new ClassEndereco()
            {
                lougradouro = "casa",
                numero = "798",
                complemento = "Cidade ademar",
                bairro = "cidade ademar",
                cep = "04403110",
                estado = "São Paulo",
                municipio = "SP"
            };
            Cliente Martiro = new Cliente() { id = 0, dataNascimento = "25.06.98", Etnia = Etnia.Preto, Genero = Genero.Masculino, endereco = enderecoMartiro, email = "thiagoxxt@gmail.com", };
            clientes.Add(Martiro);

            ClassEndereco enderecoNilza = new ClassEndereco()
            {
                lougradouro = "casa",
                numero = "157",
                complemento = "Vila marari",
                bairro = "Vila inglesa",
                cep = "050050501",
                estado = "São Paulo",
                municipio = "SP"
            };
            Cliente Oliveira = new Cliente() { id = 1, dataNascimento = "13.01.1999", Etnia = Etnia.Preto, Genero = Genero.Feminio, endereco = enderecoNilza, email = "nilza@gmail.com", };
            clientes.Add(Oliveira);

            ClassEndereco enderecoBoteco = new ClassEndereco()
            {
                lougradouro = "casa",
                numero = "658",
                complemento = "São Paulo",
                bairro = "Vila inglesa",
                cep = "15646756",
                estado = "São Paulo",
                municipio = "SP"
            };
            Cliente Claudio = new Cliente() { id = 2, dataNascimento = "13.09.1980", Etnia = Etnia.Preto, Genero = Genero.Masculino, endereco = enderecoBoteco, email = "claudio@gmail.com", };
            clientes.Add(Claudio);



        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            string nome = textNome.Text;
            string telefone = maskedTextTele.Text;
            string email = textBoxEmail.Text;
            string nomesocial = textBoxNomeSocial.Text;
            string etnia = comboBoxEtnia.SelectedItem.ToString();
            string data = maskedTextData.Text;
            bool pf = radioButtonPF.Checked;
            bool pj = radioButtonPJ.Checked;
            bool estrangeiro = checkBoxEST.Checked;
            string genero = comboBoxGenero.SelectedItem.ToString();

            //endereço

            string logradouro = textBoxLogradouro.Text;
            string numero = textBoxNumero.Text;
            string complemento = textBoxComplemento.Text;
            string bairro = textBoxBairro.Text;
            string municipio = textBoxMunicipio.Text;
            string estado = comboBoxEstado.SelectedItem.ToString();
            string cep = maskedTextData.Text;

            if (string.IsNullOrWhiteSpace(nome))
            {
                mensagem.Text = "É NECESSARIO PREENCHER TODOS OS CAMPOS!!!";
                mensagem.ForeColor = Color.Red;
                return;
            }
        }


    }


}
