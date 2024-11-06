// 5. Rotacionar uma Matriz n x n 90 Graus no Sentido Horário (Função Privada e Pública)
// Enunciado: Crie um programa para rotacionar uma matriz n x n 90 graus no sentido
// horário. Utilize uma função private para realizar a rotação e uma função public para exibir
// a matriz rotacionada.
// Requisitos:
// • Criar uma função private que receba uma matriz n x n e realize a rotação de 90
// graus.
// • Criar uma função public que exiba a matriz no console.
// • Chamar as funções adequadamente para processar e exibir a matriz rotacionada.

using System;
namespace Exercicios_Vet_Matriz
{
    public class Ex5
    {
        private int[,] Rotate(int[,] matrix, int tam)
        {
            // Transpõe a matriz
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }

            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam / 2; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, tam - j - 1];
                    matrix[i, tam - j - 1] = temp;
                }
            }

            return matrix;
            
        }

        public void PrintMatrix(int[,] matrix, int tam)
        {
            Console.WriteLine($"\nRotacionada\n");
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("\nInforme o valor de n para a matriz quadrada n x n: ");
            int tam  = Convert.ToInt32(Console.ReadLine());


            int[,] matriz = new int[tam,tam];
            int[,] matriz_rotate = new int[tam,tam];
            Random r = new Random();

            // Gerando matriz aleatoriamente de tamanho n x n e a imprimindo
            Console.WriteLine($"\nOriginal\n");
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    Console.Write($"{matriz[i, j] = r.Next(100)}\t");
                }
                Console.WriteLine();
            }

            Ex5 ex5 = new Ex5();
            matriz_rotate = ex5.Rotate(matriz, tam);
            ex5.PrintMatrix(matriz_rotate, tam);

            Console.WriteLine($"\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}