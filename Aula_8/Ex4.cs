// 4. Soma das Diagonais de uma Matriz n x n (Função Pública)
// Enunciado: Dada uma matriz quadrada n x n, crie uma função pública que exiba a soma
// dos elementos da diagonal principal e da diagonal secundária.
// Requisitos:
// • Criar uma função pública que receba uma matriz quadrada e retorne a soma das
// diagonais.
// • A função deve somar os elementos da diagonal principal e secundária e retornar o
// resultado.
// • Exibir a soma das diagonais no console.

using System;
namespace Aula_8
{
    public class Ex4
    {
        public int[] SumMatrix(int[,] matrix, int n)
        {
            int sumP = 0, sumS = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sumP += i == j ?  matrix[i, j] : 0;
                    sumS += (i + j == n - 1) ?  matrix[i, j] : 0;
                }
            }
            int[] temp =  [sumP, sumS];
            // Console.WriteLine($"{temp[0]} {temp[1]}");
            return temp;

        }
        static void Mains(string[] args)
        {
            Console.Clear();
            Console.Write("\nInforme o valor de n para a matriz quadrada n x n: ");
            int n  = Convert.ToInt32(Console.ReadLine());

            int[,] matriz = new int[n,n];
            Random r = new Random();

            // Gerando matriz aleatoriamente de tamanho n x n e a imprimindo

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matriz[i, j] = r.Next(100)}\t");
                }
                Console.WriteLine();
            }

            Ex4 m = new Ex4();
            int[] result = m.SumMatrix(matriz, n);

            Console.WriteLine($"\n\nSoma Diagonal Principal: {result[0]}\nSoma Diagonal Secundária: {result[1]}");
            Console.WriteLine($"\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}