using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20.Models.Casa.Quarto
{
    public class Quarto
    {
        private PortaQuarto _porta;
        private bool _banheiro;
        private float _metragemQuadrada;

        public PortaQuarto Porta { get { return _porta; } set { _porta = value; } }
        public bool Banheiro { get { return _banheiro; } set { _banheiro = value; } }
        public float MetragemQuadrada { get { return _metragemQuadrada; } set { _metragemQuadrada = value; } }

        public Quarto(bool banheiro, float metragemQuadrada)
        {
            _banheiro = banheiro;
            _metragemQuadrada = metragemQuadrada;
            _porta = new PortaQuarto(); // instanciando a porta quarto por ser uma relação de composição
        }

        public void Entrar()
        {
            Console.WriteLine($"Entrando pela porta {Porta.Cor} do quarto.");
        }
    }
}