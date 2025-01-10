using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Bancario.Models;

namespace Desafio_Bancario
{
    public class Bank(int code, Address address)
    {
        private int _code = code;
        private Address _address = address;
        private List<Account> _accounts = [new Account("Gerente", "9999", 0, new Costumer("Gerente", null, DateTime.MinValue, "9999999999999999", "9999"))];
        private List<ATM> _ATMs = [];

        public int Code { get; }
        public Address Address 
        { 
            get => _address;
            set => _address = value ?? throw new ArgumentNullException(nameof(value));
        }
        public List<Account> Accounts
        {
            get => _accounts;
            set => _accounts = value ?? throw new ArgumentNullException(nameof(value));
        }
        public List<ATM> ATMs
        {
            get => _ATMs;
            set => _ATMs = value ?? throw new ArgumentNullException(nameof(value));
        }

    }
}