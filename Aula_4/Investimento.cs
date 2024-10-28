using System;
using System.Globalization;
namespace Aula_4
{
    internal class Investimento
    {
       static void Main(string[] args)
       {
            Console.Clear();
            Console.WriteLine($"\n-----------------------------------------");
            Console.WriteLine("\tBem-vindo aos investimentos");
            Console.WriteLine($"-----------------------------------------");
            Console.WriteLine("Escolha uma opção (0 para sair):\n1 - Poupança (3% a.a)\n2 - Renda Fixa (5% a.a)\n3 - Ações (10% a.a com possibilidade de 5% perda)\n");
            string op = Console.ReadLine();

            while (op != "0")
            {
                Console.Clear();
                Console.Write("\nInforme seu saldo: ");
                double balance = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nQuantos anos deseja investir: ");
                int years = Convert.ToInt32(Console.ReadLine());
                double tax = 0, tax_lost = 0;
                double perda = 0;

                switch (op)
                {
                    case "1":
                        tax = 1.03d;
                        break;
                    case "2":
                        tax = 1.05d;
                        break;
                    case "3":
                        tax = 1.1d;
                        tax_lost = 0.05d;
                        for (int i = 1; i <= years; i++)
                        {
                            balance *= tax;
                            double losts = balance * tax_lost;
                            perda += losts;
                            Console.WriteLine($"Ano {i}:  R${balance.ToString("F2", CultureInfo.InvariantCulture)} com possibilidade de R${losts.ToString("F2", CultureInfo.InvariantCulture)} de perda.");
                        }
                        Console.WriteLine($"\nMontante final: R${(balance - perda).ToString("F2", CultureInfo.InvariantCulture)}");
                        Console.WriteLine($"Perdas totais: R${perda.ToString("F2", CultureInfo.InvariantCulture)}");
                        break;
                    default:
                        Console.WriteLine("\nInforme uma opção válida!!\nAperte qualquer tecla para sair...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                if(op != "3")
                {
                    
                    for (int i = 1; i <= years; i++)
                    {
                        balance *= tax;
                        Console.WriteLine($"Ano {i}:  R${balance.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                
                }
                Console.WriteLine($"\nDigite qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"\n-----------------------------------------");
                Console.WriteLine("\tBem-vindo aos investimentos");
                Console.WriteLine($"-----------------------------------------");
                Console.WriteLine("Escolha uma opção (0 para sair):\n1 - Poupança (3% a.a)\n2 - Renda Fixa (5% a.a)\n3 - Ações (10% a.a com possibilidade de 5% perda)\n");
                op = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("\nObrigado por utilizar o nosso sistema de investimentos!!\n");
       } 
    }
}