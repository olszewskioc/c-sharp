using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_22.Models
{
    public class Funcionario(string? name = null)
    {
        public string? Name { get; set; } = name;

        public virtual void Salario(double salario) => Console.WriteLine($"Salário base: {salario}");
        public virtual void Trabalhar() => Console.WriteLine("Trabalhando...");
    }
}