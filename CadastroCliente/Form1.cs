using System.Diagnostics.Eventing.Reader;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();

        private int proximoId = 0;

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
                estado = "São Paulo",
                municipio = "SP"
            };
            Cliente Martiro = new Cliente() { id = proximoId, dataNascimento = "25.06.98", Etnia = Etnia.Preto, Genero = Genero.Masculino, endereco = enderecoMartiro, email = "thiagoxxt@gmail.com", };
            clientes.Add(Martiro);

            Endereco enderecoNilza = new Endereco()
            {
                lougradouro = "casa",
                numero = "157",
                complemento = "Vila marari",
                bairro = "Vila inglesa",
                cep = "050050501",
                estado = "São Paulo",
                municipio = "SP"
            };
            Cliente Oliveira = new Cliente() { id = proximoId, dataNascimento = "13.01.1999", Etnia = Etnia.Preto, Genero = Genero.Feminio, endereco = enderecoNilza, email = "nilza@gmail.com", };
            clientes.Add(Oliveira);

            Endereco enderecoBoteco = new Endereco()
            {
                lougradouro = "casa",
                numero = "658",
                complemento = "São Paulo",
                bairro = "Vila inglesa",
                cep = "15646756",
                estado = "São Paulo",
                municipio = "SP"
            };
            Cliente Claudio = new Cliente() { id = proximoId, dataNascimento = "13.09.1980", Etnia = Etnia.Preto, Genero = Genero.Masculino, endereco = enderecoBoteco, email = "claudio@gmail.com", };
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

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O campo Nome é obrigatório.", "Erro de Validação");
                return;
            }

            string telefoneLimpo = Regex.Replace(telefone, @"[^\d]", ""); // Remove caracteres não numéricos
            if (telefoneLimpo.Length != 11)
            {
                MessageBox.Show("O campo Telefone deve conter exatamente 11 dígitos.", "Erro de Validação");
                return;
            }

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O campo Nome é obrigatório.", "Erro de Validação");
                return;
            }

            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                MessageBox.Show("O campo E-mail é obrigatório e deve conter '@'.", "Erro de Validação");
                return;
            }

            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("O campo Data de nascimento é obrigatório.", "Erro de Validação");
                return;
            }

            if (clientes.Any(c => c.email == email))
            {
                MessageBox.Show("Este e-mail já está cadastrado.", "Erro de Validação");
                return;
            }

            // Validação: Telefone deve ser único
            if (clientes.Any(c => c.telefone == telefone))
            {
                MessageBox.Show("Este telefone já está cadastrado.", "Erro de Validação");
                return;
            }




            // Endereço
            string lougradouro = textBoxLogradouro.Text;
            string numero = textBoxNumero.Text;
            string complemento = textBoxComplemento.Text;
            string bairro = textBoxBairro.Text;
            string municipio = textBoxMunicipio.Text;
            string estado = comboBoxEstado.SelectedItem != null ? comboBoxEstado.SelectedItem.ToString() : "Não especificado";
            string cep = maskedTextBoxCEP.Text;

            // Criando um objeto do cadastro e adicionando à lista
            Cliente novoCadastro = new Cliente()
            {
                id = proximoId++,
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

            // Mensagem de confirmação
            MessageBox.Show("Cadastro adicionado com sucesso!", "Confirmação");

            textNome.Clear();
            textBoxEmail.Clear();
            maskedTextTele.Clear();
            textBoxNomeSocial.Clear();
            textBoxLogradouro.Clear();
            textBoxNumero.Clear();
            textBoxComplemento.Clear();
            textBoxBairro.Clear();
            textBoxMunicipio.Clear();
            maskedTextBoxCEP.Clear();

        }
    }


  

}

