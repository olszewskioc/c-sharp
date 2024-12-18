using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_20.Models.Casa;

namespace Aula_20.Models.Casa.Quarto
{
    public class PortaQuarto : Porta
    {
        public PortaQuarto(string? cor="Azul", float largura=1f, float altura=2.10f, double peso=2) : base(cor, largura, altura, peso) {}
        public override void Abrir()
        {
            Console.WriteLine($"Porta do quarto aberta");
        }

        public override void Fechar()
        {
            Console.WriteLine($"Porta do quarto fechada");
        }
    }
}