using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_18.Exercicio;
using Aula_18.Encapsulamento;

namespace Aula_18
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Console.Clear();
            
            List<ContaBancaria> c = [];

            Console.WriteLine($"\nInforme sua opção: \n1 - Criar conta\t2 - Realizar Saque\t3 - Realizar Depósito\n4 - Visualizar Conta\t5 - Alterar Titular\t0 - Sair");
            
            string? op = Console.ReadLine();
            int id = 1;
            string? nome;
            int conta;

            while (op != "0")
            {
                switch (op)
                {
                    case "1":
                        Console.Clear();
                        Console.Write($"\nInforme o nome do titular: ");
                        nome = Console.ReadLine();
                        if (nome == null) 
                        { 
                            Console.WriteLine("Nome inválido");
                            Console.ReadKey(); 
                            break;
                        }
                        else 
                        {
                            Console.Clear();
                            Console.WriteLine($"\nDeseja realizar um saldo inicial? s/n");
                            string? resposta = Console.ReadLine();
                            resposta = resposta == null ? resposta : resposta.ToLower();
                            Console.Clear();
                            if (resposta != null)
                            {
                                if (resposta == "s")
                                {
                                    Console.Write($"Informe o saldo inicial: ");
                                    double valor = Convert.ToDouble(Console.ReadLine());
                                    c.Add(new ContaBancaria(id, nome, valor));
                                }
                                else if (resposta == "n")
                                    c.Add(new ContaBancaria(id, nome));
                                else Console.Write($"Resposta inválida!");
                            }
                        }
                        Console.ReadKey();
                        break;
                        case "2":
                            Console.Clear();
                            Console.Write($"Informe o ID da sua conta: ");
                            conta = Convert.ToInt32(Console.ReadLine());
                            if (conta == 0 || conta > c.Count) 
                            {
                                Console.Write($"ID inválido!");
                                Console.ReadKey();
                                break;
                            }
                            Console.Clear();
                            Console.Write($"Informe o valor do saque: ");
                            double valorSaque = Convert.ToDouble(Console.ReadLine());
                            c[conta - 1].Saque(valorSaque);
                            Console.ReadKey();
                            break;
                        case "3":
                            Console.Clear();
                            Console.Write($"Informe o ID da sua conta: ");
                            conta = Convert.ToInt32(Console.ReadLine());
                            if (conta == 0 || conta > c.Count) 
                            {
                                Console.Write($"ID inválido!");
                                Console.ReadKey();
                                break;
                            }
                            Console.Clear();
                            Console.Write($"Informe o valor do Deposito: ");
                            double valorDeposito = Convert.ToDouble(Console.ReadLine());
                            c[conta - 1].Deposito(valorDeposito);
                            Console.ReadKey();
                            break;
                        case "4":
                            Console.Clear();
                            Console.Write($"Informe o ID da sua conta: ");
                            conta = Convert.ToInt32(Console.ReadLine());
                            if (conta == 0 || conta > c.Count) 
                            {
                                Console.Write($"ID inválido!");
                                Console.ReadKey();
                                break;
                            }
                            Console.Clear();
                            Console.WriteLine($"{c[conta - 1]}");
                            break;
                        case "5":
                            Console.Clear();
                            Console.Write($"Informe o ID da sua conta: ");
                            conta = Convert.ToInt32(Console.ReadLine());
                            if (conta == 0 || conta > c.Count) 
                            {
                                Console.Write($"ID inválido!");
                                Console.ReadKey();
                                break;
                            }
                            Console.Clear();
                            Console.Write($"Informe o novo titular: ");
                            string? novoTitular = Console.ReadLine();
                            if (novoTitular != null)
                                c[conta - 1].Titular = novoTitular;

                            Console.ReadKey();
                            break;
                    default:
                        Console.Clear();
                        Console.Write($"Opção inválida!");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
                Console.WriteLine($"\nInforme sua opção: \n1 - Criar conta\t2 - Realizar Saque\t3 - Realizar Depósito\n4 - Visualizar Conta\t5 - Alterar Titular\t0 - Sair");
                op = Console.ReadLine(); 
            }

            


            // List<ContaBancaria> c = [new ContaBancaria(1, "Thiago Olszewski", 100), new ContaBancaria(2, "Ronaldinho Gaúcho")];

            // foreach (var conta in c)
            // {
            //     Console.WriteLine($"{conta}");
            //     conta.Saque(20);
            //     conta.Deposito(200);
            // }



            // Produto produto = new("Teclado", 50);
            // Console.WriteLine($"{produto.Nome} - {produto.Preco} - {produto.GetQuantidade()}");
            // produto.Nome = "Mouse";
            // produto.Preco = 5;
            // produto.AddProdutos(10);
            // Console.WriteLine($"{produto.ToString()}");

            // Academia academia= new("SmartFit", 50);
            // Console.WriteLine($"{academia}");

            // Type t = typeof(Produto);
            // Console.WriteLine($"{t}");
            

            // foreach (PropertyInfo prop in t.GetProperties())
            // {
            //     Console.WriteLine($"{prop}");
            // }
        }
    }
}