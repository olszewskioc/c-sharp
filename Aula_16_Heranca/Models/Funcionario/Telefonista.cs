using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_Heranca.Models.Funcionario
{
    public class Telefonista : Funcionario
    {
        public string? Estacao;

        public Telefonista(string? Nome = null, uint Id = 0, string? Cpf = null, float Salario = 0, string? Estacao=null) : base(Nome, Id, Cpf, Salario)
        {
            this.Estacao = Estacao;
        }

        public override void Print()
        {
            Console.WriteLine($"\nEstação: {Estacao}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Salario: R${Salario:F2}");
            Console.WriteLine($"Bonûs: R${base.GetBonificacao():F2}");
        }

        public void Atendertelefone()
        {
            Console.WriteLine($"\n{Nome} atendendo o telefone na estação {Estacao}.");
        }
    }
}