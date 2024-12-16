using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19.Models.Animal
{
    public class Cachorro(string nome="Rex") : Animal(4), IAnimalDeEstimacao
    {
        private string _nome = nome;
        public void Brinca()
        {
            Console.WriteLine($"O cachorro {GetNome()} está brincando no quintal.");
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public override void Come()
        {
            Console.WriteLine($"O cachorro {GetNome()} está comendo uma costela.");
        }
    }
}