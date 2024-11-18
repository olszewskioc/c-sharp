using System;
namespace Aula_12
{
    public class MergeSort
    {
        static void Intercalar(int[] vetor, int inicio, int meio, int fim)
        {
            int[] aux  = new int[vetor.Length];
            for (int i = inicio; i <= fim; i++)
            {
                aux[i] = vetor[i];
            }
            Print(aux);

            int i1 = inicio, i2 = meio + 1, i3 = inicio;

            while(i1 <= meio && i2 <= fim)
            {
                if (aux[i1] < aux[i2])
                {
                    vetor[i3] = aux[i1];
                    i1++;
                }
                else
                {
                    vetor[i3] = aux[i2];
                    i2++;
                }
                i3++;
                 }
            while (i1 <= meio)
                {
                vetor[i3] = aux[i1];
                i1++;
                i3++;
            }
            Print(vetor);
        }
        static void Ordenar(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int meio = (inicio + fim) / 2;
                Ordenar(vetor, inicio, meio);
                Ordenar(vetor, meio + 1, fim);
                Intercalar(vetor, inicio, meio, fim);
            }
            // Print(vetor);
        }

        static void Print(int[] vet)
        {
            Console.WriteLine($"[{string.Join(", ", vet)}]");
        }
        static void afdsa(string[] args)
        {
            int[] vet = [55, 68, 12, 44, 77, 1, 22];
            Ordenar(vet, 0, vet.Length - 1);
        }
    }
}