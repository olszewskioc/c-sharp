using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_23.Models;

namespace Aula_23
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // int n1 = 10;
            // int n2 = 0;

            // try
            // {
            //     int result = n1/n2;
            //     Console.WriteLine(result);
            // }
            // catch (DivideByZeroException)
            // {
            //     Console.WriteLine($"Exceção: Tentativa de divisão por 0");
            // }
            // Console.Write($"Room number: ");
            // int roomNumber = Convert.ToInt32(Console.ReadLine());
            
            // Console.Write($"Check-in (dd/MM/yyyy): ");
            // DateTime checkIn = DateTime.Parse(Console.ReadLine() ?? throw new NullReferenceException("Check-in cannot be null"));
           
            // Console.Write($"Check-out (dd/MM/yyyy): ");
            // DateTime checkOut = DateTime.Parse(Console.ReadLine() ?? throw new NullReferenceException("Check-out cannot be null"));
            
            // Reservation r = new(checkIn, checkOut, roomNumber);

            // Console.WriteLine($"{r}");
            // Console.Write($"Check-in (dd/MM/yyyy): ");
            // checkIn = DateTime.Parse(Console.ReadLine() ?? throw new NullReferenceException("Check-in cannot be null"));
            // Console.Write($"Check-out (dd/MM/yyyy): ");
            // checkOut = DateTime.Parse(Console.ReadLine() ?? throw new NullReferenceException("Check-out cannot be null"));

            // r.UpdateDates(checkIn, checkOut);
            
            Console.Write($"\nAccount number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine() ?? throw new NullReferenceException("Account number cannot be null"));

            Console.Write($"\nHolder: ");
            string holder = Console.ReadLine() ?? throw new NullReferenceException("Holder cannot be null");

            Console.Write($"\nInitial balance: ");
            double initialBalance = Convert.ToDouble(Console.ReadLine() ?? throw new NullReferenceException("Initial balance cannot be null"));

            Console.Write($"\nWithdraw Limit: ");
            double withdrawLimit = Convert.ToDouble(Console.ReadLine() ?? throw new NullReferenceException("Withdraw Limit cannot be null"));

            Account account = new(accountNumber, holder, initialBalance, withdrawLimit);

            Console.WriteLine($"\n{account}\n");

            account.Deposit(500);
            account.Withdraw(300);
            account.Withdraw(300);
        }
    }
}