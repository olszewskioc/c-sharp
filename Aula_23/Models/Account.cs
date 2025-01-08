using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23.Models
{
    public class Account(int number, string holder, double balance = 0, double limit = 100)
    {
        private readonly int _number = number;
        private string _holder = holder;
        private double _balance = balance;
        private double _withdrawLimit = limit;

        public int Number {get => _number;}
        public string Holder 
        {
            get => _holder; 
            set => _holder = value;
        }
        public double Balance
        {
            get => _balance;
            set => _balance = value > 0 ? value : 0;
        }
        public double WithdrawLimit
        {
            get => _withdrawLimit;
            set => _withdrawLimit = value > 0 ? value : _withdrawLimit;
        }

        public void Deposit(double amount) => Balance += amount;
        public void Withdraw(double amount)
        {
            try
            {    
                Balance -= amount > Balance ? throw new DomainException("Invalid Operation due the insufficient funds in the account")
                : amount > WithdrawLimit ? throw new DomainException("Invalid Operation due the withdraw limit")
                : amount;

                Console.WriteLine($"Withdraw completed.\n\n{this}\n");  
                
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                
            }
        }
        public override string ToString()
        {
            return $"{Number} - {Holder} - R$ {WithdrawLimit} withdraw limit\nBalance: R${Balance:F2}";
        }
    }
}