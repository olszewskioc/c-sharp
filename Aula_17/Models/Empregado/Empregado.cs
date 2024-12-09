using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17.Models.Empregado
{
    public abstract class Empregado(string? Nome=null, string? Sobrenome=null, string? Cpf=null)
    {
        public string? Nome = Nome;
        public string? Sobrenome = Sobrenome;
        public string? Cpf = Cpf;

        public abstract double Vencimento();

        public virtual void Print()
        {
            Console.WriteLine($"\nNome Completo: {Nome} {Sobrenome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Total: R${Vencimento():F2}");
        }
    }
}