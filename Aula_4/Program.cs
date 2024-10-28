using System;
namespace Aula_4
{
    internal class MyClass
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"For {i}");
            }

            int j = 0;
            while (j <= 10)
            {
                Console.WriteLine($"While {j}");
                j++;
            }

            int x = 0;
            do
            {
                Console.WriteLine($"Do {x}");
                x++;
            } while (x <= 10);
        }
    }
}