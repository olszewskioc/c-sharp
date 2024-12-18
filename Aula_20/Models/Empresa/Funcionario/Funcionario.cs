using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_20.Models.Empresa.Enderecos;

namespace Aula_20.Models.Empresa.Funcionario
{
    public class Funcionario(string nome, DateTime nascimento, string cpf, Endereco enderecos)
    {
        private string _nome = nome;
        private DateTime _nascimento = nascimento;
        private string _cpf = cpf;
        private Endereco _enderecos = enderecos;

        public string? Nome
        {
            get => _nome;
            set => _nome = value != null && value.Length > 1 ? value : _nome;
        }
        public DateTime Nascimento
        {
            get => _nascimento;
            set => _nascimento = value;
        }
        public string? Cpf
        {
            get => _cpf;
            set => _cpf = value != null && value.Length > 1 ? value : _cpf;
        }
        public Endereco? Endereco
        {
            get => _enderecos;
            set => _enderecos = value ?? _enderecos;
        }

        public override string ToString()
        {
            return $"\nNome: {Nome}\nNascimento: {Nascimento:d}\nCPF: {Cpf}\nEndereço: {Endereco?.Rua}, {Endereco?.Numero}, {Endereco?.Bairro}\n";
        }
    }
}