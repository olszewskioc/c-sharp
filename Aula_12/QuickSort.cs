using System;
namespace Aula_12
{
    public class QuickSort
    {
        static int Particionar(int[] vetor, int inicio, int fim)
        {
            int pivo = vetor[fim];
            int i = inicio - 1;
            for (int j = inicio; j < fim; j++)
            {
                Console.WriteLine($"\nPivo: {pivo}\tinicio: {i}\tfim: {fim}\tj: {j}");
                Print(vetor);
                if (vetor[j] < pivo)
                {
                    i++;
                    (vetor[j], vetor[i]) = (vetor[i], vetor[j]);
                }
                
            }

            (vetor[i + 1], vetor[fim]) = (vetor[fim], vetor[i + 1]);
            return i + 1;
        }
        static void Ordenar(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {

                int p = Particionar(vetor, inicio, fim);
                Ordenar(vetor, inicio, p - 1);
            }

            Print(vetor);
        }

        static void Print(int[] vet)
        {
            Console.WriteLine($"[{string.Join(", ", vet)}]");
        }
        static void dasd(string[] args)
        {
            int[] vet = [55, 68, 12, 44, 77, 1, 22];
            Ordenar(vet, 0, vet.Length - 1);
        }
    }
}