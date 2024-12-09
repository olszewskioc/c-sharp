using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_Visibilidade.Models.Funcionario
{
    public class Gerente(string? Nome=null, double Salario=0, string? Setor=null) : Funcionario(Nome, Salario, "Gerente")
    {
        public string? Setor = Setor;

        public void Imprimir()
        {
            Print();
        }

        public void AtualizarCargoGerente(string cargo)
        {
            AtualizarCargo(cargo);
        }

        // public void CalcularImpostoGerente() => CalcularImposto();
    }
}