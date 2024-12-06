using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_Heranca.Models.Funcionario
{
    public class Funcionario(string? Nome=null, uint Id=0, string? Cpf=null, float Salario=0)
    {
        public string? Nome = Nome;
        public uint Id = Id;
        public string? Cpf = Cpf;
        public float Salario = Salario;

        public virtual double GetBonificacao()
        {
            return Salario * 0.1;
        }

        public virtual void Print()
        {
            Console.WriteLine($"\nNome: {Nome}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Salario: R${Salario:F2}");
            Console.WriteLine($"Bonûs: R${GetBonificacao():F2}");
        }

    }
}