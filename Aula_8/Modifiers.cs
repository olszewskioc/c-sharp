using System;
namespace Aula_8
{
    public class Modifiers
    {
        public int Subtrai(int a, int b)
        {
            return a - b;
        }
        static int Soma(int a, int b)
        {
            return a + b;
        }
        static void Teste(string[] args)
        {
            Modifiers m  = new Modifiers();
            Console.WriteLine(m.Subtrai(10, 5));
            Console.WriteLine(Soma(10, 5));
        }
    }
}