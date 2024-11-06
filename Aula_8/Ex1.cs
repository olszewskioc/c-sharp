// 1. Calcular a Média de um Vetor (Função Anônima usando Delegate)
// Enunciado: Escreva um programa que solicite ao usuário para inserir 10 números em um
// vetor e, em seguida, calcule a média desses valores. Utilize uma função anônima com
// delegate para realizar o cálculo da média.
// Requisitos:
// • Solicitar 10 números ao usuário e armazená-los em um vetor.
// • Criar uma função anônima usando delegate que calcule a média dos valores.
// • Exibir o resultado no console.

using System;
namespace Aula_8
{
    internal class Ex1
    {
        public delegate double Op(double[] vet);
        static double Mean(double[] vet) => vet.Average();
        static void Mains(string[] args)
        {
            Console.Clear();
            
            double[] vet = new double[10];
            Op operation = Mean;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"\nDigite o {i + 1}º valor: ");
                vet[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine($"Vetor - {string.Join(" ",vet)}");
            Console.WriteLine($"\n\nMédia =  {operation(vet)}");
            Console.WriteLine($"\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}