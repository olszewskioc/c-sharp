using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_Biblioteca.Models.User;

namespace Exercicio_Biblioteca.Models.Library
{
    public class Biblioteca(string nome, List<Leitor> leitores, List<Funcionario>? funcionarios=null)
    {
        private string _nome = nome;
        private List<Funcionario>? _funcionarios = funcionarios;
        private List<Leitor> _leitores = leitores;
        private Catalogo _catalogo = new Catalogo();

        public string Nome
        {
            get { return _nome; }
            set { _nome = value != null && value.Length > 1 ? value : _nome; }
        }
        public List<Funcionario>? Funcionarios
        {
            get { return _funcionarios; }
            set { _funcionarios = value ?? _funcionarios ; }
        }
        public List<Leitor> Leitores
        {
            get { return _leitores; }
            set { _leitores = value ?? _leitores ; }
        }
        public Catalogo Catalogo
        {
            get { return _catalogo; }
            set { _catalogo = value ?? _catalogo ; }
        }

        public void AddFuncionario(Funcionario funcionario) => Funcionarios?.Add(funcionario);
        public void RemoveFuncionario(Funcionario funcionario) => Funcionarios?.Remove(funcionario);
        public void AddLivro(Livro livro) => Catalogo.Livros.Add(livro);
        public void RemoveLivro(Livro livro) => Catalogo.Livros.Remove(livro);
        public void Emprestimo(Livro livro, Leitor leitor)
        {
            if (Catalogo.Livros.Contains(livro))
            {
                //  Catalogo.Livros.Exempalres-- where Catalogo.Livros == livro
                var livroEncontrado = Catalogo.Livros.FirstOrDefault(l => l.Titulo == livro.Titulo && l.Autor == livro.Autor);

                if (livroEncontrado != null)
                {
                    livroEncontrado.Exemplares--;
                    Console.WriteLine($"Emprestimo realizado!\nLeitor: {leitor.Nome}\nCPF: {leitor.Cpf}\nLivro: {livro}");
                }
                else if (livroEncontrado != null && livroEncontrado.Exemplares == 0)
                {
                    Console.WriteLine($"O livro '{livro.Titulo}' não está disponível no momento.");
                }
            }
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}