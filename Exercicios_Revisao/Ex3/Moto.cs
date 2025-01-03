using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Revisao.Ex3
{
    public class Moto(string nome, string marca, char categoria, bool flex, bool disponivel, int cilindradas=125)
    : Veiculo(nome, marca, categoria, flex, disponivel)
    {
        public int Cilindradas { get; set; } = cilindradas;
        public override double Diaria()
        {
            return Flex ? 0.5 * Cilindradas : 0.35 * Cilindradas;
        }
    }
}