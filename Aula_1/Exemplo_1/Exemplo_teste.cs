using System;
namespace Exemplo_1
{
    internal class Exemplo_teste
    {
        static void Teste2(String[] args)
        {
            bool completo = false;
            char genero = 'M';
            char letra = '\u0049';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = int.MaxValue;
            long n4 = 2147483647L;
            float n5 = 4.5f;
            String nome = "Thiago Olszewski";
            Object obj1 = "Alex Brown";
            Object obj2 = 4.5f;
            
            Console.WriteLine($"Completo: {completo}\nGênero: {genero}\nletra: {letra}\nN1: {n1}\nN2: {n2}\nN3: {n3}\nN4: {n4}\nN5: {n5}");
            Console.WriteLine($"Nome: {nome}\nObj1: {obj1}\nObj2: {obj2}");

        }
    }
}