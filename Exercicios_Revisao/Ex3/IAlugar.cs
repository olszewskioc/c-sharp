using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Revisao.Ex3
{
    public interface IAlugar
    {
        public bool Alugar(Veiculo veiculo);
        public bool Devolver(Veiculo veiculo);

    }
}