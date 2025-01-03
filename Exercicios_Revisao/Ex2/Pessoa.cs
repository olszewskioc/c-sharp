using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Revisao.Ex2
{
    public class Pessoa(string nome, string cpf)
    {
        protected string _nome = nome;
        protected string _cpf = cpf;

        public string Nome
        {
            get => this._nome;
            set => this._nome = value != null ? value : string.Empty;
        }
        public string Cpf
        {
            get => this._cpf;
            set => this._cpf = value != null ? value : string.Empty;
        }
    }
}