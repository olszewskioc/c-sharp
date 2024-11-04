// 5. Ler duas matrizes 4 x 4 e calcular a soma das matrizes.

using System;
namespace Aula_7
{
    public class Ex5
    {
        static void Teste(string[] args)
        {
            int[,] matriz1 = new int[4, 4]
            {
                {1, 2, 3, 13},
                {4, 5, 6, 14},
                {7, 8, 9, 15},
                {10, 11, 12, 16},
            };

            int[,] matriz2 = new int[4, 4]
            {
                {10, 11, 12, 16},
                {7, 8, 9, 15},
                {4, 5, 6, 14},
                {1, 2, 3, 13},
            };

            int[,] matrizSoma = new int[4,4];
            
            
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for  (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    matrizSoma[i, j] +=  matriz1[i, j] + matriz2[i, j];
                    Console.Write($"{matrizSoma[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}