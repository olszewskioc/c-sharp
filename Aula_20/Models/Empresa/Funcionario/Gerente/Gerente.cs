using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_20.Models.Empresa.Enderecos;
using Aula_20.Models.Empresa.Funcionario;

namespace Aula_20.Models.Empresa.Funcionario.Gerente
{
    public class Gerente(string nome, DateTime nascimento, string cpf, Endereco enderecos) : Funcionario(nome, nascimento, cpf, enderecos)
    {
        public void GetSalario() => Console.WriteLine($"Gerente {Nome}\nCPF: {Cpf}\nNascimento: {Nascimento}\nSalário de R$ 5.000,00\n");
        public override string ToString()
        {
             return $"\nNome: {Nome}\nNascimento: {Nascimento}\nCPF: {Cpf}\nEndereço: {Endereco?.Rua}, {Endereco?.Numero}, {Endereco?.Bairro}\nSalário: R$5.000,00\n";
        }
    }
}