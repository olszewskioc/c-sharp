using System;
namespace Aula_12
{
    public class Desafio
    {
        static void BubbleSort()
        // Exercício 1
        // Implemente o algoritmo Bubble Sort em C# para ordenar uma lista de números inteiros
        // fornecida pelo usuário.

        {
            Console.Clear();
            Console.Write("\nInforme o tamanho do vetor: ");
            int tam = Convert.ToInt32(Console.ReadLine());
            int[] vet = new int[tam];
            Console.WriteLine("\n");

            for(int i = 0; i < tam; i++)
            {
                Console.Write($"\nInforme o {i + 1}º valor do vetor: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }
            Print(vet);
            Console.WriteLine($"\n");
            

            int aux;
            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = 0; j < vet.Length - 1; j++)
                {
                    if (vet[j] > vet[j + 1])
                    {
                        aux = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = aux;
                    }
                }
            }
            Print(vet);
        }
        static void BubbleSortUp()
        // Exercício 2
        // Modifique o algoritmo Bubble Sort para que ele pare de executar se, em uma passagem
        // pelo array, nenhum elemento for trocado
        {
            Console.Clear();
            Console.Write("\nInforme o tamanho do vetor: ");
            int tam = Convert.ToInt32(Console.ReadLine());
            int[] vet = new int[tam];
            Console.WriteLine("\n");

            for(int i = 0; i < tam; i++)
            {
                Console.Write($"\nInforme o {i + 1}º valor do vetor: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }
            Print(vet);
            Console.WriteLine($"\n");
            

            int aux;
            int iter = 0;
            bool ordenado = true;
            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = 0; j < vet.Length - 1; j++)
                {
                    if (vet[j] > vet[j + 1])
                    {
                        aux = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = aux;
                        ordenado = false;
                    }
                    iter++;
                }
                if (ordenado)
                    break;
            }

            Console.WriteLine($"Número de iterações: {iter}");
            Print(vet);
        }

        static void SelectionName()
        // Exercício 3
        // Crie um programa que use o Selection Sort para ordenar um array de strings em ordem
        // alfabética.
        {
            Console.Clear();
            Console.Write("\nInforme os nomes separados por espaço: ");
            string[] nomes = Console.ReadLine().Split(' ');

            int menor;
            string aux;
            for (int i = 0; i < nomes.Length - 1; i++)
            {
                menor = i;
                for (int j = i + 1; j < nomes.Length; j++)
                {
                    if (nomes[j][0] < nomes[menor][0])
                    {
                        menor = j;
                    }
                }
                aux = nomes[i];
                nomes[i] = nomes[menor];
                nomes[menor] = aux;
            }
            Print(nomes);
        }

        static void InsertionSort(int[] vet)
        {
            Console.Clear();
            Console.Write($"\nVetor Fornecido: ");
            Print(vet);
            for (int i = 1; i < vet.Length; i++)
            {
                int aux = vet[i];
                int j = i - 1;

                while(j >= 0 && vet[j] < aux)
                {
                    vet[j + 1] = vet[j];
                    --j;
                }

                vet[j + 1] = aux;
            }
            Console.Write($"\nVetor Ordenado: ");
            Print(vet);
        }

        static void Selection(int[] vet)
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

        static void Bubble(int[] vet)
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
                    }
                }
            }
        }

        static void Insertion(int[] vet)
        {
            for (int i = 1; i < vet.Length; i++)
            {
                int aux = vet[i];
                int j = i - 1;

                while(j >= 0 && vet[j] < aux)
                {
                    vet[j + 1] = vet[j];
                    --j;
                }

                vet[j + 1] = aux;
            }
        }

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
        static void Merge(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int meio = (inicio + fim) / 2;
                Merge(vetor, inicio, meio);
                Merge(vetor, meio + 1, fim);
                Intercalar(vetor, inicio, meio, fim);
            }
            // Print(vetor);
        }
        static void Compare()
        // Exercício 5
        // Implemente os três algoritmos de ordenação (Bubble Sort, Selection Sort e Insertion
        // Sort) e compare o tempo que cada um leva para ordenar um array de 1.000 números
        // inteiros gerados aleatoriamente.
        {
            int[] vet = new int[1000];

            Random r = new Random();
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = r.Next(10000);
            }

            int[] vet2 = (int[]) vet.Clone();
            int[] vet3 = (int[]) vet.Clone();
            int[] vet4 = (int[]) vet.Clone();
            int[] vet5 = (int[]) vet.Clone();

            // BubbleSort
            // var bubble = System.Diagnostics.Stopwatch.StartNew();
            var bubble = DateTime.Now.Ticks;
            Bubble(vet);
            // bubble.Stop();
            // var timeB = bubble.Elapsed.TotalMilliseconds;
            var timeB = DateTime.Now.Ticks - bubble;
            Console.WriteLine($"Bubble: {timeB/10} microS");

            // SelectionSort
            // var selection = System.Diagnostics.Stopwatch.StartNew();
            var selection = DateTime.Now.Ticks;
            Selection(vet2);
            // selection.Stop();
            // var timeS = selection.Elapsed.TotalMilliseconds;
            var timeS = DateTime.Now.Ticks - selection;
            Console.WriteLine($"Selection: {timeS/10} microS");

            // InsertionSort
            // var insertion = System.Diagnostics.Stopwatch.StartNew();
            var insertion = DateTime.Now.Ticks;
            Insertion(vet3);
            // insertion.Stop();
            // var timeI = insertion.Elapsed.TotalMilliseconds;
            var timeI = DateTime.Now.Ticks - insertion;
            Console.WriteLine($"Insertion: {timeI/10} microS");

            // MergeSort
            var merge = DateTime.Now.Ticks;
            Insertion(vet4);
            var timeM = DateTime.Now.Ticks - merge;
            Console.WriteLine($"Merge: {timeM/10} microS");

            // QuickSort
            var quick = DateTime.Now.Ticks;
            Insertion(vet5);
            var timeQ = DateTime.Now.Ticks - quick;
            Console.WriteLine($"Quick: {timeQ/10} microS");

            string best = (timeB < timeI && timeB < timeS && timeB < timeM && timeB < timeQ) ? "BubbleSort" 
            : (timeS < timeI && timeS < timeB && timeS < timeM && timeS < timeQ) ? "SelectionSort" 
            : (timeI < timeS && timeI < timeB && timeI < timeM && timeI < timeQ) ? "InsertionSort"
            : (timeM < timeS && timeM < timeB && timeM < timeI && timeM < timeQ) ? "MergeSort"
            : "QuickSort";

            Console.WriteLine($"\nO algoritmo com menor tempo foi: {best}");

        }
        static void Print(int[] vet)
        {
            Console.WriteLine($"\n[{string.Join(", ", vet)}]");
        }
        static void Print(string[] vet)
        {
            Console.WriteLine($"\n[{string.Join(", ", vet)}]");
        }

        static void Media(string[] vet)
        {
            int[] medias = new int[vet.Length];
            for (int i = 0; i < medias.Length; i++)
            {
                string[] aux = vet[i].Split(", ");
                int media = (Convert.ToInt32(aux[1]) + Convert.ToInt32(aux[2]) + Convert.ToInt32(aux[3])) / 3;
                medias[i] = media;
            }
            for (int i = 1; i < medias.Length; i++)
            {
                int aux = medias[i];
                string aux2 = vet[i];
                int j = i - 1;

                while(j >= 0 && medias[j] < aux)
                {
                    medias[j + 1] = medias[j];
                    vet[j + 1] = vet[j];
                    --j;
                }

                medias[j + 1] = aux;
                vet[j + 1] = aux2;
            }

            Print(vet);
            Print(medias);

            for (int i = 0; i < medias.Length; i++)
            {
                for (int j = 0; j < medias.Length - 1; j++)
                {
                    if (medias[j] < medias[j + 1])
                    {
                        (medias[j], medias[j + 1]) = (medias[j + 1], medias[j]);
                        
                    }
                }
            }
            
        }

        static void Main(string[] args)
        {
            int[] vet = [2, 6, 3, 7, 66, 1];
            string[] alunos = ["Thiago, 7, 8, 9", "Ana, 8, 7, 9", "João, 9, 8, 10"];
            // BubbleSort();
            // BubbleSortUp();
            // SelectionName();
            // InsertionSort(vet);
            Compare();
            // Media(alunos);

        }
    }
}