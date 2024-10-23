using System;
namespace Exemplo_1
{
    internal class Program
    {
        static void Teste(String[] args)
        {
            int age = 22;
            double balance = 9.565656;
            string name = "Thiago";
            char genre = 'M';
            char letter = '\u0050';
            bool isAlive = true;
            Type tipo = isAlive.GetType();

            Console.WriteLine($"Olá {letter} {name} ({genre}), você tem {age} anos e R${balance:F2} na conta.");
            Console.WriteLine("Está " + (isAlive ? "Vivo" : "Morto"));
            
        }
    }
}