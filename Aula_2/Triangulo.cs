using System;
namespace Aula_2
{
    internal class Triangulo

    {
        static void Triangulo_Area(String[] args)
        {
            Console.Write("\nInforme a base: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nInforme a altura: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double area = (b * h) / 2;
            
            Console.WriteLine($"\nBase: {b}\nAltura: {h}\nÁrea = (b*h)/2 = {area}");
        }
    }
}