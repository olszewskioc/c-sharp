using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_Biblioteca.Models;
using Exercicio_Biblioteca.Models.Library;
using Exercicio_Biblioteca.Models.User;

namespace Exercicio_Biblioteca
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Leitor> leitores =
            [
                new Leitor("Thiago", "030.669.871-40"),
                new Leitor("João", "789.456.123-47"),
            ];

            Biblioteca biblioteca= new Biblioteca("Leitura", leitores);
            Funcionario funcionario = new Funcionario("Roberto", "654.363.258-98", "Vendedor");

            Rede rede = new Rede("Saraiva");
            rede.AddBiblioteca(biblioteca);
            rede.AddFuncionario(biblioteca, funcionario);
            
            foreach (var item in rede.Bibliotecas)
            {
                Console.WriteLine($"{item}");
            }
            foreach (var item in rede.Funcionarios)
            {
                Console.WriteLine($"{item}");
            }

            Livro livro = new Livro("A volta ao mundo em 80 dias", "Jules Verne", DateTime.Parse("1980-10-17"), 10);
            biblioteca.AddLivro(livro);

            leitores[0].ConsultaLivros(biblioteca);
            funcionario.Emprestimo(biblioteca, leitores[0], livro);

        }
    }
}