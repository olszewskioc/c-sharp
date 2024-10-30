using System;
namespace Aula_6
{
    internal class Program
    {
        static void Teste(string[] args)
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[] {1, 2, 3, 4, 5};
            int[] vetor3 = [1, 2, 3, 4, 5];
            int[] vetor4 = []; // Vetor Vazio

            // Percorrendo o vetor
            for (int i = 0; i < vetor3.Length; i++)
            {
                Console.WriteLine($"Vetor 3[{i}] = {vetor3[i]}");
            }
            
        }
    }
}