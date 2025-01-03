using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Revisao.Ex3
{
    public class Carro(string nome, string marca, char categoria, bool flex, bool disponivel)
    : Veiculo(nome, marca, categoria, flex, disponivel), IDiaria
    {
        
    }
}