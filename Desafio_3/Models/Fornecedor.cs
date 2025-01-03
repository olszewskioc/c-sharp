using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_3.Models
{
    public class Fornecedor
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string CNPJ { get; set; }
        public bool Recorrente { get; set; }
        public double Desconto { get; set; }

        public double CalcularDesconto(double valor)
        {
            return Recorrente ? valor * Desconto : 0;
        }
    }
}