using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17.Models.Produto
{
    public class CompactDisc(int Codigo=0, double Preco=0, string? Artista=null, string? Gravadora=null) : Produto(Codigo, Preco)
    {
        public string? Artista = Artista;
        public string? Gravadora = Gravadora;

        public string? getArtista() => Artista;
        public void setArtista(string artista)
        {
            Artista = artista;
        }
        public void setGravadora(string gravadora)
        {
            Gravadora = gravadora;
        }
        public string? getGravadora() => Gravadora;

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

        public override void AtualizaPreco(double preco)
        {
            Preco += preco;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Gravadora: {Gravadora}"); 
        }
    }
}