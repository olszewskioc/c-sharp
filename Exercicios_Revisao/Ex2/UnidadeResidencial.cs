using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Revisao.Ex2
{
    public class UnidadeResidencial(float metragem, int numQuartos, int numBanheiros, string nomeProprietario, string cpfProprietario)
    {
        protected float metragemQuadrada = metragem;
        protected int numQuartos = numQuartos;
        protected int numBanheiros = numBanheiros;
        protected Pessoa proprietario = new Pessoa(nomeProprietario, cpfProprietario);
    
        public float MetragemQuadrada
        {
            get { return metragemQuadrada; }
            set { metragemQuadrada = value > 10 ? value : 10; }
        }
        public int NumQuartos
        {
            get { return numQuartos;}
            set { numQuartos = value > 0 ? value : 1; }
        }
        public int NumBanheiros
        {
            get { return numBanheiros;}
            set { numBanheiros = value > 0 ? value : 1; }
        }
        public Pessoa Proprietario
        {
            get { return proprietario;}
            set { proprietario = value != null ? value : throw new ArgumentNullException("Proprietario não pode ser nulo"); }
        }

    }
}