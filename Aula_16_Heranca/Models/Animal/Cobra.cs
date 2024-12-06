using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_Heranca.Models.Animal
{
    public record Cobra(Boolean? Vivo=null, Boolean? Venenosa=null) : Animal(Vivo)
    {
        public Boolean? Venenosa = Venenosa;

        public void Alimento(string a)
        {
            Console.WriteLine($"O alimento da cobra é {a}");
        }

        public void SetVenenosa(Boolean? v)
        {
            this.Venenosa = v;
        }
    }
}