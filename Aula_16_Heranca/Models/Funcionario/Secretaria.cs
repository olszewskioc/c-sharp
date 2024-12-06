using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_Heranca.Models.Funcionario
{
    public class Secretaria(string? Nome = null, uint Id = 0, string? Cpf = null, float Salario = 0, string? Ramal = null) : Funcionario(Nome, Id, Cpf, Salario)
    {
        public string? Ramal = Ramal;

        public override double GetBonificacao()
        {
            return Salario * 0.05;
        }

        public override void Print()
        {
            Console.WriteLine($"\nRamal: {Ramal}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Salario: R${Salario:F2}");
            Console.WriteLine($"Bonûs: R${GetBonificacao():F2}");
        }

        public void AgendarHorário(DateTime Data)
        {
            Console.WriteLine($"\nSecretária {Nome} marcou uma reserva de horário para {Data}");
            
        }
    }
}