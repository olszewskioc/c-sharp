using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Revisao.Ex2
{
    public class CasaSobrado(int numAndares, bool condominio, float metragemTotal, string endereco, string nomeEng, string cpfEng, int creaEng)
    : Casa (condominio, metragemTotal, endereco, nomeEng, cpfEng, creaEng)
    {
        private int _numAndares = numAndares;
        public int NumAndares
        {
            get { return _numAndares;}
            set { _numAndares = value;}
        }
        public override string DescricaoImovel()
        {
            int i = 1;
            string text = $"{(condominio ? "Comdominio" : "Casa")}\nSituado a {Endereco}\nÁrea Total: {MetragemTotal} m²\n";
            text += $"Responsável: {Responsavel}\nNúmero de andares: {NumAndares}\n";
            foreach (var unidade in Unidades)
            {
                text += $"Unidade {i}\nPropriedade de {unidade.Proprietario}";
                text += $"Possui {unidade.MetragemQuadrada}, {unidade.NumQuartos} quartos e {unidade.NumBanheiros} banheiros\n";
                i++;
            }
            return text;
        }
    }
}