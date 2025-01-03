using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_3.Models
{
    public abstract class Funcionario : IRelatorio
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public double SalarioBase { get; set; }

        // Composição na classe Executar
        public abstract double CalcularSalario();
        public abstract void GerarRelatorio();
    }

    public class Gerente : Funcionario
    {
        public double Bonus { get; set; } = 0.2;
        public override double CalcularSalario()
        {
            return SalarioBase * (1 + Bonus);
        }

        public void CalcularGratificação()
        {
            Console.WriteLine($"Gratificação do gerente: {SalarioBase * Bonus}");
        }

        public override void GerarRelatorio()
        {
            Console.WriteLine($"Gerente: {Nome} | Salário: R${CalcularSalario()}");
            
        }
    }

    public class Vendedor : Funcionario
    {
        public double VendasRealizadas { get; set; }

        public double CalcularBonus()
        {
            return VendasRealizadas * 0.1;
        }
        public override double CalcularSalario()
        {
            return SalarioBase + CalcularBonus();
        }

        public override void GerarRelatorio()
        {
            Console.WriteLine($"Vendedor: {Nome} | Salário: R${CalcularSalario()}");
        }
    }

    public class Padeiro : Funcionario
    {
        public double HorasNoturnas { get; set; }
        public override double CalcularSalario()
        {
            return HorasNoturnas + (SalarioBase * (0.25 / 160));
        }

        public override void GerarRelatorio()
        {
            Console.WriteLine($"Padeiro: {Nome} | Salário: R${CalcularSalario()}");
            
        }
    }
}