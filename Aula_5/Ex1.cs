// Escreva um algoritmo que receba 10 números inteiro e positivos. Em
// seguida o algoritmos deverá mostrar o menor e o maior deles.

using System;
namespace Aula_5
{
    internal class Ex1
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            int num, max = int.MinValue, min = int.MaxValue;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"\nDigite o {i + 1}º valor: ");
                num = Convert.ToInt32(Console.ReadLine());
                max = num >  max ? num : max;
                min = num < min ? num : min;
            }

            Console.WriteLine($"\n\nMaior valor: {max}\tMenor valor: {min}");

        }
    }
}