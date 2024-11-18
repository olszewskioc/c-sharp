using System;
namespace Aula_11
{
    public class BubbleSort
    {
        static void Ordenar(int[] vet)
        {
            int aux;
            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = 0; j < vet.Length - 1; j++)
                {
                    if (vet[j] < vet[j + 1])
                    {
                        aux = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = aux;
                        Print(vet);
                    }
                }
            }
        }

        static void Print(int[] vet)
        {
            Console.WriteLine($"[{string.Join(", ", vet)}]");
        }
        static void Bu(string[] args)
        {
            int[] vet = [55, 68, 12, 44, 77, 1, 22];
            Ordenar(vet);
        }
    }
}