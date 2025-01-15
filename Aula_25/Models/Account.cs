using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25.Models
{
    public class Account(int numeroConta, Customer cliente, TipoConta tipoConta)
    {
       public int NumeroConta { get; private set; } = numeroConta;
        public double Saldo { get; protected set; } = 0;
        public TipoConta TipoConta { get; private set; } = tipoConta;
        public List<ATMTransaction> HistoricoTransacoes { get; private set; } = new List<ATMTransaction>();
        public Customer Cliente { get; private set; } = cliente;
    public void Depositar(double valor)
        {
            Saldo += valor;
            HistoricoTransacoes.Add(new ATMTransaction("Depósito", valor));
        }

        public virtual void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                HistoricoTransacoes.Add(new ATMTransaction("Saque", valor));
            }
            else
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }
        }

        public void ExibirHistorico()
        {
            foreach (var transacao in HistoricoTransacoes)
            {
                Console.WriteLine($"{transacao.Tipo}: {transacao.Valor}");
            }
        }

        public double GetSaldo()
        {
            return Saldo;
        }
    }


    public class CurrentAccount : Account
    {
        public double LimiteChequeEspecial { get; private set; }

        public CurrentAccount(int numeroConta, Customer cliente, double limiteChequeEspecial)
            : base(numeroConta, cliente, TipoConta.Corrente)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
        }

        public override void Sacar(double valor)
        {
            if (Saldo + LimiteChequeEspecial >= valor)
            {
                Saldo -= valor;
                HistoricoTransacoes.Add(new ATMTransaction("Saque", valor));
            }
            else
            {
                throw new InvalidOperationException("Saldo insuficiente, incluindo o limite do cheque especial.");
            }
        }
    }

    public class SavingAccount : Account
    {
        public double TaxaJuros { get; private set; }

        public SavingAccount(int numeroConta, Customer cliente, double taxaJuros)
            : base(numeroConta, cliente, TipoConta.Poupanca)
        {
            TaxaJuros = taxaJuros;
        }

        public void AplicarRendimento()
        {
            Saldo += Saldo * TaxaJuros;
            HistoricoTransacoes.Add(new ATMTransaction("Rendimento", Saldo * TaxaJuros));
        }
    }
}