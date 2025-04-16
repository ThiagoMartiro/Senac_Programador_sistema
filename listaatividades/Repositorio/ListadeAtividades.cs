using ListaAtividades.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaatividades.Repositorio
{
    public partial class ListadeAtividades : Form
    {
        public ListadeAtividades()
        {
            InitializeComponent();
        }

        private void ListadeAtividades_Load(object sender, EventArgs e)
        {
            Atividade atividade = new();

            var atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            if (atividadeEmAndamento.Id > 0)
            {
                textBoxAtividadeEmAndamento.Text = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}";
            }

            var ativadadesPendentes = atividade.ListarAtividadesPendentes();
            dataGridViewAtividades.DataSource = ativadadesPendentes;
        }
    }
}
