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
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            Estoque estoque = new Estoque();

            string? op;

            do
            {
                Console.Clear();
                Console.WriteLine($"\nInforme uma opção:");
                Console.WriteLine($"1 - Cadastrar Cliente");
                Console.WriteLine($"2 - Cadastrar Produto");
                Console.WriteLine($"3 - Cadastrar Venda");
                Console.WriteLine($"4 - Consultar Estoque");
                Console.WriteLine($"5 - Gerar Relatório de Funcionários");
                Console.WriteLine($"6 - Cadastrar Fornecedor");
                Console.WriteLine($"0 - Sair");

                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        CadastrarCliente(clientes);
                        Console.WriteLine($"\n\nAperte qualquer tecla para continuar...");;
                        Console.ReadKey();
                        break;
                    case "2":
                        CadastrarProduto(produtos, estoque, fornecedores);
                        Console.WriteLine($"\n\nAperte qualquer tecla para continuar...");;
                        Console.ReadKey();
                        break;
                    case "3":
                        CadastrarVenda(clientes, produtos, vendas, estoque);
                        Console.WriteLine($"\n\nAperte qualquer tecla para continuar...");;
                        Console.ReadKey();
                        break;
                    case "4":
                        ConsultarEstoque(estoque);
                        Console.WriteLine($"\n\nAperte qualquer tecla para continuar...");;
                        Console.ReadKey();
                        break;
                    case "5":
                        GerarRelatorioVendas(vendas);
                        Console.WriteLine($"\n\nAperte qualquer tecla para continuar...");;
                        Console.ReadKey();
                        break;
                    case "6":
                        CadastrarFornecedor(fornecedores);
                        Console.WriteLine($"\n\nAperte qualquer tecla para continuar...");;
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.WriteLine($"Saindo...");
                        break;
                    default:
                        Console.WriteLine($"Opção Inválida");
                        Console.WriteLine($"\n\nAperte qualquer tecla para continuar...");;
                        Console.ReadKey();
                        break;
                }
                                
                
            } while (op != "0");
        }

        public static void CadastrarCliente(List<Cliente> clientes)
        {
            Console.Write($"Informe o nome do Cliente: ");
            string nome = Console.ReadLine()!;
            Console.Write($"Informe o CPF do Cliente: ");
            string cpf = Console.ReadLine()!;
            Console.Write($"Informe o Telefone do Cliente: ");
            string telefone = Console.ReadLine()!;
            Console.Write($"Informe o Endereço do Cliente (Rua, Cidade, CEP): ");
            string endereco = Console.ReadLine()!;
            Console.Write($"Informe a sigla do seu estado: ");
            string estado = Console.ReadLine()!;
            if (!Enum.TryParse(estado, out Estado estadoEnum))
            {
                Console.WriteLine($"Estado Inválido");
                return;
            }
            
            Cliente cliente = new ClienteGold
            {
                Nome = nome,
                CPF = cpf,
                Telefone = telefone,
                Endereco = new Endereco
                {
                    Rua = endereco.Split(", ")[0],
                    Cidade = endereco.Split(", ")[1],
                    Estado = estadoEnum,
                    CEP = Convert.ToInt32(endereco.Split(", ")[2])
                }
            };
            clientes.Add(cliente);
            
        }

        private static void CadastrarProduto(List<Produto> produtos, Estoque estoque, List<Fornecedor> fornecedores)
        {
            List<int> quantidades = estoque.Quantidades?.ToList() ?? new List<int>();
            Console.Clear();
            if (fornecedores.Count > 0)
            {
                DateTime dataValidade = DateTime.MinValue;
                Console.WriteLine($"Cadasto de produto");
                Console.Write($"\nInforme o nome do produto: ");
                string nome = Console.ReadLine()!;
                Console.Write($"\nPreço de custo: ");
                double precoCusto = Convert.ToDouble(Console.ReadLine());
                Console.Write($"\nPreço de venda: ");
                double precoVenda = Convert.ToDouble(Console.ReadLine());
                // Console.Write($"\nApelido: ");
                // string apelido = Console.ReadLine()!;
                Console.Write($"\nPerecivel (S ou N): ");
                bool perecivel = Console.ReadLine()!.ToUpper().Equals("S");
                if (perecivel)
                {
                    Console.Write($"\nData de validade (YYYY-MM-DD): ");
                    dataValidade = Convert.ToDateTime(Console.ReadLine());
                }

                Console.WriteLine($"\n==========================================");

                foreach (var fornecedor in fornecedores)
                {
                    Console.WriteLine($"\nFornecedor 0\n");
                    Console.WriteLine($"Nome: {fornecedor.Nome}");
                    Console.WriteLine($"Endereço: {fornecedor.Endereco.Rua}, {fornecedor.Endereco.Cidade}, {fornecedor.Endereco.Estado} - {fornecedor.Endereco.CEP}");
                    Console.WriteLine($"CNPJ: {fornecedor.CNPJ}");
                    Console.WriteLine($"Recorrente: {fornecedor.Recorrente}");
                    Console.WriteLine($"Desconto: {fornecedor.Desconto * 100:F2}%");
                    Console.WriteLine($"-----------------------------------------------");
                }

                Console.Write($"\n Informe o número do fornecedor: ");
                int numeroFornecedor = Convert.ToInt32(Console.ReadLine());

                string apelido = ApelidosPorEstado[fornecedores[numeroFornecedor].Endereco.Estado];

                Produto produto = new Produto()
                {
                    Nome = nome,
                    Codigo = produtos.Count + 1,
                    Fornecedor = fornecedores[numeroFornecedor],
                    PrecoCusto = precoCusto,
                    PrecoVenda = precoVenda,
                    Apelido = apelido,
                    Perecivel = perecivel,
                    DataValidade = dataValidade,
                };

                produtos.Add(produto);
                estoque.Produtos = produtos.ToArray();
                Console.Write($"\nInforme a quantidade deste produto diponível: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());
                quantidades.Add(quantidade);
                estoque.Quantidades = quantidades.ToArray();
                 
                Console.WriteLine($"Produto {produto.Nome} cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Nenhum fornecedor cadastrado para realizar o cadastro do produto!");
                
            }
        }

        private static void CadastrarVenda(List<Cliente> clientes, List<Produto> produtos, List<Venda> vendas, Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine($"=====Cadastro de Venda=====");
            Console.Write($"\nDigite o CPF do Cliente: ");
            string cpf = Console.ReadLine()!;
            Cliente? cliente = clientes.Find(c => c.CPF == cpf);

            if (cliente == null)
            {
                Console.WriteLine($"Cliente não encontrado");
                return;   
            }

            List<Produto> produtosVenda = [];

            while (true)
            {
                Console.Write($"\nDigite o código do produto (0 para finalizar): ");
                int codigoProduto = Convert.ToInt32(Console.ReadLine());
                if (codigoProduto == 0) break;
                Produto? produto = produtos.Find(p => p.Codigo == codigoProduto);
                if (produto == null)
                {
                    Console.WriteLine($"Produto não encontrado");
                }
                else
                {
                    Console.WriteLine($"{produto.Nome} Adicionado a venda");
                    Console.Write($"Quantas unidades: ");
                    int quantidade = Convert.ToInt32(Console.ReadLine());
                    produtosVenda.Add(produto);
                    // Achar o produto no estoque e atualizar a quantidade
                    int index = Array.IndexOf(estoque.Produtos!, produto);
                    estoque.Quantidades![index] -= quantidade; 
                }
            }

            Console.Write($"\nQual será a forma de pagamento (Cartão, Dinheiro ou PIX): ");
            string formaPagamento = Console.ReadLine()!.ToUpper();
            Console.Write($"\nQuantas parcelas: ");
            int parcelas = Convert.ToInt32(Console.ReadLine());

            Venda venda = new Venda()
            {
                Produtos = produtosVenda.ToArray(),
                Data = DateTime.Now,
                Cliente = cliente,
                FormaPagamento = formaPagamento,
                Parcelas = parcelas,
            };
            venda.ValorTotal = venda.CalcularValorFinal();
            vendas.Add(venda);
            Console.WriteLine($"\nVenda realizada com sucesso!");
            
        }

        private static void ConsultarEstoque(Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine($"===== Consulta Estoque =====\n");
            
            if (estoque.Produtos != null)
            {
                foreach (var produto in estoque.Produtos)
                {
                    int index = Array.IndexOf(estoque.Produtos, produto);
                    Console.WriteLine($"{produto.Nome} ({produto.Apelido} - {produto.Fornecedor.Endereco.Estado}) -> {estoque.Quantidades?[index]} unidades");
                }
            }
            else
            {
                Console.WriteLine($"Não existe nenhum produto em estoque!\n");
                
            }
        }

        private static void GerarRelatorioVendas(List<Venda> vendas)
        {
            Console.Clear();
            Console.WriteLine($"===== Relatório de Vendas =====\n");

            foreach (var venda in vendas)
            {
                Console.WriteLine($"Venda N° {vendas.IndexOf(venda)} | {venda.Data}");
                Console.WriteLine($"Cliente: {venda.Cliente?.Nome}");
                Console.WriteLine($"Vendedor: {venda.Vendedor?.Nome}");
                Console.WriteLine($"----------------------------------------\n");
                
            }
            
        }

        private static void CadastrarFornecedor(List<Fornecedor> fornecedores)
        {
            Console.Clear();
            Console.WriteLine($"=====Cadastro de Fornecedor=====");
            Console.Write($"\nDigite o nome do Fornecedor: ");
            string nome = Console.ReadLine()!;
            if (nome == null)
            {
                Console.WriteLine($"Nome do Fornecedor não pode ser vazio");
                return;
            }
            Console.Write($"\nDigite o CNPJ do Fornecedor: ");
            string cnpj = Console.ReadLine()!;

            Console.Write($"Informe o Endereço do Cliente (Rua, Cidade, CEP): ");
            string endereco = Console.ReadLine()!;
            Console.Write($"Informe a sigla do seu estado: ");
            string estado = Console.ReadLine()!;
            if (!Enum.TryParse(estado, out Estado estadoEnum))
            {
                Console.WriteLine($"Estado Inválido");
                return;
            }

            Console.Write($"\nRecorrente (S ou N): ");
            bool recorrente = Console.ReadLine()!.ToUpper().Equals("S");

            Fornecedor fornecedor = new Fornecedor()
            {
                Nome = nome,
                Endereco = new Endereco
                {
                    Rua = endereco.Split(',')[0],
                    Cidade = endereco.Split(',')[1],
                    Estado = estadoEnum,
                    CEP = Convert.ToInt32(endereco.Split(',')[2])
                },
                CNPJ = cnpj,
                Recorrente = recorrente,
            };
            fornecedor.Desconto = recorrente ? 0.1 : 0;

            fornecedores.Add(fornecedor);

        }

        private static Dictionary<Estado, string> ApelidosPorEstado = 
            new Dictionary<Estado, string>()
            {
                {Estado.MS, "Chipa"},
                {Estado.MG, "Pão de Queijo"}
            };
    }
}