// Crie um programa para rotacionar uma matriz n x n 90 graus no sentido horário.

using System;
namespace Exercicios_Vet_Matriz
{
    public class Ex5
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("\nInforme o valor de n para a matriz quadrada n x n: ");
            int n  = int.Parse(Console.ReadLine());


            int[,] matriz = new int[n,n];
            Random r = new Random();

            // Gerando matriz aleatoriamente de tamanho n x n e a imprimindo
            Console.WriteLine($"\nOriginal\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matriz[i, j] = r.Next(100)}\t");
                }
                Console.WriteLine();
            }

            // Transpõe a matriz
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int temp = matriz[i, j];
                    matriz[i, j] = matriz[j, i];
                    matriz[j, i] = temp;
                }
            }

            Console.WriteLine($"\nTransposta\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matriz[i, j]}\t");
                }
                Console.WriteLine();
            }

            // troca de colunas
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int temp = matriz[i, j];
                    matriz[i, j] = matriz[i, n - j - 1];
                    matriz[i, n - j - 1] = temp;
                }
            }

            Console.WriteLine($"\nRotacionada\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matriz[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}