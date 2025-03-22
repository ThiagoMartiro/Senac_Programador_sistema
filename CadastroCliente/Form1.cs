using System.Diagnostics.Eventing.Reader;
using System.Net.Sockets;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();


        private readonly BindingSource BindingSource = [];

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
                municipio = "SP",

            };
            Cliente Martiro = new Cliente() { id = 0, nome = "Thiago", telefone = "(11) 93272-1278", nomeSocial = "Pretola", dataNascimento = "25.06.98", Etnia = Etnia.Preto, Genero = Genero.Masculino, endereco = enderecoMartiro, email = "thiagoxxt@gmail.com", };
            clientes.Add(Martiro);

            Endereco enderecoNilza = new Endereco()
            {
                lougradouro = "casa",
                numero = "157",
                complemento = "Vila marari",
                bairro = "Vila inglesa",
                cep = "050050501",
                estado = "S�o Paulo",
                municipio = "SP",

            };
            Cliente Oliveira = new Cliente() { id = 1, nome = "Claudio", telefone = "(11) 93272-1278", nomeSocial = "Oliveira", dataNascimento = "13.01.1999", Etnia = Etnia.Preto, Genero = Genero.Feminio, endereco = enderecoNilza, email = "nilza@gmail.com", };
            clientes.Add(Oliveira);

            Endereco enderecoBoteco = new Endereco()
            {
                lougradouro = "casa",
                numero = "658",
                complemento = "S�o Paulo",
                bairro = "Vila inglesa",
                cep = "15646756",
                estado = "S�o Paulo",
                municipio = "SP",

            };
            Cliente Claudio = new Cliente() { id = 2, nome = "Pedro", telefone = "(11) 93272-1278", nomeSocial = "careca", dataNascimento = "13.09.1980", Etnia = Etnia.Preto, Genero = Genero.Masculino, endereco = enderecoBoteco, email = "claudio@gmail.com", };
            clientes.Add(Claudio);

            BindingSource.DataSource = clientes;
            dataGridView1.DataSource = BindingSource;
        }

        public int NovoId()
        {
            int id = clientes[clientes.Count - 1].id;
            int idNovo = id + 1;

            return idNovo;
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
            TipoCliente tipo;
            if (radioButtonPF.Checked == true)
            {
                tipo = TipoCliente.PF;

            }
            else
            {
                tipo = TipoCliente.PJ;
            }


            bool estrangeiro = checkBoxEST.Checked;

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O campo Nome � obrigat�rio.", "Erro de Valida��o");
                return;
            }

            string telefoneLimpo = Regex.Replace(telefone, @"[^\d]", ""); // Remove caracteres n�o num�ricos
            if (telefoneLimpo.Length != 11)
            {
                MessageBox.Show("O campo Telefone deve conter exatamente 11 d�gitos.", "Erro de Valida��o");
                return;
            }

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O campo Nome � obrigat�rio.", "Erro de Valida��o");
                return;
            }

            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                MessageBox.Show("O campo E-mail � obrigat�rio e deve conter '@'.", "Erro de Valida��o");
                return;
            }

            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("O campo Data de nascimento � obrigat�rio.", "Erro de Valida��o");
                return;
            }

            if (clientes.Any(c => c.email == email))
            {
                MessageBox.Show("Este e-mail j� est� cadastrado.", "Erro de Valida��o");
                return;
            }

            // Valida��o: Telefone deve ser �nico
            if (clientes.Any(c => c.telefone == telefone))
            {
                MessageBox.Show("Este telefone j� est� cadastrado.", "Erro de Valida��o");
                return;
            }

            // Endere�o
            string lougradouro = textBoxLogradouro.Text;
            string numero = textBoxNumero.Text;
            string complemento = textBoxComplemento.Text;
            string bairro = textBoxBairro.Text;
            string municipio = textBoxMunicipio.Text;
            string estado = comboBoxEstado.Text;
            string cep = maskedTextBoxCEP.Text;

            // Criando um objeto do cadastro e adicionando � lista
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

            Cliente novoCadastro = new Cliente()
            {
                id = NovoId(),
                nome = nome,
                telefone = telefone,
                email = email,
                nomeSocial = nomesocial,
                Etnia = etnia,
                dataNascimento = data,
                tipo = tipo,
                estrangeiro = estrangeiro,
                Genero = genero,
                endereco = novoEndereco


            };

            clientes.Add(novoCadastro);

            BindingSource.ResetBindings(false);

            // Mensagem de confirma��o
            MessageBox.Show("Cadastro adicionado com sucesso!", "Confirma��o");

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

        private void SalvarClientesNoArquivo()
        {
            using (StreamWriter writer = new StreamWriter("clientes.txt"))
            {
                foreach (var cliente in clientes)
                {
                    writer.WriteLine($"{cliente.id}|{cliente.nome}|{cliente.telefone}|{cliente.email}|{cliente.nomeSocial}|{cliente.Etnia}|{cliente.Genero}|{cliente.dataNascimento}|{cliente.tipo}|{cliente.estrangeiro}|{cliente.endereco.lougradouro}|{cliente.endereco.numero}|{cliente.endereco.complemento}|{cliente.endereco.bairro}|{cliente.endereco.municipio}|{cliente.endereco.estado}|{cliente.endereco.cep}");
                }
            }
        }

        private void CarregarClientesDoArquivo()
        {
            if (!File.Exists("clientes.txt")) return;

            using (StreamReader reader = new StreamReader("clientes.txt"))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    var partes = linha.Split('|');
                    Cliente cliente = new Cliente()
                    {
                        id = int.Parse(partes[0]),
                        nome = partes[1],
                        telefone = partes[2],
                        email = partes[3],
                        nomeSocial = partes[4],
                        Etnia = (Etnia)Enum.Parse(typeof(Etnia), partes[5]),
                        Genero = (Genero)Enum.Parse(typeof(Genero), partes[6]),
                        dataNascimento = partes[7],
                        tipo = (TipoCliente)Enum.Parse(typeof(TipoCliente), partes[8]),
                        estrangeiro = bool.Parse(partes[9]),
                        endereco = new Endereco()
                        {
                            lougradouro = partes[10],
                            numero = partes[11],
                            complemento = partes[12],
                            bairro = partes[13],
                            municipio = partes[14],
                            estado = partes[15],
                            cep = partes[16]
                        }
                    };

                    clientes.Add(cliente);
                }






            }

        }
}   }



