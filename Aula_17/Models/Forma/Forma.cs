using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17.Models.Forma
{
    public abstract class Forma(string? Nome=null)
    {
        public string? Nome = Nome;

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
        public virtual void Print()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Área: {CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {CalcularPerimetro():F2}");
        }
    }
}