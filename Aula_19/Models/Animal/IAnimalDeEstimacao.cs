using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19.Models.Animal
{
    public interface IAnimalDeEstimacao
    {
        string GetNome();
        void SetNome(string nome);
        void Brinca();
    }
}