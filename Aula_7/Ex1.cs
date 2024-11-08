using System;
namespace Aula_7
{
    public class Ex1
    {
        static void Teste(string[] args)
        {
            //  1. Ler um vetor com 10 inteiros e mostrar os números na ordem direta e
            //  inversa a que foram lidos.
            int[] vet = new int[10];
            int[] vetInverso = new int[10];
            Random r  = new Random();
            int index = vetInverso.Length;


            for (int i = 0;  i < vet.Length; i++)
            {
                vet[i] = r.Next(100);
                vetInverso[index - 1] = vet[i];
                --index;
            }

            Console.WriteLine(string.Join(" ",vet));
            Console.WriteLine(string.Join(" ",vetInverso));
        }
    }
}
