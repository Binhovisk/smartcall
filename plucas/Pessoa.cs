using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plucas
{
    class Pessoa
    {
        private string nome;
        private string telefone;
        private string endereço;

        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereço { get => endereço; set => endereço = value; }
    }
}
