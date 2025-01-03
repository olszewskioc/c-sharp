using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Revisao.Ex2
{
    public class Engenheiro(string nome, string cpf, int crea) :Pessoa(nome, cpf)
    {
        private int _crea = crea;

        public int Crea
        {
            get { return _crea; }
            set { _crea = value != 0 ? value : throw new ArgumentException("Crea não pode ser zero"); }
        }
    }
}