// Construa um programa que receba uma palavra do usuário. O programa deverá
// verificar se esta palavra corresponde à senha de acesso (senha: “Digix”). Se a palavra
// fornecida pelo usuário for igual a senha, o programa deverá informar “Acesso
// autorizado”, caso contrário, deverá informar “Acesso negado”.

using System;
namespace Aula_5
{
    internal class Ex2
    {
        static void Password(string[] args)
        {
            Console.Clear();
            Console.Write("\nDigite a palavra de acesso: ");
            string password = Console.ReadLine();
            string response =  (password == "Digix") ? "Acesso autorizado\n" : "Acesso negado\n";

            Console.WriteLine(response);
        }
    }
}