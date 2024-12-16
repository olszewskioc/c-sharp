using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19.Models.Animal
{
    public class Peixe : Animal, IAnimalDeEstimacao
    {
        private string _nome = "Peixoto";
        public void Brinca()
        {
            Console.WriteLine($"O peixe {GetNome()} está brincando no aquário.");
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
            Console.WriteLine($"O peixe {GetNome()} está comendo algas.");
        }
    }
}