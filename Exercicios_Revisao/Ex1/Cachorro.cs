using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Revisao.Ex1
{
    public class Cachorro(string nome, string filo, string classe, string ordem, string familia, string genero, string especie) 
    : Animalia(filo, classe, ordem, familia, genero, especie)
    {
        public string Nome { get; set; } = nome;
        public override string ObterDescricao()
        {
            return $"Cachorro {Nome}\nReino Animalia\nFilo {Filo}\nClasse {Classe}\nOrdem {Ordem}\nFamilia {Familia}\nGenero {Genero}\nEspecie {Especie}";
        }
    }
}