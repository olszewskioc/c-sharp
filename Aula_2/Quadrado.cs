using System;
namespace Aula_2
{
    internal class Quadrado
    {
        static void Quadrado_Area(String[] args)
        {
            Console.Write("\nInforme o lado: ");
            double l = Convert.ToDouble(Console.ReadLine());
            double area = Math.Pow(l, 2);
            
            Console.WriteLine($"\nLado: {l}\nÁrea = L² = {area}");
        }
    }
}