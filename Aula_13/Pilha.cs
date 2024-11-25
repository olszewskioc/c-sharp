using System;
namespace Aula_13
{
    public class Pilha
    {
        static int[] PILHA = new int[10];
        static int TOP = 0;

        static void Push(int valor)
        {
            if (TOP < PILHA.Length)
            {
                PILHA[TOP] = valor;
                TOP++;
            } else
            {
                Console.WriteLine($"Pilha Cheia!\n");
            }
        }

        static void Pop()
        {
            if (TOP > 0)
            {
                TOP--;
                PILHA[TOP] = 0;
            } else
            {
                Console.WriteLine($"Pilha Vazia!\n");
            }
        }

        static void Top()
        {
            Console.WriteLine($"{PILHA[TOP - 1]}\n");
        }

        static void Print()
        {
            for (int i = TOP - 1; i >= 0; i--)
            {
                Console.WriteLine($"{PILHA[i]}");
            }
            Console.WriteLine();
        }

        static void Fe(string[] args)
        {
            Push(10);
            Push(20);
            Push(30);
            Top();
            Print();
            Pop();
            Print();
        }
    }    
}