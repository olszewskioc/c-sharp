using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Revisao.Ex2
{
    public class Casa(bool condominio, float metragemTotal, string endereco, string nomeEng, string cpfEng, int creaEng)
    : Edificacao(metragemTotal, endereco, nomeEng, cpfEng, creaEng)
    {
        protected bool condominio = condominio;
        public bool Condominio
        {
            get { return condominio; }
            set { condominio = value; }
        }
        public override string DescricaoImovel()
        {
            int i = 1;
            string text = $"{(condominio ? "Comdominio" : "Casa")}\nSituado a {Endereco}\nÁrea Total: {MetragemTotal} m²\n";
            text += $"Responsável: {Responsavel}\n";
            foreach (var unidade in Unidades)
            {
                text += $"Unidade {i}\nPropriedade de {unidade.Proprietario}";
                text += $"Possui {unidade.MetragemQuadrada}, {unidade.NumQuartos} quartos e {unidade.NumBanheiros} banheiros\n";
                i++;
            }
            return text;
        }
        public override bool CadastrarUnidade(UnidadeResidencial novaUnid)
        {
            return Condominio ? base.CadastrarUnidade(novaUnid) : throw new Exception("Casa não pode ter unidades");
        }
    }
}