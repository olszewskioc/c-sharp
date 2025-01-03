using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Desafio_3.Models;

namespace Desafio_3
{
    public class Executar
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Produto> produtos = new List<Produto>();
            List<Venda> vendas = new List<Venda>();
            Estoque estoque = new Estoque();

            int op;

            do
            {
                Console.Clear();
                Console.WriteLine($"\nInforme uma opção:");
                Console.WriteLine($"1 - Cadastrar Cliente");
                Console.WriteLine($"2 - Cadastrar Produto");
                Console.WriteLine($"3 - Cadastrar Venda");
                Console.WriteLine($"4 - Consultar Estoque");
                Console.WriteLine($"5 - Gerar Relatório de Funcionários");
                Console.WriteLine($"0 - Sair");

                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        CadastrarCliente(clientes);
                        break;
                    case 2:
                        CadastrarProduto(produtos, estoque);
                        break;
                    case 3:
                        CadastrarVenda(clientes, produtos, vendas);
                        break;
                    case 4:
                        ConsultarEstoque(estoque);
                        break;
                    case 5:
                        GerarRelatorioVendas(vendas);
                        break;
                    case 0:
                        Console.WriteLine($"Saindo...");
                        break;
                    default:
                    Console.WriteLine($"Opção Inválida");
                        break;
                }
                                
                
            } while (op != 0);
        }

        public static void CadastrarCliente(List<Cliente> clientes)
        {
            Console.Write($"Informe o nome do Cliente: ");
            string nome = Console.ReadLine()!;
            Console.Write($"Informe o CPF do Cliente: ");
            string cpf = Console.ReadLine()!;
            Console.Write($"Informe o Telefone do Cliente: ");
            string telefone = Console.ReadLine()!;
            Console.Write($"Informe o Endereço do Cliente: ");
            string endereco = Console.ReadLine()!;
            
            Cliente cliente = new ClienteGold
            {
                Nome = nome,
                CPF = cpf,
                Telefone = telefone,
                Endereco = new Endereco
                {
                    Rua = endereco.Split(',')[0],
                    Cidade = endereco.Split(',')[1],
                    Estado = endereco.Split(',')[2],
                    CEP = Convert.ToInt32(endereco.Split(',')[3])
                }
            };
            clientes.Add(cliente);
            
        }
    }
}