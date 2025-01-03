using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_3.Models
{
    public class Imposto
    {
        public double TotalVendas { get; set; }
        public double TotalSalarios { get; set; }

        public double CalcularImpostoVendas()
        {
            return TotalVendas * 0.1;
        }
        public double CalcularImpostoSalarios()
        {
            return TotalSalarios * 0.2;
        }
    }
}