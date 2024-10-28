using System;
using System.Globalization;
namespace Aula_3
{
    internal class Ternario
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Qual seu tipo de investimento?\n1 - Poupança\t2 - Renda Fixa\t3 - Ações?");
            int type = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInforme seu saldo: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nQuantos anos deseja investir?: ");
            int years = Convert.ToInt32(Console.ReadLine());

            double result = type == 1 ? balance * Math.Pow(1 + 0.03, years)
            : type == 2 ? balance * Math.Pow(1 + 0.05, years)
            : type == 3 ? balance * Math.Pow(1 + 0.1, years) 
            : 0;

            string invest = type == 1 ? "poupança"
            : type == 2 ? "renda fixa"
            : type == 3 ? "ações" 
            : "";

            double losts = result * 0.05;
            string actions = "Perdas estimadas: R$" + losts.ToString("F2", CultureInfo.InvariantCulture) + "\nSaldo final estimado: R$" + (result-losts).ToString("F2", CultureInfo.InvariantCulture) + "\nAperte qualquer tecla para sair...";

            Console.WriteLine($"\nInvestindo R${balance.ToString("F2", CultureInfo.InvariantCulture)} por {years} {(years == 1 ? "Ano" : "Anos")} em {invest}.");
            Console.WriteLine($"\nSaldo estimado: {result.ToString("F2", CultureInfo.InvariantCulture)}");

            

            Console.WriteLine($"{(type == 3 ? actions : invest == "" ? "\nInforme uma opção válida!!\nAperte qualquer tecla para sair..." : "\nAperte qualquer tecla para sair...")}");
            Console.ReadKey();
            Console.Clear();

        }
    }
}