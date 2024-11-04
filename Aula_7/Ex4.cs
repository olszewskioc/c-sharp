// 4. Ler uma matriz 4 x 4 e calcular a soma dos elementos da diagonal
// principal.

using System;
namespace Aula_7
{
    public class Ex4
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
            
            int sum = 0;
            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                sum += matriz[i, i];
            }
            
            Console.WriteLine($"{sum}");
            
        }
    }
}