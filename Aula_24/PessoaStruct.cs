using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24
{
    public struct PessoaStruct(string nome, int idade)
    {
        public string Nome { get; set; } = nome;
        public int Idade { get; set; } = idade;

        public override string ToString()
        {
            return $"{Nome} - {Idade}";
        }
    }
    public class Pessoa(string nome, int idade)
    {
        public string Nome { get; set; } = nome;
        public int Idade { get; set; } = idade;

        public override string ToString()
        {
            return $"{Nome} - {Idade}";
        }
    }

    class Exec
    {
        public static void Executar()
        {
            PessoaStruct pessoaStruct1 = new("João", 20);
            PessoaStruct pessoaStruct2 = pessoaStruct1;
            pessoaStruct2.Nome = "Maria";

            Console.WriteLine($"{pessoaStruct1}\n{pessoaStruct2}");
            
            Pessoa pessoa1 = new("Thiago", 22);
            Pessoa pessoa2 = pessoa1;
            pessoa2.Nome = "Roberta";

            Console.WriteLine($"{pessoa1}\n{pessoa2}");
            
            // struct é valor então atribuir cria cópias diferentes
            // class é referências, então atribuir cria referências para o mesmo objeto
            // struct é mais leve e rápido, mas não pode conter referências
            // class é mais pesado e lento, mas pode conter referências
            // struct é imutavel, class é mutavel
        }
    }
}