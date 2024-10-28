using System;
namespace Aula_3
{
    internal class Par_Impar
    {
        static void Teste1(string[] args)
        {
            Console.Clear();
            Console.Write("Informe um número: ");
            int  num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{(num % 2 == 0 ? "Par" : "Ímpar")}");

        }
    }
}