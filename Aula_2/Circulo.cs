using System;
namespace Aula_2
{
    internal class Circulo

    {
        static void Circulo_Area(String[] args)
        {
            Console.Write("\nInforme o raio: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double pi = Math.PI;
            double area = pi * Math.Pow(r, 2);
            
            Console.WriteLine($"\nRaio: {r}\nÁrea = pi * r² = {area}");
        }
    }
}