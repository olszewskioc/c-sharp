using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Revisao.Ex3
{
    public class Locadora(string nome) : IAlugar
    {
        public string Nome { get; set;} = nome;
        public List<Veiculo> Veiculos { get; set; } = new List<Veiculo>();

        public void ConsultaVeiculo()
        {
            if (Veiculos != null && Veiculos.Count > 0)
            {
                foreach (var item in Veiculos)
                {
                    Console.WriteLine($"Nome: {item.Nome}\nMarca: {item.Marca}\nCategoria: {item.Categoria}\nFlex: {item.Flex}\nDisponivel: {item.Disponivel}\n");
                }
            }
        }
        public bool AddVeiculo(Veiculo veiculo)
        {
            try
            {
                Veiculos.Add(veiculo);
                return true;
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("" + ex.Message);
                return false;
            }
        }
        public bool Alugar(Veiculo veiculo)
        {
            if (Veiculos.Contains(veiculo) && veiculo.Disponivel)
            {
                veiculo.Disponivel = false;
                return true;
            } else 
            {
                return false;
            }
        }
        public bool Devolver(Veiculo veiculo)
        {
            if (Veiculos.Contains(veiculo) && veiculo.Disponivel)
            {
                veiculo.Disponivel = true;
                return true;
            } else 
            {
                return false;
            }
        }
    }
}