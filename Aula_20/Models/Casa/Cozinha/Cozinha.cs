using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20.Models.Casa.Cozinha
{
    public class Cozinha
    {
        private PortaCozinha? _porta;
        private bool _americana;
        private float _metragemQuadrada;

        public PortaCozinha? Porta { get { return _porta; } set { _porta = value; } }
        public bool Americana { get { return _americana; } set { _americana = value; } }
        public float MetragemQuadrada { get { return _metragemQuadrada; } set { _metragemQuadrada = value; } }

        public Cozinha(bool americana, float metragemQuadrada, PortaCozinha? porta=null)
        {
            _americana = americana;
            _metragemQuadrada = metragemQuadrada;
            _porta = porta;
        }

        public void Entrar()
        {
            Console.WriteLine($"Entrando pela porta {Porta?.Cor} da cozinha.");
        }
    }
}