using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_17_Visibilidade.Models.Funcionario;

namespace Aula_17_Visibilidade
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Funcionario funcionario= new("João", 500, "Dev Jr.");
            Console.WriteLine($"Nome: {funcionario.Nome}");
            funcionario.Nome = "Fulano";
            Console.WriteLine($"Nome: {funcionario.Nome}");
            // Console.WriteLine($"Cargo: {funcionario.Cargo}");
            Gerente gerente= new("João", 500, "Dev Jr.");
            Console.WriteLine($"Nome: {gerente.Nome}");
            gerente.Nome = "Fulano";
            Console.WriteLine($"Nome: {gerente.Setor}");
            gerente.AtualizarCargoGerente("Gestor");
            // Console.WriteLine($"Cargo: {gerente.Cargo}");
            // Console.WriteLine($"Salario: {funcionario.Salario}");
            // funcionario.Salario = 499;
            
        }
    }
}