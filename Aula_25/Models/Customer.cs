using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25.Models
{
    public class Customer(string nome)
    {
        public string Nome { get; private set; } = nome;
    }
}