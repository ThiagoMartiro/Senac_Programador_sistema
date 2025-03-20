using System.Diagnostics.Eventing.Reader;
using System.Net.Sockets;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = [];

        private int proximoId = 0;---------------------------------------

        public Form1()
        {
            InitializeComponent();

            Endereco enderecoMartiro = new Endereco()
            {
                lougradouro = "casa",
                numero = "798",
                complemento = "Cidade ademar",
                bairro = "cidade ademar",
                cep = "04403110",
                estado = "S�o Paulo",
                municipio = "SP"
            };
            Cliente Martiro = new Cliente() { id = 0, dataNascimento = "25.06.98", Etnia = Etnia.Preto, Genero = Genero.Masculino, endereco = enderecoMartiro, email = "thiagoxxt@gmail.com", };
            clientes.Add(Martiro);

            Endereco enderecoNilza = new Endereco()
            {
                lougradouro = "casa",
                numero = "157",
                complemento = "Vila marari",
                bairro = "Vila inglesa",
                cep = "050050501",
                estado = "S�o Paulo",
                municipio = "SP"
            };
            Cliente Oliveira = new Cliente() { id = 1, dataNascimento = "13.01.1999", Etnia = Etnia.Preto, Genero = Genero.Feminio, endereco = enderecoNilza, email = "nilza@gmail.com", };
            clientes.Add(Oliveira);

            Endereco enderecoBoteco = new Endereco()
            {
                lougradouro = "casa",
                numero = "658",
                complemento = "S�o Paulo",
                bairro = "Vila inglesa",
                cep = "15646756",
                estado = "S�o Paulo",
                municipio = "SP"
            };
            Cliente Claudio = new Cliente() { id = 2, dataNascimento = "13.09.1980", Etnia = Etnia.Preto, Genero = Genero.Masculino, endereco = enderecoBoteco, email = "claudio@gmail.com", };
            clientes.Add(Claudio);



        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            // Capturando os dados do cadastro
            string nome = textNome.Text;
            string telefone = maskedTextTele.Text;
            string email = textBoxEmail.Text;
            string nomesocial = textBoxNomeSocial.Text;
            Etnia etnia = (Etnia)comboBoxEtnia.SelectedIndex;
            Genero genero = (Genero)comboBoxGenero.SelectedIndex;
            string data = maskedTextData.Text;
            TipoCliente tipo = (TipoCliente)groupBox1.TabIndex;
            bool estrangeiro = checkBoxEST.Checked;

            // Endere�o
            string lougradouro = textBoxLogradouro.Text;
            string numero = textBoxNumero.Text;
            string complemento = textBoxComplemento.Text;
            string bairro = textBoxBairro.Text;
            string municipio = textBoxMunicipio.Text;
            string estado = comboBoxEstado.SelectedItem != null ? comboBoxEstado.SelectedItem.ToString() : "N�o especificado";
            string cep = maskedTextBoxCEP.Text;

            // Criando um objeto do cadastro e adicionando � lista
            Cliente novoCadastro = new Cliente()
            {
                nome = nome,
                telefone = telefone,
                email = email,
                nomeSocial = nomesocial,
                Etnia = etnia,
                dataNascimento = data,
                tipo = tipo,
                estrangeiro = estrangeiro,
                Genero = genero,

            };

            Endereco novoEndereco = new Endereco()
            {
                lougradouro = lougradouro,
                numero = numero,
                complemento = complemento,
                bairro = bairro,
                municipio = municipio,
                estado = estado,
                cep = cep
            };

            clientes.Add(novoCadastro);

            // Mensagem de confirma��o
            MessageBox.Show("Cadastro adicionado com sucesso!", "Confirma��o");
        }
    }

  

}

