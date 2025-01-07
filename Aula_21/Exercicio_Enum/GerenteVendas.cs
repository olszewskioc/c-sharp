using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_21.Exercicio_Enum.Enums;
using Aula_21.Exercicio_Enum.Interfaces;

namespace Aula_21.Exercicio_Enum
{
    public class GerenteVendas : Vendedor, IGerente
    {
        protected Estado estado;
        protected string? regiao;

        public Estado Estado 
        {
            get => estado;
            set {
                estado = value;
                regiao = EstadoHelper.GetRegiao(value);
            }
        }

        public override double Salario
        {
            get => salario + comissao + (regiao == "Nordeste" ? 200 : regiao == "Sudeste" ? 1000 : regiao == "Norte" ? 500 : 0);
            set => salario = value > salarioMinimo ? value : salarioMinimo;
        }

        public bool AutorizaLicenca(Empregado empregado)
        {
            if (empregado == null) return false;

            empregado.LicencasPremioRecebidas += 1;
            return true;
        }

        public void Autorizar()
        {
            Console.WriteLine($"Autorizado por {Name}");
        }

        public bool ConcederAumento(Empregado empregado)
        {
            if (empregado == null) return false;

            Console.Write($"\nInforme o valor do aumento para {empregado.Name}: ");
            double aumento = Convert.ToDouble(Console.ReadLine());
            empregado.Salario += aumento;
            return true;
        }
    }
}