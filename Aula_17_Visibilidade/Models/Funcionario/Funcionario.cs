using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_Visibilidade.Models.Funcionario
{
    public class Funcionario(string? Nome=null, double Salario=0, string? Cargo=null)
    {
        public string? Nome = Nome;    // Acessível em qualquer lugar
        private double Salario = Salario;    // Acessível apenas na classe
        protected string? Cargo = Cargo;    // Acessível dentro da classe e subclasses

        public void Print()
        {
            Console.WriteLine($"\n+Nome: {Nome}");
            Console.WriteLine($"-Salário: {Salario}");
            Console.WriteLine($"#Cargo: {Cargo}");
        }

        protected void AtualizarCargo(string cargo)
        {
            Cargo = cargo;
            Console.WriteLine($"Cargo atualizado para : {cargo}");
        }

        private double CalcularImposto() => Salario * 0.1;
    }
}