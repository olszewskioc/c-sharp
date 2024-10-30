// Escreva um algoritmo que dado uma quantidade indeterminada de
// números inteiros e positivos, informe o menor e o maior. Utilize o
// número -1 como finalizador, ou seja, servirá como recurso de saída do
// laço de repetição

using System;
namespace Aula_5
{
    internal class Ex4
    {
        static void Maior_menor_infinito(string[] args)
        {
            Console.Clear();
            
            int num = 0, max = int.MinValue, min = int.MaxValue, i = 1;
            
            while (num != -1)
            {
                max = num >  max && i != 1 ? num : max;
                min = num < min && i != 1 ? num : min;
                Console.Write($"\nDigite o {i++}º valor: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"\n\nMaior valor: {max}\tMenor valor: {min}");

        }
    }
}