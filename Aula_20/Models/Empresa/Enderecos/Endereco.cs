using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20.Models.Empresa.Enderecos
{
    public class Endereco
    {
        private string? _rua;
        private int _numero;
        private string? _bairro;
        private string? _cep;
        private Cidade? _cidade;

        public string? Rua 
        { 
            get => _rua;
            set =>_rua = value!= null && value.Length > 1 ? value : _rua;
        }
        public int Numero
        { 
            get => _numero;
            set =>_numero = value != 0  ? value : _numero;
        }
        public string? Bairro
        { 
            get => _bairro;
            set =>_bairro = value!= null && value.Length > 1 ? value : _bairro;
        }
        public string? Cep 
        { 
            get => _cep;
            set =>_cep = value!= null && value.Length > 1 ? value : _cep;
        }
        public Cidade? Cidade 
        { 
            get => _cidade;
            set =>_cidade = value ?? _cidade;
        }

        public Endereco(string rua, int numero, string bairro, string cep, Cidade cidade)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
        }
    }
}