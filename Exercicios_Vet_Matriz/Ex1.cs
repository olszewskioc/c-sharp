// Dada uma matriz 4x4 preenchida com valores, some os elementos de cada linha e
// exiba o resultado.

using System;
namespace Exercicios_Vet_Matriz
{
    public class Ex1
    {
        static void Teste(string[] args)
        {
            Console.Clear();
            
            double[] vet = new double[10];
            double sum = 0, mean = 0;
            
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($"\nInforme o {i + 1}º número: ");
                vet[i] = Convert.ToDouble(Console.ReadLine());
                sum += vet[i];
            }
            mean = sum / vet.Length;
            Console.WriteLine($"\nA média dos números é: {mean:F2}");

            Console.WriteLine($"Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}
