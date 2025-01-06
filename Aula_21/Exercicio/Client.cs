using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21.Exercicio
{
    public class Client(string name, string email, DateTime birthDate)
    {
        public string Name { get; set; } = name;
        public string Password { get; set; } = email;
        public DateTime BirthDate { get; set; } = birthDate;
    }
}