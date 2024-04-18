using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNomeeEndereço
{

    abstract class Pessoa
    {
        public string Nome { get; protected set; }

        public string Endereco { get; protected set; }

        public Pessoa(string parametroNome, string parametroEndereco) 
        {
            Nome = parametroNome;
            Endereco = parametroEndereco;
        }

        public void SetNome(string parameNome)
        {
            this.Nome = parameNome;
        }

        public void SetEndereco (string parameEndereco) 
        {
            this.Endereco = parameEndereco;
        }
    }
}