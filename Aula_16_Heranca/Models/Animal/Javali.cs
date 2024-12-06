using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_Heranca.Models.Animal
{
    public record Javali(Boolean? Vivo=null, Boolean? Selvagem=null) : Animal(Vivo)
    {
        public Boolean? Selvagem = Selvagem;

        public int GetVelocidadeMaxima()
        {
            return 60;
        }

        public void SetSelvagem(Boolean? s)
        {
            this.Selvagem = s;
        }
    }
}