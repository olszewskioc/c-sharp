using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_21.Exercicio_Enum.Enums;

namespace Aula_21.Exercicio_Enum
{
    public class Empregado : Pessoa
    {
        protected double salario;
        protected double salarioMinimo = 240d;
        protected int licencasPremioRecebidas;
        protected TipoEmpregado tipoEmpregado;

        public virtual double Salario
        {
            get => salario;
            set => salario = value > salarioMinimo ? value : salarioMinimo;
        }
        public int LicencasPremioRecebidas
        {
            get => licencasPremioRecebidas;
            set => licencasPremioRecebidas = value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Não é possível receber menos de 0 licenças de premio");
        }

        public TipoEmpregado TipoEmpregado
        {
            get => tipoEmpregado;
            set => tipoEmpregado = value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Valor inválido");
        }
    }
}