using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Biblioteca.Models.Library
{
    public class Livro(string titulo, string autor, DateTime anoPublicacao, int exemplares)
    {
        private string _titulo = titulo;
        private string _autor = autor;
        private DateTime _anoPublicacao = anoPublicacao;
        private int _exemplares = exemplares;

        public string Titulo 
        {
            get { return _titulo; }
            set { _titulo = value != null && value.Length > 1 ? value : _titulo; }
        }
        public string Autor 
        {
            get { return _autor; }
            set { _autor = value != null && value.Length > 1 ? value : _autor; }
        }
        public DateTime AnoPublicacao 
        {
            get { return _anoPublicacao; }
            set { _anoPublicacao = value; }
        }
        public int Exemplares 
        {
            get { return _exemplares; }
            set { _exemplares = value >= 0  ? value : _exemplares; }
        }

        public override string ToString()
        {
            return $"{Titulo} | {Autor} | {AnoPublicacao:d} | {Exemplares} exemplares";
        }
    }
}