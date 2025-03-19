using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    internal class Cliente
    {
        public int id { get; set; }
        public string dataNascimento { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string nomeSocial { get; set; }
        public bool estrangeiro { get; set; }
        public TipoCliente tipo { get; set; }

        public ClassEndereco endereco { get; set; }

        public Genero Genero { get; set; }

        public Etnia Etnia { get; set; }
    }

   
    
    
   

    

    
}
