using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21.Exercicio_Enum
{
    public class Vendedor : Empregado
    {
        protected double comissao;

        public double Comissao
        {
            get => comissao;
            set => comissao = value > 0 ? value : 0;
        }

        public override double Salario
        {
            get => salario + comissao;
            set => salario = value > salarioMinimo ? value : salarioMinimo;
        }

    }
}