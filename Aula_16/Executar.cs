using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Limpeza limpeza = new("Álcool 70%", 10, 10);
            Lacticinio lacticinio = new("Achocolatado", 25, 15);
            Ferramenta ferramenta = new("Alicate", 50, 32);
            Carne carne = new("Coxão Mole", 38, 65);
            Petiscos petiscos= new();

            limpeza.Print();
            // lacticinio.Print();
            Console.WriteLine($"{lacticinio}");
            
            ferramenta.Print();
            carne.Print();
            petiscos.Print();

            Console.WriteLine($"\nPreço em estoque Limpeza: R${limpeza.CalcularEstoque():F2}");
            Console.WriteLine($"Preço em estoque Lacticínio: R${lacticinio.CalcularEstoque():F2}");
            Console.WriteLine($"Preço em estoque Ferramenta: R${ferramenta.CalcularEstoque():F2}");
            Console.WriteLine($"Preço em estoque Carne: R${carne.CalcularEstoque():F2}");
            Console.WriteLine($"Preço em estoque petiscos: R${petiscos.CalcularEstoque():F2}");
                
        }
    }
}