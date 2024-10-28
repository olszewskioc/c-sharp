using System;
namespace Aula_4
{
    internal class Calculator
    {
        static void Teste1(string[] args)
        {
            Console.Clear();
            Console.WriteLine($"\n--------------------------------------");
            Console.WriteLine("\tBem-vindo a Calculadora");
            Console.WriteLine($"--------------------------------------");
            Console.WriteLine("Escolha uma opção (0 para sair):\n1 - Tabuada\t2 - Soma\t 3 - Logaritmo\n4 - Potência\t5 - Divisão\t 6 - Resto\n");
            string op = Console.ReadLine();
            

            while (op != "0")
            {
                switch (op)
                {
                    case "1":
                        Console.Write("\nInforme o número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i <= 10; i++)
                        {
                            Console.WriteLine($"{num} x {i} = {num * i}");
                        }
                        Console.Write("\nDigite qualquer tecla para retornar ao menu!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Write("\nInforme o número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nInforme o outro número: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{num} + {num2} = {num + num2}");
                        
                        Console.Write("\nDigite qualquer tecla para retornar ao menu!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Write("\nInforme o número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nInforme a base: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"log de {num} na base {num2} = {Math.Log(num, num2)}");

                        Console.Write("\nDigite qualquer tecla para retornar ao menu!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Write("\nInforme a base: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nInforme a potência: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"log de {num} na base {num2} = {Math.Pow(num, num2)}");

                        Console.Write("\nDigite qualquer tecla para retornar ao menu!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Write("\nInforme o número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nInforme o número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{num} / {num2} = {num / num2}");
                        
                        Console.Write("\nDigite qualquer tecla para retornar ao menu!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "6":
                        Console.Write("\nInforme o número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nInforme o número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{num} % {num2} = {num % num2}");

                        Console.Write("\nDigite qualquer tecla para retornar ao menu!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.Write("\nInforme uma opção válida!\n\nDigite qualquer tecla para retornar ao menu!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

                Console.WriteLine($"\n--------------------------------------");
                Console.WriteLine("\tBem-vindo a Calculadora");
                Console.WriteLine($"--------------------------------------");
                Console.WriteLine("Escolha uma opção (0 para sair):\n1 - Tabuada\t2 - Soma\t3- Subtração\n4 - Multiplicação\t5 - Divisão\t 6 - Resto");
                op = Console.ReadLine();
            }

        }
    }
}