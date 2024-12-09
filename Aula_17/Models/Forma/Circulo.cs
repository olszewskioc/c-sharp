using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17.Models.Forma
{
    public class Circulo(string? Nome=null, double Raio=0) : Forma(Nome)
    {
        public double Raio = Raio;

        public override double CalcularArea()
        {
            return 2 * Math.PI * Math.Pow(Raio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        public override void Print()
        {
            Console.WriteLine($"\nRaio: {Raio}");
            base.Print();
        }
    }
}