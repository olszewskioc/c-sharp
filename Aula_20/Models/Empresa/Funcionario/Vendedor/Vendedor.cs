using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_20.Models.Empresa.Enderecos;
using Aula_20.Models.Empresa.Funcionario;

namespace Aula_20.Models.Empresa.Funcionario.Vendedor
{
    public class Vendedor : Funcionario
    {
        private EquipeVenda? _equipe;
        public EquipeVenda? Equipe
        {
            get => _equipe;
            set => _equipe = value ?? _equipe;
        }

        public Vendedor(string nome, DateTime nascimento, string cpf, Endereco enderecos) : base(nome, nascimento, cpf, enderecos)
        {
            Console.Write($"Informe o nome da equipe do vendedor: ");
            string op = Console.ReadLine() ?? "";
            Equipe = new EquipeVenda(op);
            Console.Clear();
        }

        public float GetSalario() => 3000f;

        public override string ToString()
        {
             return $"\nNome: {Nome}\nNascimento: {Nascimento}\nCPF: {Cpf}\nEndereço: {Endereco?.Rua}, {Endereco?.Numero}, {Endereco?.Bairro}\nEquipe: {Equipe?.Nome}\nSalário: R${GetSalario():F2}\n";
        }
    }
}