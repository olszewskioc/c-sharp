using System;

namespace Aula_2
{
    internal class Program
    {
        static void Teste(String[] args)
        {

            double a = 20;
            double b = 10;
            bool s1 = true;
            bool s2 = false;
            
            Console.WriteLine("\nAtribuições Aritméticas\n");
            b += a;
            Console.WriteLine($"b += a -> {b}"); // b = b + a
            b -= a;
            Console.WriteLine($"b -= a -> {b}"); // b = b -a
            b *= a;
            Console.WriteLine($"b *= a -> {b}"); // b = b * a
            b /= a;
            Console.WriteLine($"b /= a -> {b}"); // b = b / a
            b %= a;
            Console.WriteLine($"b %= a -> {b}"); // b = b % a

            Console.WriteLine("\nOperadores Aritméticos\n");
            Console.WriteLine($"a + b = {a+b}");
            Console.WriteLine($"a - b = {a-b}");
            Console.WriteLine($"a * b = {a*b}");
            Console.WriteLine($"a / b = {(int)(a/b)}");
            Console.WriteLine($"a % b = {a%b}");

            Console.WriteLine("\nOperadores Comparativos\n");
            Console.WriteLine($"a == b ?  {a == b}");
            Console.WriteLine($"a != b ?  {a != b}");
            Console.WriteLine($"a > b ?  {a > b}");
            Console.WriteLine($"a >= b ?  {a < b}");
            Console.WriteLine($"a < b ?  {a < b}");
            Console.WriteLine($"a <= b ?  {a < b}");

            Console.WriteLine("\nOperadores Lógicos\n");
            Console.WriteLine($"s1 && s2 ?  {s1 && s2}");
            Console.WriteLine($"s1 || s2 ?  {s1 && s2}");
            Console.WriteLine($"!s1 ?  {!s1}");
            
            int i = 10;

            Console.WriteLine($"\nOperador Aritmético Incremental/Decremental\n");
            Console.WriteLine($"i++ = {i++}"); // Increment after the WriteLine
            Console.WriteLine($"i = {i}");
            Console.WriteLine($"++i = {++i}"); // Increment before the WriteLine
            Console.WriteLine($"i-- = {i--}"); // Decrement after the WriteLine
            Console.WriteLine($"i = {i}");
            Console.WriteLine($"--i = {--i}"); // Decrement before the WriteLine

            uint num1 = 0b_1010; // 10
            uint num2 = 0b_1001; // 9
            Console.WriteLine($"{num1}\t{num2}");
            
            Console.WriteLine($"\nOperadores Bitwise\n");
            Console.WriteLine($"{Convert.ToString(num1, 2)} & {Convert.ToString(num2, 2)} = {num1 & num2}"); // AND
            Console.WriteLine($"{Convert.ToString(num1, 2)} | {Convert.ToString(num2, 2)} = {num1 | num2}"); // OR
            Console.WriteLine($"{Convert.ToString(num1, 2)} ^ {Convert.ToString(num2, 2)} = {num1 ^ num2}"); // XOR
            
        }

    }
}
