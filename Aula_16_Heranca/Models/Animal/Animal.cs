using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_Heranca.Models.Animal
{
    public record Animal(Boolean? Vivo=null)
    {
        public Boolean? Vivo = Vivo;
    }
}