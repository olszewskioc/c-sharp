using System;
namespace Aula_11
{
    public class InsertionSort
    {
        static void Ordenar(int[] vet)
        {
            for (int i = 1; i < vet.Length; i++)
            {
                int aux = vet[i];
                int j = i - 1;

                while(j >= 0 && vet[j] < aux)
                {
                    Print(vet);
                    vet[j + 1] = vet[j];
                    --j;
                }

                vet[j + 1] = aux;
                Print(vet);
            }
        }

        static void Print(int[] vet)
        {
            Console.WriteLine($"[{string.Join(", ", vet)}]");
        }
        static void Inse(string[] args)
        {
            int[] vet = [55, 68, 12, 44, 77, 1, 22];
            Ordenar(vet);
        }
    }
}