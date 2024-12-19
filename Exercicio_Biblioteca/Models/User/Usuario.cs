using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Biblioteca.Models.User
{
    public abstract class Usuario
    {
        private string _nome;
        private string _cpf;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value != null && value.Length > 1 ? value : _nome; }
        }
        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public Usuario(string nome, string cpf)
        {
            _nome = nome;
            _cpf = cpf;
        }
    }
}