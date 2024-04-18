using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNomeeEndereço
{
     class Program
    {
        static void Main(string[] args)
        {

            var Pessoas = new List<PessoaFisica>();

            PessoaFisica pessoa1 = new PessoaFisica("Fulano", "BH", "123456");
            PessoaFisica pessoa2 = new PessoaFisica("Ciclano", "RJ", "654321");

            Pessoas.Add(pessoa1);
            Pessoas.Add(pessoa2);

            Console.WriteLine(Pessoas[0].Nome + "\n" + Pessoas[0].Endereco + "\n" + Pessoas[0].CPF + "\n\n");
            Console.WriteLine(Pessoas[1].Nome + "\n" + Pessoas[1].Endereco + "\n" + Pessoas[1].CPF + "\n\n");

            Console.ReadKey();
        }
    }
}
