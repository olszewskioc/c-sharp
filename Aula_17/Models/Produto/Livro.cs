using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Aula_17.Models.Produto
{
    public class Livro(int Codigo=0, double Preco=0, string? Autor=null, string? Isbn=null) : Produto(Codigo, Preco)
    {
        public string? Autor = Autor;
        public string? Isbn = Isbn;

        public string? getAutor() => Autor;
        public void setAutor(string autor)
        {
            Autor = autor;
        }
        public void setIsbn(string isbn)
        {
            Isbn = isbn;
        }
        public string? getIsbn() => Isbn;
        public override void AtualizaPreco(double preco)
        {
            Preco += preco;
        }

        public override void setPreco(int preco)
        {
            Preco = preco;
        }

        public override double getPreco() => Preco;

        public override void setCodigo(int codigo)
        {
            Codigo = codigo;
        }

        public override int getCodigo() => Codigo;

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Isbn: {Isbn}");
        }
    }
}