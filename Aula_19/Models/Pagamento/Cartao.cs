using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19.Models.Pagamento
{
    public record Cartao(string Titular, DateTime Vencimento, double Anuidade=100, string? Numero=null) : IPagamento, IAnuidade
    {
        public string Titular { get; set; } = Titular;
        public string? Numero { get; set; } = Numero;
        public DateTime Vencimento { get; set; } = Vencimento;
        public double Anuidade { get; set; } = Anuidade;

        public void Comprovante()
        {
            Console.WriteLine($"{Numero}");
        }

        public void Pagar(double valor)
        {
            Console.WriteLine($"Pagamento de R${valor:F2} realido com sucesso.");
        }

        public DateTime CalcularDataVencimento()
        {
            return DateTime.Now.AddYears(1);
        }

        public double ValorAnuidade()
        {
            return Anuidade;
        }
    }
}