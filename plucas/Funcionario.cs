using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plucas
{
    class Funcionario:PessoaFisica
    {
        private int codigo;
        List<Chamado> listChamados = new List<Chamado>();
    }
}
