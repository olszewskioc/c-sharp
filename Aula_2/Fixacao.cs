using System;
using System.Globalization;
namespace Aula_2
{
    internal  class Fixacao
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("\nInforme seu nome completo: ");
            string name = Console.ReadLine();

            Console.Write("\nQuantos quartos tem na sua casa: ");
            int rooms = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o preço de um produto: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nInforme seu último nome, idade e altura (Na mesma linha): ");
            string line = Console.ReadLine();
            string[] values = line.Split(' ');
            string lastName = values[0]; 
            int age = int.Parse(values[1]);
            double height = double.Parse(values[2], CultureInfo.InvariantCulture);
            
            Console.Clear();
            Console.WriteLine($"\nNome: {name}\nQuartos: {rooms}\nPreço: R${price.ToString("N3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Último nome: {lastName}\nIdade: {age} anos\nAltura: {height.ToString("N2", CultureInfo.InvariantCulture)} m");
            Console.WriteLine("\nAperte qualquer tecla para continuar!");
            Console.ReadKey();
            Console.Clear();
            
        }
    }

}