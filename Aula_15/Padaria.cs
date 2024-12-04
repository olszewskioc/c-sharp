using System;
using System.Numerics;
namespace Aula_15
{
    public class Padaria
    {
        public string ?NomeAlimento;
        public double Preco;
        public string ?Bebidas;
        public string ?Doces;
        public DateTime DataValidade;

        public string Encomenda()
        {
            return $"Encomenda: {NomeAlimento}: R${Preco:F2}";
        }

        // public double CestaCompras(string nome, double preco)
        // {
        //     return Preco + preco;
        // }
        public double CestaCompras(List<(string nome, double preco)> itens)
        {
            double total = Preco;
            foreach (var (nome, preco) in itens)
            {
                Console.WriteLine($"{nome}: R${preco}");
                total += preco;
            }

            return total;
        }
    }
}