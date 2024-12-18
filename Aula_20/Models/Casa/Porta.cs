using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace Aula_20.Models.Casa
{
    public class Porta
    {
        private string? _cor;
        private float _largura;
        private float _altura;
        private double _peso;

        public string? Cor { get { return _cor; }  set { _cor = value; } }
        public float Largura { get { return _largura; }  set { _largura = value; } }
        public float Altura { get { return _altura; }  set { _altura = value; } }
        public double Peso { get { return _peso; }  set { _peso = value; } }

        public Porta(string? cor="Marrom", float largura=1f, float altura=2.10f, double peso=2)
        {
            Cor = cor;
            Largura = largura;
            Altura = altura;
            Peso = peso;
        }
        public virtual void Abrir()
        {
            Console.WriteLine($"Porta aberta");
        }

        public virtual void Fechar()
        {
            Console.WriteLine($"Porta fechada");
        }
    }
}