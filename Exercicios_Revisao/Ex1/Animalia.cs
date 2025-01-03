using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Revisao.Ex1
{
    public abstract class Animalia
    {
        private readonly string _reino = "Animalia";
        private string? _filo;
        private string? _classe;
        private string? _ordem;
        private string? _familia;
        private string? _genero;
        private string? _especie;

        public string? Reino
        {
            get { return _reino; }
        }
        public string? Filo
        {
            get { return _filo; }
            set { _filo = value != null && value.Length > 0 ? value : "Desconhecido";}
        }
        public string? Classe
        {
            get { return _classe; }
            set { _classe = value != null && value.Length > 0 ? value : "Desconhecido";}
        }
        public string? Ordem
        {
            get { return _ordem; }
            set { _ordem = value != null && value.Length > 0 ? value : "Desconhecido";}
        }
        public string? Familia
        {
            get { return _familia; }
            set { _familia = value != null && value.Length > 0 ? value : "Desconhecido";}
        }
        public string? Genero
        {
            get { return _genero; }
            set { _genero = value != null && value.Length > 0 ? value : "Desconhecido";}
        }
        public string? Especie
        {
            get { return _especie; }
            set { _especie = value != null && value.Length > 0 ? value : "Desconhecido";}
        }

        public Animalia(string filo, string classe, string ordem, string familia, string genero, string especie)
        {
            Filo = filo;
            Classe = classe;
            Ordem = ordem;
            Familia = familia;
            Genero = genero;
            Especie = especie;
        }
        public abstract string ObterDescricao();
    }
}