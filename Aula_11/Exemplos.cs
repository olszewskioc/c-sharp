using System;
namespace Aula_11
{
    public class Exemplos
    {
        static (int, double) SomaMedVet(int[] vet, int index, int tam)
        {
            if (index < 0)
                return (0, 0.0);

            (int somaParcial, double _) = SomaMedVet(vet, index -1, tam);
            int somaTotal = somaParcial + vet[index];

            double media = (double)somaTotal / tam;

            return (somaTotal, media);
        }
        static void Tes(string[] args)
        {
            Console.Clear();
        
            int[] vet = [1, 2, 3, 4, 5];
            Console.WriteLine($"{SomaMedVet(vet, vet.Length - 1, vet.Length)}");
            
        }
    }
}
