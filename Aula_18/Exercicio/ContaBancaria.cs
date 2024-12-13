using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Aula_18.Exercicio
{
    public class ContaBancaria(int Numero, string Titular, double Saldo=0)
    {
        private readonly int _numero = Numero;
        private string _titular = Titular;
        private double _saldo = Saldo;

        public int Numero { get => _numero; }
        public string Titular { get => _titular; set => _titular = value; }
        public double Saldo { get => _saldo; private set => _saldo = value; }

        public void Deposito(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"{ToString()}");
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
            Console.WriteLine($"{ToString()}");
        }

        public override string ToString() => $"\nNúmero Conta: {Numero}\nTitular: {Titular}\nSaldo: R${Saldo.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"))}";
    }
}