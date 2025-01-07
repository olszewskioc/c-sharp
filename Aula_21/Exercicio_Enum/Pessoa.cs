using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21.Exercicio_Enum
{
    public abstract class Pessoa(string? name = null)
    {
        protected string? name = name;

        public string? Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}