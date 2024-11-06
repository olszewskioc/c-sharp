// 2. Somar os Elementos de Cada Linha de uma Matriz 4x4 (Função Anônima usando
// Delegate)
// Enunciado: Dada uma matriz 4x4 preenchida com valores, some os elementos de cada
// linha e exiba o resultado. Use uma função anônima com delegate para somar os
// elementos de cada linha.
// Requisitos:
// • Criar uma matriz 4x4 preenchida com valores numéricos.
// • Criar uma função anônima usando delegate para somar os elementos de uma
// linha.
// • Processar e exibir a soma de cada linha no console.

using System;
namespace Aula_8
{
    internal class Ex2
    {
        public delegate int Operation(int[,] mat, int line);
        static int SumLine(int[,] mat, int line) => mat[line, 0] + mat[line, 1] + mat[line, 2] + mat[line, 3];
        static void Mains(string[] args)
        {
            Console.Clear();

            Operation operation = SumLine;

            int[,] matriz = new int[4, 4]
            {
                {10, 11, 12, 16},
                {7, 8, 9, 15},
                {4, 5, 6, 14},
                {1, 2, 3, 13},
            };
            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"Soma linha {i}: {operation(matriz, i)}");
            }

            Console.WriteLine($"\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}