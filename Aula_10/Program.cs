using System;
namespace Aula_10
{
    public class Program
    {
        static void Teste(string[] args)
        {
            int[] numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            // Variável implícita = Autodefine tipo
            var impares = numeros.Where(n => n % 2 != 0);


            foreach (var num in impares)
            {
                Console.WriteLine($"{num}");
            }

            var dicionario = new Dictionary<string, int>
            {
                {"C#", 1},
                {"Java", 2},
                {"Python", 3},
            };
            Console.WriteLine($"{dicionario.GetType()}");

            foreach (var item in dicionario)
            {
                Console.WriteLine($"{item}");
            }
            
        }
    }
}