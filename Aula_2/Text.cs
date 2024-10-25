using System;
namespace Aula_2
{
    internal class Text
    {
        static void Text_Split(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            string w1 = words[0], w2 = words[1], w3 = words[2];
            Console.WriteLine($"{w1} {w2} {w3}");
        }
    }
}