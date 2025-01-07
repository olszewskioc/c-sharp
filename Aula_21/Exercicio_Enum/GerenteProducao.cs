using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_21.Exercicio_Enum.Interfaces;

namespace Aula_21.Exercicio_Enum
{
    public class GerenteProducao : Empregado, IGerente
    {
        public bool AutorizaLicenca(Empregado empregado)
        {
            if (empregado == null) return false;

            empregado.LicencasPremioRecebidas += 1;
            return true;
        }

        public void Autorizar()
        {
            throw new NotImplementedException();
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