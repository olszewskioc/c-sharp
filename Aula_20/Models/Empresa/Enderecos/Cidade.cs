using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20.Models.Empresa.Enderecos
{
    public class Cidade(string nome, Estado estado)
    {
        private string _nome = nome;
        private Estado _estado = estado;

        public string Nome { get{ return _nome;} set { _nome = value;} }
        public Estado Estado { get{ return _estado;} set { _estado = value;} }


    }
}