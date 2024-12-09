using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17.Models.Empregado
{
    public class Horista(string? Nome=null, string? Sobrenome=null, string? Cpf=null, double precoHora=0, double horasTrabalhadas=0) 
    : Empregado(Nome, Sobrenome, Cpf)
    {
        public double precoHora = precoHora;
        public double horasTrabalhadas = horasTrabalhadas;

        public override double Vencimento()
        {
            return precoHora * horasTrabalhadas;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Horas Trabalhadas: {horasTrabalhadas:F2}");
            Console.WriteLine($"Valor Hora: R${precoHora:F2}");
        }
    }
}