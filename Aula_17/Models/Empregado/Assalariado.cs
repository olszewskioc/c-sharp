using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17.Models.Empregado
{
    public class Assalariado(string? Nome=null, string? Sobrenome=null, string? Cpf=null, double Salario=0) : Empregado(Nome, Sobrenome, Cpf)
    {
        public double Salario = Salario;

        public override double Vencimento() => Salario;

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Salário: R${Salario:F2}");
        }
    }
}