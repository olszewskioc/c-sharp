using System;
using System.Numerics;
namespace Aula_15
{
    // public class Produto(string nome, double preco, double quantidade, DateTime dataRegistro)
    // {
    //     public string Nome = nome;
    //     public double Preco = preco;
    //     public double Quantidade = quantidade;
    //     public DateTime DataRegistro = dataRegistro;
    // }
    public class Produto
    {
        public string Nome;
        public double Preco;
        public double Quantidade;
        public DateTime DataRegistro;

        public Produto(string Nome, double Preco, double Quantidade, DateTime DataRegistro)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
            this.DataRegistro = DataRegistro;
        }

        public Produto()
        {
            this.Nome = "Sem nome";
            this.Preco = 0;
            this.Quantidade = 0;
            this.DataRegistro = DateTime.Now;
        }

        public void Exibir()
        {
            Console.WriteLine($"{this.Nome} - R${this.Preco:F2} - {this.Quantidade:F2} - {this.DataRegistro}");
        }
    }
}