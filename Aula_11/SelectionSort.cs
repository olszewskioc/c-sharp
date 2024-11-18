using System;
namespace Aula_11
{
    public class SelectionSort
    {
        static void Ordenar(int[] vet)
        {
            int menor, aux;
            for (int i = 0; i < vet.Length - 1; i++)
            {
                menor = i;
                for (int j = i + 1; j < vet.Length; j++)
                {
                    if (vet[j] > vet[menor])
                    {
                        menor = j;
                    }
                }
                aux = vet[i];
                vet[i] = vet[menor];
                vet[menor] = aux;
                Print(vet);
            }
        }
        static void OrdenarDec(int[] vet)
        {
            int menor, aux;
            for (int i = 0; i < vet.Length - 1; i++)
            {
                menor = i;
                for (int j = i + 1; j < vet.Length; j++)
                {
                    menor = vet[j] < vet[menor] ? j : i;
                }
                aux = vet[i];
                vet[i] = vet[menor];
                vet[menor] = aux;
            }
        }

        static void Print(int[] vet)
        {
            Console.WriteLine($"[{string.Join(", ", vet)}]");
        }
        static void Main(string[] args)
        {
            int[] vet = [55, 68, 12, 44, 77, 1, 22];
            Ordenar(vet);
            // OrdenarDec(vet);
        }
    }
}