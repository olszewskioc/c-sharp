using System;
namespace Aula_9
{
    public class Program
    {
        static bool ParOuImpar(int num)
        {
            return num % 2 == 0;
        }
        static String ParOuImpar(double num)
        {
            return num % 2 == 0 ? "Par" : "Impar";
        }
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\nNúmero é {ParOuImpar(num)}");
            
        }
    }
}