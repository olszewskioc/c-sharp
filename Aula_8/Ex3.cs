// 3. Verificar se um Vetor é um Palíndromo (Função Estática)
// Enunciado: Dado um vetor de inteiros, verifique se ele é um palíndromo (ou seja, se é
// igual quando lido de trás para frente). Implemente a verificação como uma função static.
// Requisitos:
// • Criar uma função static que receba um vetor de inteiros e verifique se ele é um
// palíndromo.
// • A função deve retornar true se for palíndromo e false caso contrário.
// • Exibir o resultado no console indicando se o vetor é um palíndromo.

using System;
namespace Exercicios_Vet_Matriz
{
    public class Ex3
    {
        static bool Palindrome(int[] vet)
        {
            int[] vet_aux = (int[])vet.Clone();
            Array.Reverse(vet_aux);
            string original = string.Join("",vet), aux = string.Join("",vet_aux);
            bool palindrome = original == aux ? true : false;
            // Console.WriteLine($"{string.Join("",vet)}\n{string.Join("",vet_aux)}\n");
            
            return palindrome;
        }

        static void Mains(string[] args)
        {
            Console.Clear();
            
            int[] vet = new int[10] { 0, 1, 2, 3, 4 , 4, 3, 2, 1, 0};
            bool palindrome = Palindrome(vet);

            Console.WriteLine($"\nVetor [ {string.Join(", ",vet)}]{(palindrome ? " " : " não ")}é um palíndromo!");
            Console.WriteLine($"\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}