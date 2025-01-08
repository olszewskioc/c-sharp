using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_22.Models
{
    public sealed class Gerente : Funcionario
    {
        public override void Salario(double salario) => base.Salario(salario * 1.5);
        public override void Trabalhar() => Console.WriteLine("Gerenciando...");

    }
}