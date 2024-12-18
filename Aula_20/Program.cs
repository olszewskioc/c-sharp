using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_20.Models.Escola;

using Aula_20.Models.Casa.Cozinha;
using Aula_20.Models.Casa.Sala;
using Aula_20.Models.Casa.Quarto;
using Aula_20.Models.Casa;

using Aula_20.Models.Empresa.Enderecos;
using Aula_20.Models.Empresa.Funcionario;
using Aula_20.Models.Empresa.Funcionario.Vendedor;
using Aula_20.Models.Empresa.Funcionario.Gerente;

namespace Aula_20
{
    public class Program
    {
        static void Main(string[] args)
        { 
            // Escola escola= new Escola("João");
            // Professor professor= new Professor("Roberto");
            // escola.ContratarProfessor(professor);
            // escola.Info();
            // Porta porta = new Porta("Amarela", 1.5f, 2.25f, 3.5);
            // porta.Abrir();
            // porta.Fechar();

            // PortaCozinha portaCozinha = new PortaCozinha("Lilás");
            // portaCozinha.Abrir();
            // portaCozinha.Fechar();

            // Quarto quarto = new Quarto(true, 15.5f);
            // Sala sala = new Sala(15.5f, porta);
            // Cozinha cozinha = new Cozinha(false, 10.4f, portaCozinha);

            // quarto.Entrar();
            // sala.Entrar();
            // cozinha.Entrar();

            Estado ms = new Estado("Mato Grosso do Sul", "MS");
            Cidade cg = new Cidade("Campo Grande", ms);
            Endereco endereco = new Endereco("São Cosme e Damião", 1167, "Vila Progresso", "79050-390", cg);
            Funcionario funcionario = new Funcionario("Thiago", DateTime.Parse("2002-10-01"), "030.669.871-40", endereco);
            Vendedor vendedor = new Vendedor("Roberto", DateTime.Parse("2005-12-10"), "066.888.871-41", endereco);
            Gerente gerente = new Gerente("Gabriel", DateTime.Parse("1996-04-20"), "987.363.871-89", endereco);
            
            
            Console.WriteLine($"Funcionário: {funcionario}");
            Console.WriteLine($"Vendedor: {vendedor}");
            gerente.GetSalario();
            Console.WriteLine($"Gerente: {gerente}");
            
            
        }
    }
}