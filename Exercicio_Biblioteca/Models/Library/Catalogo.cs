using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Biblioteca.Models.Library
{
    public class Catalogo()
    {
        private List<Livro> _livros = [];

        public List<Livro> Livros
        {
            get { return _livros; }
            set { _livros = value ?? _livros ; }
        }
        public void AddLivros(Livro livro) => Livros.Add(livro);
        public void RemoveLivros(Livro livro) => Livros.Remove(livro);
    }
}