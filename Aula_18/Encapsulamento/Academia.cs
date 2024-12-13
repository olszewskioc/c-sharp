using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18.Encapsulamento
{
    public record Academia(string? Nome=null, double Mensalidade=0)
    {
        public string? Nome { get; private set; } = Nome;
        private double Mensalidade { get; set; } = Mensalidade;

        public void setMensalidade(double valor)
        {
            Mensalidade = valor;
        }
    }
}