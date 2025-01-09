using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Bancario.Models.Enums;

namespace Desafio_Bancario.Models
{
    public class Address(string street, int number, string city, State state, string zipCode)
    {
        private string _street = street;
        private int _number = number;
        private string _city = city;
        private State _state = state;
        private string _zipCode = zipCode;

        public string Street
        {
            get => _street;
            set => _street = value ?? throw new ArgumentNullException(nameof(value), "Street cannot be null");
        }
        public int Number
        {
            get => _number;
            set => _number = value <= 0 ? throw new ApplicationException($"{nameof(value)} : Only positive numbers and greater than 0 are allowed") : value;
        }
        public string City
        {
            get => _city;
            set => _city = value ?? throw new ArgumentNullException(nameof(value), "City cannot be null");
        }
        public State State
        {
            get => _state;
            set
            {
                try
                {
                    _state = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string ZipCode
        {
            get => _zipCode;
            set => _zipCode = value ?? throw new ArgumentNullException(nameof(value), "Zip Code cannot be null");
        }
    }
}