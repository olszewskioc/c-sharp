using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20.Models.Casa.Sala
{
    public class Sala
    {
        private PortaSala _portaEntrada;
        private float _metragemQuadrada;
        private Porta _portaAuxiliar;

        public PortaSala PortaEntrada { get { return _portaEntrada;} set { _portaEntrada = value;} }
        public float MetragemQuadrada { get { return _metragemQuadrada;} set { _metragemQuadrada = value; } }
        public Porta PortaAuxiliar { get { return _portaAuxiliar;} set { _portaAuxiliar = value; } }

        public Sala(float metragemQuadrada, Porta portaAuxiliar)
        {
            _metragemQuadrada = metragemQuadrada;
            _portaEntrada = new PortaSala();
            _portaAuxiliar = portaAuxiliar;
        }

        public void Entrar()
        {
            Console.WriteLine($"Entrando pela porta {PortaEntrada.Cor} da sala.");
            Console.WriteLine($"Entrando pela porta {PortaAuxiliar.Cor} auxiliar da sala.");
        }
    }
}