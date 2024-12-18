using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_20.Models.Casa;

namespace Aula_20.Models.Casa.Sala
{
    public class PortaSala : Porta
    {
        public PortaSala(string? cor="Branca", float largura=1f, float altura=2.10f, double peso=2) : base(cor, largura, altura, peso) {}
        public override void Abrir()
        {
            Console.WriteLine($"Porta da sala aberta");
        }

        public override void Fechar()
        {
            Console.WriteLine($"Porta da sala fechada");
        }
    }
}