using System;
namespace Aula_3
{
    internal class MyClass
    {
        static void Teste(string[] args)
        {
            // Using conditionals strcutures
            Console.Clear();
            Console.WriteLine("Informe sua idade: ");
            int number = int.Parse(Console.ReadLine());

            // switch (number)
            // {
            //     case int n when n >= 18 && n <= 50:
            //         Console.WriteLine("Adulto");
            //         break;
            //     case int n when n > 50 && n <= 100:
            //         Console.WriteLine("Idoso");
            //         break;
            //     case int n when n > 100:
            //         Console.WriteLine("Morto");
            //         break;
            //     default:
            //         Console.WriteLine("Criança");
            //         break;
            // }

            string result = number >= 18 && number <= 50 ? "Adulto"
            : number > 50 && number < 100  ? "Idoso" 
            : number > 100 ? "Morto" : "Criança";

            Console.WriteLine(result);
            Console.WriteLine("\nDigite qualquer tecla para sair!");
            Console.ReadKey();
            Console.Clear();

        }
    }
}