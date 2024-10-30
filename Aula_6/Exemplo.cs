using System;

namespace Aula_6
{
    public class Exemplo
    {
        static void Ex1(string[] args)
        {
            // 1. Ler um vetor com 10 inteiros e mostrar os valores
            // em ordem crescente e decrescente.
            int[] vet = new int[10];
            Random r =  new Random();

            for (int i = 0; i < 10; i++)
            {
                vet[i] = r.Next(100);
            }
            Console.Write($"vet = [ ");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($"{vet[i]}, ");
            }
            Console.WriteLine($"]");

            Console.Write($"vet = [ ");
            for (int i = 9; i >= 0; i--)
            {
                Console.Write($"{vet[i]}, ");
            }
            Console.WriteLine($"]");
        }
    }
}