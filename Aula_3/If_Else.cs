using System;
using System.Globalization;
namespace Aula_3
{
    internal class If_Else
    {
        static void Teste2(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Qual seu tipo de investimento?\n1 - Poupança\t2 - Renda Fixa\t3 - Ações?");
            int type = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInforme seu saldo: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nQuantos anos deseja investir?: ");
            int years = Convert.ToInt32(Console.ReadLine());

            if (type == 1)
            {
                double poupanca = balance * Math.Pow(1 + 0.03, years);
                Console.WriteLine($"\nInvestindo R${balance.ToString("F2", CultureInfo.InvariantCulture)} por {years} {(years == 1 ? "Ano" : "Anos")} em poupança.");
                Console.WriteLine($"\nSaldo final estimado: {poupanca.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("\nAperte qualquer tecla para sair...");
                Console.ReadKey();
                Console.Clear();
            }
            if (type == 2)
            {
                double fixa = balance * Math.Pow(1 + 0.05, years);
                Console.WriteLine($"\nInvestindo R${balance.ToString("F2", CultureInfo.InvariantCulture)} por {years} {(years == 1 ? "Ano" : "Anos")} em renda fixa.");
                Console.WriteLine($"\nSaldo final estimado: R${fixa.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("\nAperte qualquer tecla para sair...");
                Console.ReadKey();
                Console.Clear();
            }
            if (type == 3)
            {
                double actions = balance * Math.Pow(1 + 0.1, years);
                double losts = actions * 0.05;
                Console.WriteLine($"\nInvestindo R${balance.ToString("F2", CultureInfo.InvariantCulture)} por {years} {(years == 1 ? "Ano" : "Anos")} em ações.");
                Console.WriteLine($"\nGanhos estimados: {actions.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Perdas estimadas: {losts.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Saldo final estimado: {(actions-losts).ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("\nAperte qualquer tecla para sair...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nInforme uma opção válida!!\nAperte qualquer tecla para sair...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}