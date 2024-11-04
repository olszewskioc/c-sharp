// Dado um vetor de inteiros, verifique se ele é um palíndromo (ou seja, se é igual
// quando lido de trás para frente).

using System;
namespace Exercicios_Vet_Matriz
{
    public class Ex3
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            int[] vet = new int[10] { 1, 1, 2, 3, 4 , 4, 3, 2, 1, 0};
            int index = vet.Length - 1;
            bool palindrome = true;

            
            for (int i = 0; i < vet.Length; i++)
            {
                palindrome = vet[i] == vet[index] ? true : false;
                Console.WriteLine($"{palindrome}");
                if  (!palindrome)
                {
                    break;
                }
                --index;
            }
            Console.WriteLine($"\nVetor{(palindrome ? " " : " não ")}é um palíndromo!");
            Console.WriteLine($"\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}