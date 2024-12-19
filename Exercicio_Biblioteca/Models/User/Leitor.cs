using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_Biblioteca.Models.Library;

namespace Exercicio_Biblioteca.Models.User
{
    public class Leitor(string nome, string cpf) : Usuario(nome, cpf)
    {
        public void ConsultaLivros(Biblioteca biblioteca)
        {
            foreach (var item in biblioteca.Catalogo.Livros)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}