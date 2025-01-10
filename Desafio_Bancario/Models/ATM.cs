using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Bancario.Models
{
    public class ATM(Address address, Bank bank)
    {
        private Address _location = address;
        private Bank _managedBy = bank;

        public Address Address
        {
            get => _location;
            set => _location = value ?? throw new ArgumentNullException(nameof(value));
        }
        public Bank ManagedBy
        {
            get => _managedBy;
            set => _managedBy = value ?? throw new ArgumentNullException(nameof(value));
        }

        public Account? Identifies(string number, string type)
        {
            try
            {
                if (type == "Current")
                {
                    List<CurrentAccount> currentAccounts = ManagedBy.Accounts
                    .OfType<CurrentAccount>()
                    .ToList();
                    return currentAccounts.Find(c => c.Number == number) ?? throw new Exception("Account not found");
                }
                else if (type == "Saving")
                {
                    List<SavingAccount> savingAccounts = ManagedBy.Accounts
                    .OfType<SavingAccount>()
                    .ToList();
                    return savingAccounts.Find(c => c.Number == number) ?? throw new Exception("Account not found");
                }
                else
                {
                    throw new ArgumentException("Invalid account type");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        public void Transactions(Account account)
        {
            try
            {
                foreach (var transaction in account.Transactions)
                {
                    Console.WriteLine($"{transaction}");
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}