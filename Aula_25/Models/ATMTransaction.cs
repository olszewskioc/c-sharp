using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25.Models
{
    public class ATMTransaction(string tipo, double valor)
    {
        public string Tipo { get; private set; } = tipo;
        public double Valor { get; private set; } = valor;
    }
}