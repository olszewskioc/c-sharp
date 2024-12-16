using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19.Models.Animal
{
    public abstract class Animal
    {
        protected int pernas;

        public int Pernas { get { return pernas; } private set { pernas = value;} }

        public Animal(int pernas=0)
        {
            Pernas = pernas;
        }

        public void Caminha()
        {
            Console.WriteLine($"O animal está caminhando com {Pernas} pernas");
        }

        public abstract void Come();
    }
}