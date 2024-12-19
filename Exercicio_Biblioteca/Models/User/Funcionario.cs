using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_Biblioteca.Models.Library;

namespace Exercicio_Biblioteca.Models.User
{
    public class Funcionario(string nome, string cpf, string cargo) : Usuario(nome, cpf)
    {
        private string _cargo = cargo;

        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value != null && value.Length > 1 ? value : _cargo; }
        }

        public void Emprestimo(Biblioteca biblioteca, Leitor leitor, Livro livro)
        {
            biblioteca.Emprestimo(livro, leitor);
        }

        public void GerirLivro(Biblioteca biblioteca, Livro livro, bool add)
        {
            if (add)
        {
            biblioteca.AddLivro(livro);
        }
        else
        {
            biblioteca.RemoveLivro(livro);
        }
        }

        public override string ToString()
        {
            return $"{Nome} | {Cpf} | {Cargo}";
        }
    }
}