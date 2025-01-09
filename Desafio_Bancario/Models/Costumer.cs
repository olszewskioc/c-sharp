using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Bancario.Models
{
    public class Costumer(string name, Address address, DateTime dob, string cardNumber, string pin = "0000")
    {
        private string _name = name;
        private Address _address = address;
        private DateTime _dob = DateTime.Now - dob >= TimeSpan.FromDays(18 * 365) ? dob 
            : throw new ArgumentOutOfRangeException(nameof(dob), "The costumer needs to be more than 18 years old");
        private string _cardNumber = cardNumber.Length == 16 && cardNumber.All(char.IsDigit) ? cardNumber 
            : throw new ArgumentOutOfRangeException(nameof(cardNumber), "Card number must have 16 digits and all of them must be digits");
        private string _pin = pin.Length == 4 && pin.All(char.IsDigit) ? pin 
            : throw new ArgumentOutOfRangeException(nameof(pin), "Pin must have 4 digits");

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value), "Name cannot be null");
        }
        public Address Address
        {
            get => _address;
            set => _address = value ?? throw new ArgumentNullException(nameof(value), "Address cannot be null");
        }
        public DateTime DateOfBirth
        {
            get => _dob;
            // Dob needs to be more than 18 years old
            set => _dob = DateTime.Now - value >= TimeSpan.FromDays(18 * 365) ? value 
                : throw new ArgumentOutOfRangeException(nameof(value), "The costumer needs to be more than 18 years old");
        }
        public string CardNumber
        {
            get => _cardNumber;
            set => _cardNumber = value.Length == 16 && value.All(char.IsDigit) ? value 
                : throw new ArgumentOutOfRangeException(nameof(value), "Card number must have 16 digits and all of them must be digits");
        }

        public bool VerifyPassword(string password) => _pin.Equals(password);
    }
}