using System;
namespace Aula_8
{
    public class FuncFlex
    {
        public delegate int Operacao(int a, int b);
        // Expressão Lambda
        static int Soma(int a, int b) => a + b;

        // Juntar duas funções no delegate
        public delegate void Notificar();
        public static void SendEmail() =>  Console.WriteLine("Email enviado");
        public static void SendSms() => Console.Write("SMS Enviado");


        static void Teste(string[] args)
        {
            Operacao op = Soma;
            Operacao op2 = (int a, int b) => a - b;
            Func<int, int, int> func = delegate(int a, int b) { return a * b; };
            Notificar notificar = SendEmail;
            notificar += SendSms;

            notificar();
            Console.WriteLine($"{op(10, 5)}");
            Console.WriteLine($"{op2(10, 5)}");
            Console.WriteLine($"{func(10, 5)}");
            
        }
    }    
}