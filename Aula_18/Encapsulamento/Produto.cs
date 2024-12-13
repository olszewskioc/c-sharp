using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Aula_18.Encapsulamento
{
    public record Produto
    {
        private string? _nome;
        public double Preco { get; set; }
        private int _quantidade;

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }
        public Produto(){}

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        public string? Nome
        {
            get => _nome;
            set => _nome = value != null && value.Length > 1 ? value : _nome;

        }

        // public string? GetNome() => _nome;
        // public void SetNome(string nome) => _nome = nome != null && nome.Length > 1 ? nome : "Sem nome";

        // public double GetPreco() => _preco;
        // public void SetPreco(double preco) => _preco = preco > 0 && preco < 1000 ? preco : _preco;

        public int GetQuantidade() => _quantidade;
        public void SetQuantidade(int quantidade) => _quantidade = quantidade > 0 && quantidade < 1000 ? quantidade : _quantidade;

        public void AddProdutos(int quantidade) => _quantidade += quantidade;
        public void RemoveProdutos(int quantidade) => _quantidade -= quantidade;
        public double ValorTotalEstoque() => _quantidade * Preco;
        public override string ToString() => $"Nome: {_nome}\t Preço: ${Preco.ToString("F2")}\t Quantidade: {_quantidade.ToString("F2")}\t Valor Total: ${ValorTotalEstoque():F2}";

    }
}