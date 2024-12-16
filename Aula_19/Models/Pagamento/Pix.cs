using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19.Models.Pagamento
{
    public class Pix(string key, string titular, string cpf, double valor) : IPagamento
    {

        public string Key { get; set; } = key;
        public string Titular { get; set; } = titular;
        public string Cpf { get; set; } = cpf;
        public double Valor { get; set; } = valor;
        public DateTime DataPagamento { get; set; } = DateTime.Now;
        public void Comprovante()
        {
            Console.WriteLine($"Comprovante PIX\n\nTitular: {Titular}\tChave: {Key}");
            
        }

        public void Pagar(double valor)
        {
            Valor = valor;
            Console.WriteLine($"Pagamento de R${valor:F2} realido com sucesso.");
        }
    }
}