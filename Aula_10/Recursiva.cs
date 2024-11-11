using System;
namespace Aula_10
{
    public class Recursiva
    {
        static long Fatorial(int n)
        {
            return n == 0 ? 1 : n * Fatorial(n - 1);
        }

        static long Fibonacci(int n)
        {
            return (n == 0 || n == 1) ? 1 : Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static long FibonacciLoop(int n)
        {
            int sum = 1;
            int anterior = 0, anterior2 = 1;

            for (int i = 2; i <= n; i++)
            {
                sum = anterior + anterior2;
                anterior = sum;
                anterior2 = anterior;
            }

            return sum;
        }
        static int SomaPares(int[] vetor, int n)
        {
            if (n == 0)
                return 0;
            else if (vetor[n - 1] % 2 == 0)
                return vetor[n - 1] + SomaPares(vetor, n - 1);
            else
                return SomaPares(vetor, n - 1);
        }
        static int SomaImpares(int[] vetor, int n)
        {
            if (n == 0)
                return 0;
            else if (vetor[n - 1] % 2 != 0)
                return vetor[n - 1] + SomaImpares(vetor, n - 1);
            else
                return SomaImpares(vetor, n - 1);
        }
        static void Te(string[] args)
        {
            int[] vet = [1, 2, 3, 4, 4];

            Console.WriteLine($"{Fatorial(39)}");
            Console.WriteLine($"{Fibonacci(5)}");
            Console.WriteLine($"{FibonacciLoop(5)}");
            Console.WriteLine($"{SomaPares(vet, vet.Length)}");
            Console.WriteLine($"{SomaImpares(vet, vet.Length)}");
        }
    }
}