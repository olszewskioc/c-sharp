using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_3.Models
{
    public abstract class Cliente
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }

    // Para ocorrer composição, o Endereço precisa ser instanciado no Construtor
    public Cliente()
    {
        Endereco = new Endereco();
    }
    public Cliente(string nome, string telefone, string cpf, string rua, string cidade, string estado, int cep)
    {
        Nome = nome;
        Telefone = telefone;
        CPF = cpf;
        Endereco = new Endereco(rua, cidade, estado, cep);
    }
        public abstract string ConsultarFidelidade();
    }

    public class ClienteGold : Cliente
    {
        public double Desconto { get; set; } = 0.10;
        public override string ConsultarFidelidade()
        {
            return "Cliente Gold";
        }
    }
    public class ClientePlatinum : Cliente
    {
        public double Desconto { get; set; } = 0.15;
        public override string ConsultarFidelidade()
        {
            return "Cliente Platinum";
        }
    }
}