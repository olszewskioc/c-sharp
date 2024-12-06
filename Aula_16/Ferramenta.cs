using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16
{
    public class Ferramenta(string? nome=null, double preco=0.0, int quantidade=0)
    {
        public string? Nome = nome;
        public double Preco = preco;
        public int Quantidade = quantidade;

        public double CalcularEstoque()
        {
            return (double)Quantidade * Preco;
        }

        public void Print()
        {
            Console.WriteLine($"\nTipo: Ferramenta\nNome: {Nome}        Preço: R${Preco:F2}        Quantidade: {Quantidade}");
        }
    }
}