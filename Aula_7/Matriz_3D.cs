using System;
namespace Aula_7
{
    public class Matriz_3D
    {
        static void Teste(string[] args)
        {
            int[,,] matriz = new int[2, 2, 2]
            {
                {
                    {1, 2},
                    {5, 6},
                },
                {
                    {3, 4},
                    {7, 8},
                },
            };
            
            int sum = 0;
            
            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for  (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         for  (int z = 0; z < matriz.GetLength(2); z++)
            //         {
            //             Console.WriteLine($"{sum} + {matriz[i, j, z]} = {sum +=  matriz[i, j, z]}");
            //         }
            //     }

            // }

            foreach (int item in matriz)
            {
                Console.WriteLine($"{sum} + {item} = {sum += item}");
            }   
        }
    }
}