using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Revisao.Ex2
{
    public class Predio(string nome, int numAndares, int apPorAndar, float metragemTotal, string endereco, string nomeEng, string cpfEng, int creaEng) 
    : Edificacao(metragemTotal, endereco, nomeEng, cpfEng, creaEng)
    {
        private string _nome = nome;
        private int _numAndares = numAndares;
        private int _apPorAndar = apPorAndar;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public int NumAndares
        {
            get { return _numAndares;}
            set { _numAndares = value;}
        }
        public int ApPorAndar
        {
            get { return _apPorAndar;}
            set { _apPorAndar = value;}
        }
        public override string DescricaoImovel()
        {
            int i = 1;
            string text = $"Prédio {Nome}.\nSituado a {Endereco}\nÁrea Total: {MetragemTotal} m²\n";
            text += $"Responsável: {Responsavel.Nome}/{Responsavel.Crea}\nNúmero de andares: {NumAndares}\nNúmero de Ap. por andar: {ApPorAndar}\n";
            foreach (var unidade in Unidades)
            {
                text += $"Unidade {i}\nPropriedade de {unidade.Proprietario.Nome}";
                text += $"Possui {unidade.MetragemQuadrada}, {unidade.NumQuartos} quartos e {unidade.NumBanheiros} banheiros\n";
                i++;
            }
            return text;
        }
    }
}