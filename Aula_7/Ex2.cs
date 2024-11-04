using System;
namespace Aula_7
{
    internal class Ex2
    {
        static void Teste(string[] args)
        {
            Console.Clear();
            
            int[] vet = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"\nDigite o {i + 1}º valor: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"\n\nMaior valor: {vet.Max()}\tMenor valor: {vet.Min()}");

        }
    }
}