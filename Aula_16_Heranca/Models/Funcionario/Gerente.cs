using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_Heranca.Models.Funcionario
{
    // public class Gerente(string? Nome = null, uint Id = 0, string? Cpf = null, float Salario = 0, string? Setor = null) : Funcionario(Nome, Id, Cpf, Salario)
    // {
    //     public string? Setor = Setor;
    // }
    public class Gerente : Funcionario
    {
        public string? Setor;

        public Gerente(string? Nome=null, uint Id=0, string? Cpf=null, float Salario=0, string? Setor=null) : base(Nome, Id, Cpf, Salario)
        {
            this.Setor = Setor;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.15;
        }

        public override void Print()
        {
            Console.WriteLine($"\nSetor: {Setor}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Salario: R${Salario:F2}");
            Console.WriteLine($"Bonûs: R${GetBonificacao():F2}");
        }
    }
}