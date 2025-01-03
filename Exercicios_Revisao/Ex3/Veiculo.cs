using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Revisao.Ex3
{
    public abstract class Veiculo(string nome, string marca, char categoria, bool flex, bool disponivel)
    {
        public string Nome { get; set; } = nome;
        public string Marca { get; set;} = marca;
        public char Categoria { get; set;} = categoria;
        public bool Flex { get; set;} = flex;
        public bool Disponivel { get; set;} = disponivel;

        public virtual double Diaria()
        {
            return Flex ? 100 : 80;
        }
    }
}