using System;
namespace Aula_10
{
    public class Recursiva2
    {
        static int[] ObterPares(int[] vetor, int n = 0)
        {
            if (n >= vetor.Length)
            {
                return new int[0];
            }

            // Chamar recursivamente os pares restantes do vetor
            int[] vetorPares = ObterPares(vetor, n + 1);

            if (vetor[n] % 2 == 0)
            {
                
                int[] result = new int[vetorPares.Length + 1];
                result[0] = vetor[n];
                vetorPares.CopyTo(result, 1);
                return result;
            }
            else
                return vetorPares;
        }
        static void Main(string[] args)
        {
            int[] vetor = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            int[] vetorPares = ObterPares(vetor);
            foreach (var item in vetorPares)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}