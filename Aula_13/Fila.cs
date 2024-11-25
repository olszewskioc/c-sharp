using System;
namespace Aula_13
{
    public class Fila
    {
        static int[] FILA = new int[4];
        static int INIT = 0;
        static int END = 0;
        static int TAM = 0;

        static void Insert(int valor)
        {
            if (TAM < FILA.Length)
            {
                FILA[END] = valor;
                END = (END + 1) % FILA.Length;
                TAM++;
            } else
            {
                Console.WriteLine($"Fila Cheia!\n");
            }
                
        }

        static void Print()
        {
            for (int i = 0; i < TAM; i++)
            {
                Console.Write($"{FILA[(INIT + i) % FILA.Length]} ");
            }
            Console.WriteLine();
        }

        static void ReversePrint()
        {
            for (int i = TAM - 1; i >= 0; i--)
            {
                Console.Write($"{FILA[(INIT + i) % FILA.Length]} ");
            }
            Console.WriteLine();
        }

        static void Remove()
        {
            if (TAM > 0)
            {
                FILA[END] = 0;
                INIT = (INIT + 1) % FILA.Length;
                TAM--;
            } else
            {
                Console.WriteLine($"Fila Vazia!\n");
            }
        }

        static void First()
        {
            if (TAM > 0)
                Console.Write($"{FILA[INIT]}\n");
        }

        static void Fe(string[] args)
        {
            Insert(1);
            Insert(2);
            Insert(3);
            Insert(4);
            Console.WriteLine($"FILA");
            Print();
            // ReversePrint();
            Console.Write($"\nPrimeiro: ");
            First();
            Remove();
            // First();
            Console.WriteLine($"\nFILA");
            Print();

        }
    }
}