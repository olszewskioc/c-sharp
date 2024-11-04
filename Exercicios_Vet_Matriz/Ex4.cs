// Dada uma matriz quadrada n x n, exiba a soma dos elementos da diagonal
// principal e da diagonal secundária.

using System;
namespace Exercicios_Vet_Matriz
{
    public class Ex4
    {
        static void Teste(string[] args)
        {
            Console.Clear();
            Console.Write("\nInforme o valor de n para a matriz quadrada n x n: ");
            int n  = int.Parse(Console.ReadLine());
            int sumP = 0, sumS = 0;

            int[,] matriz = new int[n,n];
            Random r = new Random();

            // Gerando matriz aleatoriamente de tamanho n x n e a imprimindo

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matriz[i, j] = r.Next(100)}\t");
                    sumP += i == j ?  matriz[i, j] : 0;
                    sumS += (i + j == n - 1) ?  matriz[i, j] : 0;
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\n\nSoma Diagonal Principal: {sumP}\nSoma Diagonal Secundária: {sumS}");
            Console.WriteLine($"\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}