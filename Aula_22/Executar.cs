using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_22.Models;

namespace Aula_22
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Funcionario f = new();
            f.Salario(1000);
            f.Trabalhar();

            Coordenador c = new();
            c.Salario(1000);
            c.Trabalhar();

            Gerente g = new();
            g.Salario(1000);
            g.Trabalhar();
        }
    }
}