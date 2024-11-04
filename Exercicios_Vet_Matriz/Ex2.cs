// Escreva um programa que peça ao usuário para inserir 10 números em um vetor e
// calcule a média desses valores

using System;
namespace Exercicios_Vet_Matriz
{
    public class Ex2
    {
        static void Teste(string[] args)
        {
            Console.Clear();
            
            int[,] matriz = new int[4, 4]
            {
                {10, 11, 12, 16},
                {7, 8, 9, 15},
                {4, 5, 6, 14},
                {1, 2, 3, 13},
            };
            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"Soma linha {i + 1}: {matriz[i, 0] + matriz[i, 1] + matriz[i, 2] + matriz[i, 3]}");
            }

            Console.WriteLine($"\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}
