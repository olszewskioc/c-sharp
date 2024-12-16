using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19.Models.Animal
{
    public class Formiga() : Animal(6)
    {
        public override void Come()
        {
            Console.WriteLine($" A formiga está comendo uma folha.");
        }
    }
}