using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Aula_17.Models.Forma
{
    public class Retangulo(string? Nome=null, double Altura=0, double Largura=0) : Forma(Nome)
    {
        public double Altura = Altura;
        public double Largura = Largura;

        public override double CalcularArea()
        {
            return Altura * Largura;
        }

        public override double CalcularPerimetro() => (Altura * 2) + (Largura * 2); // Arrow function para return

        public override void Print()
        {
            Console.WriteLine($"\nAltura: {Altura}");
            Console.WriteLine($"Largura: {Largura}");
            base.Print();
        }
    }
}