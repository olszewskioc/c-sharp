using System;
namespace Aula_11
{
    public class Exercicios
    {
        static int Soma(int n)
        // 1. Faça um programa que calcule a soma dos números de 1 a n, onde n é um número
        // inteiro fornecido pelo usuário
        {
            return n > 1 ? n + Soma(n - 1) : 1;
        }

        static int Produto(int n)
        // 2. Faça um programa que calcule o produto dos números de 1 a n, onde n é um número
        // inteiro fornecido pelo usuário.
        {
            return n > 1 ? n * Produto(n - 1) : 1;
        }

        static int Potencia(int x, int n)
        // 3. Faça um programa que calcule a potência de um número inteiro x elevado a um número
        // inteiro não-negativo n, fornecidos pelo usuário.
        {
            return n > 1 ? x * Potencia(x, n - 1) : x;
        }

        static int MDC(int x, int n)
        // 4. Faça um programa que calcule o MDC (Máximo Divisor Comum) de dois números
        // inteiros fornecidos pelo usuário.
        {
            return n != 0 ? MDC(n, x % n) : x;
        }

        static int Soma(int[] vet, int n)
        // 5. Faça um programa que calcule a soma dos elementos de um vetor de inteiros.
        {
            return n > 0 ? vet[n - 1] + Soma(vet, n - 1) : 0;
        }

        static double Media(int[] vet, int tam)
        // 6. Faça um programa que calcule a média dos elementos de um vetor de inteiros.
        {   
            return tam == vet.Length ? Convert.ToDouble((vet[tam - 1] + Media(vet, tam - 1)) / tam)
                : tam != 0 ? vet[tam - 1] + Media(vet, tam - 1) 
                : 0;
        }

        // Operador ternario

        // condição ? Executa se verdade : Executa se falso
        // If ? Executa se verdade : ElseIF ? Executa se condição2 verdade : Else

        
        static void T(string[] args)
        {
            Console.Clear();
            
            int n = 8;
            int x = 12;
            int[] vet = [10, 36, 50, 550];

            Console.WriteLine($"\nSoma({n}) = {Soma(n)}");
            Console.WriteLine($"Produto({n}) = {Produto(n)}");
            Console.WriteLine($"Potencia({x}, {n}) = {Potencia(x, n)}");
            Console.WriteLine($"MDC({x}, {n}) = {MDC(x, n)}");
            Console.WriteLine($"Soma([{string.Join(", ", vet)}], {vet.Length}) = {Soma(vet, vet.Length)}"); // Utilizei o conceito de overload de função
            Console.WriteLine($"Media([{string.Join(", ", vet)}], {vet.Length}) = {Media(vet, vet.Length)}");
            
        }
    }
}
