using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Bancario.Models.Interfaces;

namespace Desafio_Bancario.Models
{
    public class Account(string type, string number, double balance, Costumer costumer)
    {
        public string Type {get; set;} = type;
        private string _number = number;
        private double _balance = balance;
        private Costumer _costumer = costumer;
        private List<Transaction> _transactions = [];

        public string Number { get => _number; }
        public double Balance 
        { 
            get => _balance;
            set => _balance = value >= 0 ? value : throw new ArgumentException("Invalid balance");
        }
        public Costumer Costumer { get => _costumer; }
        public List<Transaction> Transactions
        {
            get => _transactions;
            set => _transactions = value ?? throw new ArgumentException("Transactions cannot be null");
        }
    }
    public class CurrentAccount(string type, string number, double balance, Costumer costumer)
    : Account(type, number, balance, costumer), IAccountActions
    {
        public bool CreateTransaction()
        {
            throw new NotImplementedException();
        }

        public bool Deposit(double value)
        {
            try
            {
                Balance += value;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public bool Withdraw(double value)
        {
            throw new NotImplementedException();
        }
    }
    public class SavingAccount(string type, string number, double balance, Costumer costumer)
    : Account(type,number, balance, costumer), IAccountActions
    {
        public bool CreateTransaction()
        {
            throw new NotImplementedException();
        }

        public bool Deposit(double value)
        {
            try
            {
                Balance += value;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public bool Withdraw(double value)
        {
            throw new NotImplementedException();
        }
    }
}