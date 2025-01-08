using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_22.Models
{
    public class Coordenador : Funcionario
    {
        public override void Salario(double salario) => base.Salario(salario * 1.2);
        public sealed override void Trabalhar() => Console.WriteLine($"Coordenando...");
    }
}