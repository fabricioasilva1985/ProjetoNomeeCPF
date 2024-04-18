using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNomeeEndereço
{
    class PessoaFisica : Pessoa
    {
        public string CPF { get; protected set; }

        public PessoaFisica(string parametroNome, string parametroEndereco, string parametroCPF) : base(parametroNome, parametroEndereco)
        {
             CPF = parametroCPF;
        }

        public void SetCPF (string paramemetroCPF)
        {
            this.CPF = paramemetroCPF;
        }
    }
}
  
