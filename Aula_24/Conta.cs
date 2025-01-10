using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24
{
    public struct ContaS(string num, string titular, decimal saldo)
    {
        public string Numero { get; set; } = num;
        public string Titular { get; set;} = titular;
        public decimal Saldo { get; set;} = saldo;

        public void Depositar(decimal valor) => Saldo += valor;
        public void Sacar(decimal valor)
        {
            if (valor >= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente");
            }
        }
        public override string ToString() => $"{Numero} | {Titular} - R${Saldo}";
        public void AlterarSaldo(decimal valor)
        {
            try
            {
                this = new ContaS(Numero, Titular, valor);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    public class ContaC(string num, string titular, decimal saldo)
    {
        public string Numero { get; set; } = num;
        public string Titular { get; set;} = titular;
        public decimal Saldo { get; set;} = saldo;

        public void Depositar(decimal valor) => Saldo += valor;
        public void Sacar(decimal valor)
        {
            if (valor >= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente");
            }
        }
        public override string ToString() => $"{Numero} | {Titular} - R${Saldo}";
        public void AlterarSaldo(decimal valor)
        {
            try
            {
                Saldo = valor;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    class Exemplo2
    {
        public static void Teste()
        {
            ContaC contaC = new ContaC("1522", "Thiago", 1000);
            ContaS contaS = new ContaS("4568", "Roberto", 5000);
            Console.WriteLine($"{contaC}\n{contaS}");
            
            contaC.AlterarSaldo(200);
            contaS.AlterarSaldo(500);
            
            Console.WriteLine($"{contaC}\n{contaS}");
        }
    }
}