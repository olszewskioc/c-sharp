using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20.Models.Empresa.Enderecos
{
    public class Estado(string nome, string sigla)
    {
        private string _nome = nome;
        private string _sigla = sigla;

        public string Nome { get { return _nome;} set { _nome = value;} }
        public string Sigla { get { return _sigla;} set { _sigla = value;} }
    }
}