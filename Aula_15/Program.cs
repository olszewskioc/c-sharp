using System;
using Aula_15;

namespace Aula_15
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Cachorro cachorro = new()
            {
                raca = "Bordercollie",
                nome = "Luffy",
                idade = 3
            };

            Padaria padaria= new()
            {
                NomeAlimento = "Pão de metro",
                Preco = 50,
                Bebidas = "Pingado",
                Doces = "Sonho",
                DataValidade = DateTime.Today.AddDays(10),
            };

            List<(string, double)> values =
            [
                ("Pão", 25.55),
                ("Sonho", 10.00),
            ];

            cachorro.Escreve();
            Console.WriteLine($"{padaria.Encomenda()}");
            Console.WriteLine($"Cesta: R${padaria.CestaCompras(values)}");

            Produto produto = new Produto();
            produto.Exibir();
        }
    }
}