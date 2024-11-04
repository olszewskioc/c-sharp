// 3. Ler uma matriz 4 x 4 e calcular a soma do maior com o menor elemento
// da matriz.

using System;
namespace Aula_7
{
    public class Ex3
    {
        static void Teste(string[] args)
        {
            int[,] matriz = new int[4, 4]
            {
                {1, 2, 3, 13},
                {4, 5, 6, 14},
                {7, 8, 9, 15},
                {10, 11, 12, 16},
            };
            
            int max = int.MinValue, min = int.MaxValue;
            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
               for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    max = matriz[i, j] > max ? matriz[i, j] : max;
                    min = matriz[i, j] < min ? matriz[i, j] : min;
                } 
            }
            Console.WriteLine($"{max} + {min} = {max + min}");
        }
    }
}