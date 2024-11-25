using System;
namespace Aula_13
{
    public class Lista
    {
        static int[] vetor = new int[10];

        static void Insert(int valor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == 0)
                {
                    vetor[i] = valor;
                    break;
                }    
            }
        }

        static void Print()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if(vetor[i] != 0)
                    Console.Write($"{vetor[i]} ");
            }
            Console.WriteLine();
        }

        static void ReversePrint()
        {
            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                if(vetor[i] != 0)
                    Console.Write($"{vetor[i]} ");
            }
            Console.WriteLine();
        }

        static void Remove(int valor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == valor)
                {
                    vetor[i] = 0;
                    break;
                }
            }
        }

        static void Tes(string[] args)
        {
            Insert(10);
            Insert(20);
            Insert(30);
            Print();
            ReversePrint();
            Remove(10);
            Print();

        }
    }
}