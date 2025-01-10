using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Bancario.Models.Enums;

namespace Desafio_Bancario.Models
{
    public class Transaction(int id, TransactionType type, double amount, double postBalance, Account? source = null, Account? destination = null)
    {
        private int _id = id;
        private DateTime _date = DateTime.Now;
        private TransactionType _type = type;
        private double _amount = amount;
        private double _postBalance = postBalance;
        private Account? _source = source;  // Null if type is Withdraw
        private Account? _destination = destination;  // Null if type is Deposit

        public int Id { get => _id; }
        public DateTime Date { get => _date; }
        public TransactionType Type { get => _type; }
        public double Amount { get => _amount; }
        public double PostBalance { get => _postBalance; }
        public Account? Source { get => _source; }
        public Account? Destination { get => _destination;}

        public override string ToString()
        {
            string s = $"ID: {Id}\nDate: {Date}\nType: {TransactionHelper.GetType(Type)}\nAmount: {Amount}\nPost Balance: {PostBalance}\n";
            return s += Source != null ? $"Source: {Source}\n" : Destination != null ? $"Destination: {Destination}\n" : "";
        }
    }
}