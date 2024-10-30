// Reescreva o programa que identifica o DDD dos estados, utilizando a estrutura Caso,
// de acordo com os seguintes critérios de DDDs e seus respectivos Estados brasileiros.
// • Paraná: 41, 42, 43, 44, 45 e 46
// • Rio Grande do Sul: 51, 53, 54 e 55
// • Brasília: 61
// • Goiás: 62 e 64
// • Mato Grosso: 65 e 66
// • Mato Grosso do Sul: 67

using System;
namespace Aula_5
{
    internal class Ex3
    {
        static void DDD(string[] args)
        {
            Console.Clear();
            Console.Write("\nBem vindo ao identificador de DDD\n\n");
            Console.Write("Informe seu DDD: ");
            int ddd  = Convert.ToInt32(Console.ReadLine());

            switch (ddd)
            {
                case int n  when (n >= 41 && n <= 46):
                    Console.WriteLine($"O DDD ({ddd}) pertence ao estado do Paraná.\n");
                    break;
                case int n  when ((n >= 53 && n <= 55) || n == 51):
                    Console.WriteLine($"O DDD ({ddd}) pertence ao estado do Rio Grande do Sul.\n");
                    break;
                case int n  when (n == 61):
                    Console.WriteLine($"O DDD ({ddd}) pertence ao estado de Brasília.\n");
                    break;
                case int n  when (n == 62 || n == 64):
                    Console.WriteLine($"O DDD ({ddd}) pertence ao estado de Goiás.\n");
                    break;
                case int n  when (n ==65 || n == 66):
                    Console.WriteLine($"O DDD ({ddd}) pertence ao estado do Mato Grosso.\n");
                    break;
                case int n  when (n == 67):
                    Console.WriteLine($"O DDD ({ddd}) pertence ao estado do Mato Grosso do Sul.\n");
                    break;
                default:
                    Console.WriteLine($"O DDD ({ddd}) não pertence a nenhum estado registrado.\n");
                    break;
            }
            
            
        }
    }
}