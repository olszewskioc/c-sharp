using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17.Models.Empregado
{
    public class Comissionado(string? Nome=null, string? Sobrenome=null, string? Cpf=null, double totalVenda=0, double taxaComissao=0) : Empregado(Nome, Sobrenome, Cpf)
    {
        public double totalVenda = totalVenda;
        public double taxaComissao = taxaComissao;

        public override double Vencimento() => totalVenda + (totalVenda * (taxaComissao / 100));

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Total Venda: R${totalVenda:F2}");
            Console.WriteLine($"Taxa Comissão: {taxaComissao:F2}%");
        }
    }
}