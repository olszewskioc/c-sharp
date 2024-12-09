using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_17.Models.Empregado;
using Aula_17.Models.Forma;
using Aula_17.Models.Produto;

namespace Aula_17
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Retangulo retangulo= new ("Retangulo 1", 5, 10);
            Circulo circulo= new ("Circulo 1", 5);
            
            // retangulo.Print();
            // circulo.Print();

            Assalariado assalariado = new("Robson", "Silva", "669.558.447-10", 5000);
            Comissionado comissionado = new("Jefferson", "Araújo", "789.456-123-00", 4000, 10);
            Horista horista = new("Ana", "Leite", "123.456.789-10", 200, 20);

            // assalariado.Print();
            // comissionado.Print();
            // horista.Print();

            Produto [] produtos = [new CompactDisc(1, 150, "Titãs", "Morena"), new Livro(2, 60, "Thiago O.", "C++")];
            foreach (var produto in produtos)
            {
                produto.Print();
                produto.AtualizaPreco(50);
                produto.setCodigo(0);
                produto.Print();
            }
            
        }
    }
}