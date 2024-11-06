using System;
namespace Aula_8
{
    public class Program
    {
        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int SomaVetor(int[] vet)
        {
            int soma = 0;
            for(int i = 0; i < vet.Length; i++)
            {
                soma += vet[i];
            }
            return soma;
        }
        static int SomaMatriz(int[,] mat)
        {
            int soma = 0;
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    soma += mat[i, j];
                }
            }
            return soma;
        }

        
        static void Teste(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"{a} + {b} = {Soma(a, b)}");

            int[] vet = [1, 2, 3, 4, 5];
            Console.WriteLine($"{SomaVetor(vet)}");

            int[,] mat = { 
                {1, 2, 3}, 
                {4, 5, 6} 
            };
            Console.WriteLine($"{SomaMatriz(mat)}");

            Modifiers m = new Modifiers();
            Console.WriteLine(m.Subtrai(10, 5));

        }
    }
}