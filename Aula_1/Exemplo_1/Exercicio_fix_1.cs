using System;
using System.Globalization;
namespace Exemplo_1
{
    internal class Exercicio_fix_1
    {
        static void Main(String[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double preco3 = 53.234567;
            

            Console.WriteLine($"Produtos:\n{produto1}, cujo preço é $ {preco1}\n{produto2}, cujo preço é $ {preco2}");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine($"Medida com oito casas decimais: {preco3:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {preco3:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {preco3.ToString("N3", CultureInfo.InvariantCulture)}");


        }
    }
}

