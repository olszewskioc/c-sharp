using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17.Models.Produto
{
    public abstract class Produto(int Codigo=0, double Preco=0)
    {
        public int Codigo = Codigo; // public int Codigo {get; set; } = Codigo;  get e set automático sem verificações adicionais
        public double Preco = Preco;

        // public Produto(int Codigo=0, double Preco=0)
        // {
        //     this.Codigo = Codigo;
        //     this.Preco = Preco
        // }
        public abstract void setCodigo(int codigo);
        public abstract int getCodigo();
        public abstract void setPreco(int preco);
        public abstract double getPreco();
        public abstract void AtualizaPreco(double preco);

        public virtual void Print()
        {
            Console.WriteLine($"\nCódigo: {getCodigo()}");
            Console.WriteLine($"Preço: {getPreco()}");
        }

    }
}