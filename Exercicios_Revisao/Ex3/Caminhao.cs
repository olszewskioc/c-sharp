using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Revisao.Ex3
{
    public class Caminhao(string nome, string marca, char categoria, bool flex, bool disponivel, int eixos)
    : Veiculo(nome, marca, categoria, flex, disponivel), IDiaria
    {
        public int Eixos { get; set; }
        public override double Diaria()
        {
            return 200 + (Eixos * 50);
        }
    }
}