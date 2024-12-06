using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16
{
    public record Lacticinio(string? Nome=null, double Preco=0.0, int Quantidade=0)
    {
        public string? Nome = Nome;
        public double Preco = Preco;
        public int Quantidade = Quantidade;

        public double CalcularEstoque()
        {
            return (double)Quantidade * Preco;
        }
        public void Print()
        {
            Console.WriteLine($"\nTipo: Lacticínio\nNome: {Nome}        Preço: R${Preco:F2}        Quantidade: {Quantidade}");
        }
    }
}