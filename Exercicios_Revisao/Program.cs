using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicios_Revisao.Ex1;
using Exercicios_Revisao.Ex2;
using Exercicios_Revisao.Ex3;

namespace Exercicios_Revisao
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Ex1
            Homem homem = new Homem("Thiago", "Chordata", "Mammalia", "Primata", "Hominidae", "Homo", "Homo sapiens");
            Cachorro cachorro = new Cachorro("Totó", "Chordata", "Mammalia", "Carnívora", "Canidae", "Canis", "Canis familiaris");
            Mosca mosca = new Mosca("Joe", "Arthropoda", "Insecta", "Díptera", "Muscidae", "Musca", "Musca domestica");
            Console.WriteLine($"{homem.ObterDescricao()}\n");
            Console.WriteLine($"{cachorro.ObterDescricao()}\n");
            Console.WriteLine($"{mosca.ObterDescricao()}\n\n");
            
            // Ex2
            Engenheiro engenheiro = new Engenheiro("Thiago Olszewski", "030.669.871-40", 10568);
            Pessoa pessoa1 = new Pessoa("Luciano Araújo", "772.501.561-53");
            Pessoa pessoa2 = new Pessoa("Roberto Araújo", "598.555.652-87");
            UnidadeResidencial unidade1 = new(50, 3, 2, "Ronaldo Tavares", "789.666.999-30");
            UnidadeResidencial unidade2 = new(50, 1, 1, "Jefferson Cavalcante", "456.966.562-69");
            UnidadeResidencial unidade3 = new(50, 2, 1, "Fabiana Tavares", "012.456.375-81");
            Predio predio = new("Solar das Palmeiras", 3, 1, 150, "Rua das Palmeiras, 568 - Centro | CG/MS", "Thiago Olszewski", "030.669.871-40", 45898);
            predio.CadastrarUnidade(unidade1);
            predio.CadastrarUnidade(unidade2);
            predio.CadastrarUnidade(unidade3);
            Console.WriteLine($"{predio.DescricaoImovel()}");
            
            // Ex3
            List<Veiculo> veiculos = new();
            veiculos.Add(new Caminhao("Scania 300", "Scania", 'D', false, true, 8));
            veiculos.Add(new Carro("Versa", "Nissan", 'B', true, true));
            veiculos.Add(new Moto("Biz", "Honda", 'A', true, true));
            veiculos.Add(new Utilitario("Kangoo", "Ford", 'B', true, false));

            Locadora locadora = new("Locadora");
            locadora.Veiculos = veiculos;
            locadora.ConsultaVeiculo();
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"{veiculo.Nome} - R${veiculo.Diaria()}");
            }
            locadora.Devolver(veiculos[3]);
            locadora.Alugar(veiculos[0]);
            locadora.ConsultaVeiculo();
        }
    }
}