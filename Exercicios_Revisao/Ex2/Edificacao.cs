using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Revisao.Ex2
{
    public abstract class Edificacao(float metragemTotal, string endereco, string nomeEng, string cpfEng, int creaEng)
    {
        protected float metragemTotal = metragemTotal;
        protected string endereco = endereco;
        protected Engenheiro responsavel = new Engenheiro(nomeEng, cpfEng, creaEng);
        protected List<UnidadeResidencial> unidades = [];
        public float MetragemTotal
        {
            get { return metragemTotal; }
            set { metragemTotal = value;}
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value;}
        }
        public Engenheiro Responsavel
        {
            get { return responsavel; }
            set { responsavel = value;}
        }
        public List<UnidadeResidencial> Unidades
        {
            get { return unidades; }
        }
        public virtual bool CadastrarUnidade(UnidadeResidencial novaUnid)
        {
            try
            {
                unidades.Add(novaUnid);
                return true;
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("" + ex.Message);
                return false;
            }
        }
        public abstract string DescricaoImovel();
    }
}