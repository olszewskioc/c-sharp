using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Bancario.Models
{
    public class Account(string number, double balance, Costumer costumer)
    {
        private string _number = number;
        private double _balance = balance;
        private Costumer _costumer = costumer;
        private List<Transaction> _transactions = [];
    }
}