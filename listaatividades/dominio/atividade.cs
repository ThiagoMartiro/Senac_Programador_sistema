using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListaAtividades.dominio
{
    internal class Atividade
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Situacao Situacao { get; set; }

        private readonly AtividadeRepositorio repositorio = new();

        public bool Criar()
        {
            if (!ValidarTitulo())
            {
                return false;
            }

            repositorio.Criar(Titulo);
            return true;
        }

        public bool AtualizarSituacao()
        {
            if (!ValidarId())
            {
                return false;
            }

            Atividade AtividadeEmAndamento = BuscarAtividadeEmAndamento();
            Situacao novaSituacao = BuscarProximaSituacao();

            if (AtividadeEmAndamento.Id >0 && AtividadeEmAndamento.Situacao == novaSituacao)
            {
                return false;
            }


            repositorio.AtualizarSituacao(Id,(int) novaSituacao);
            return true;
        }

        public Atividade BuscarAtividadeEmAndamento()
        {
            return new Atividade();
        }

        public List<Atividade> ListarAtividadesPendentes()
        {
            return [];
        }

        private bool ValidarId()
        {
            return Id > 0;
        }

        private bool ValidarTitulo()
        {
            return !string.IsNullOrEmpty(Titulo);
        }

        private bool ValidarSituacao()
        {
            return Situacao != Situacao.Concluido;
        }

        private Situacao BuscarProximaSituacao()
        {
            return Situacao.Concluido;
        }
    }
}
