using System;
namespace Aula_11
{
    public class BubbleSort
    {
        static void Ordenar(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = 0; j < vet.Length - 1; j++)
                {
                    if (vet[j] < vet[j + 1])
                    {
                        (vet[j], vet[j + 1]) = (vet[j + 1], vet[j]);
                        Print(vet);
                    }
                }
            }
        }

        static void Print(int[] vet)
        {
            Console.WriteLine($"[{string.Join(", ", vet)}]");
        }
        static void Bubl(string[] args)
        {
            int[] vet = [55, 68, 12, 44, 77, 1, 22];
            Ordenar(vet);
        }
    }
}