using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_21.Exercicio_Enum.Enums;

namespace Aula_21.Exercicio_Enum
{
    public class Empregados
    {
        protected int numeroMaximo = 50;
        protected Empregado[] empregados = [];
        protected int numeroEmpregados;

        public int NumeroEmpregados { get => empregados.Length; }
        public Empregado[] EmpregadosList
        {
            get => empregados;
        }

        public void Insere()
        {
            Console.Clear();
            List<Empregado> empregados = this.empregados?.ToList() ?? [];
            if (empregados.Count < numeroMaximo)
            {
                Console.WriteLine($"\n===== Insere Empregado =====\n\n");

                Console.Write($"\nInforme o nome do funcionario: ");
                string nome = Console.ReadLine() ?? throw new Exception("O nome do funcionario não foi informado.");

                Console.Write($"\nInforme o salário do funcionario: ");
                double salario = Convert.ToDouble(Console.ReadLine() ?? throw new Exception("O salário do funcionario não foi informado."));

                Console.Write($"\nInforme a quantidade de licenças prêmios do funcionario: ");
                int licencaPremio = Convert.ToInt32(Console.ReadLine() ?? throw new Exception("a quantidade de licenças prêmios do funcionario não foi informado."));

                Console.Write($"\nInforme o tipo do funcionario (Vendedor = 0, GerenteVendas = 1, GerenteProducao = 2): ");
                string aux = Console.ReadLine() ?? throw new Exception("Informe uma opção.");
                if (!Enum.TryParse(aux, out TipoEmpregado tipo))
                {
                    Console.WriteLine($"Tipo de empregado Inválido");
                    return;
                }

                Empregado empregado;
                switch (tipo)
                {
                    case TipoEmpregado.Vendedor:
                        empregado = new Vendedor 
                        {
                            Name = nome,
                            Salario = salario,
                            LicencasPremioRecebidas = licencaPremio,
                            TipoEmpregado = tipo,
                        };
                        Console.WriteLine($"Cadastro do vendedor {nome} realizado.\n\nAperte qualquer tecla para sair...");
                        Console.ReadKey();
                        break;
                    case TipoEmpregado.GerenteVendas:
                        Console.Write($"\nInforme a sigla do estado de trabalho pricipal do Gerente para identificar a região: ");
                        string estado = Console.ReadLine() ?? throw new Exception("Informe um estado.");
                        if (!Enum.TryParse(estado, out Estado estadoEnum))
                        {
                            Console.WriteLine($"Estado Inválido");
                            return;
                        }
                        empregado = new GerenteVendas
                        {
                            Name = nome,
                            Salario = salario,
                            LicencasPremioRecebidas = licencaPremio,
                            Estado = estadoEnum,
                            TipoEmpregado = tipo,
                        };
                        Console.WriteLine($"Cadastro do vendedor {nome} realizado.\n\nAperte qualquer tecla para sair...");
                        Console.ReadKey();
                        break;
                    case TipoEmpregado.GerenteProducao:
                        empregado = new GerenteProducao 
                        {
                            Name = nome,
                            Salario = salario,
                            LicencasPremioRecebidas = licencaPremio,
                            TipoEmpregado = tipo,
                        };
                        Console.WriteLine($"Cadastro do vendedor {nome} realizado.\n\nAperte qualquer tecla para sair...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine($"Tipo invalidado.\n\nAperte qualquer tecla para sair...");
                        Console.ReadKey();
                        return;
                }
                
                empregados.Add(empregado);
                this.empregados = [.. empregados];
            }
        }

        public void Imprime()
        {
            Console.Clear();
            
            Console.WriteLine($"\n===== Empregados ({NumeroEmpregados}) =====\n");
            
            foreach (var empregado in empregados)
            {
                Console.WriteLine($"Nome: {empregado.Name}");
                Console.WriteLine($"Tipo: {EmpregadoHelper.GetTipo(empregado.TipoEmpregado)}");
                Console.WriteLine($"Salário: R${empregado.Salario:F2}");
                Console.WriteLine($"Licenças prêmio recebidas: R${empregado.LicencasPremioRecebidas}");
                Console.WriteLine($"\n------------------------------------------------------------------");
            }
        }
        public void Write(string text)
        {
            Console.WriteLine($"Aqui está o texto: {text}");
        }
        public void Read(string text)
        {
            Console.WriteLine($"Aqui está o texto: {text}");
        }
        public double DoFolhaPagamento() => empregados.Sum(e => e.Salario);
    }
}