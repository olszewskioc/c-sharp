using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20.Models.Escola
{
    public class Aluno(string nome)
    {
        public string Nome { get; set; } = nome;

        public void Info() => Console.WriteLine($"Aluno: {Nome}");
        
    }
}