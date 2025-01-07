using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_21.Exercicio_Enum;
using Aula_21.Exercicio_Enum.Enums;

namespace Aula_21
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Empregados empregadosClasse = new Empregados();
            List<Empregado> empregados = new List<Empregado>();

            string? op;

            do
            {
                Console.Clear();
                Console.WriteLine($"============== Sistema de Empregados ==============");
                Console.WriteLine($"1 - Adicionar empregado");
                Console.WriteLine($"2 - Folha de pagamento");
                Console.WriteLine($"3 - Imprime empregados");
                Console.WriteLine($"4 - Autorizar licença");
                Console.WriteLine($"5 - Conceder aumento");
                Console.WriteLine($"0 - Sair");
                
                op = Console.ReadLine() ?? string.Empty;

                switch (op)
                {
                    case "1":
                        empregadosClasse.Insere();
                        break;
                    case "2":
                        Console.WriteLine($"Total a ser pago: R$ {empregadosClasse.DoFolhaPagamento():F2}");
                        Console.WriteLine("\n\nAperte qualquer tecla para voltar...");
                        Console.ReadKey();
                        break;
                    case "3":
                        empregadosClasse.Imprime();
                        Console.WriteLine("\n\nAperte qualquer tecla para voltar...");
                        Console.ReadKey();
                        break;
                    case "4":
                        AutorizarLicenca(empregadosClasse);
                        break;
                    case "5":
                        ConcederAumento(empregadosClasse);
                        break;
                    case "0":
                        Console.WriteLine("\n\nSaindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida\n\nAperte qualquer tecla para voltar...");
                        Console.ReadKey();
                        break;
                }
                
                
            } while (op != "0");
        }

        public static void AutorizarLicenca(Empregados empregados)
        {
            Console.Clear();
            
            Console.WriteLine($"============== Autorizar Licença ==============");
            Console.Write($"\nInforme o nome do empregado: ");
            string nome = Console.ReadLine() ?? throw new InvalidOperationException("Não foi possível ler a entrada do usuário");

            List<Empregado> empregadosList = empregados.EmpregadosList?.ToList() ?? [];

            Empregado? empregado = empregadosList.Find(c => c.Name == nome);
            Console.WriteLine(empregado?.TipoEmpregado);
        }
        public static void ConcederAumento(Empregados empregados)
        {
            Console.Clear();
            
            Console.WriteLine($"============== Autorizar Licença ==============");
            Console.Write($"\nInforme o nome do empregado: ");
            string nome = Console.ReadLine() ?? throw new InvalidOperationException("Não foi possível ler a entrada do usuário");

            List<Empregado> empregadosList = empregados.EmpregadosList?.ToList() ?? [];

            Empregado? empregado = empregadosList.Find(c => c.Name == nome);
            if (empregado == null) return;
            if (empregado.TipoEmpregado == TipoEmpregado.GerenteVendas)
            {
                empregado = new GerenteVendas();
                
            }
            else if (empregado.TipoEmpregado == TipoEmpregado.GerenteProducao)
            {
                empregado = new GerenteProducao();
            }
            else
            {
                Console.WriteLine($"Você não é gerente!\n");
                

            }
            
            Console.ReadKey();
            
        }
    }
}