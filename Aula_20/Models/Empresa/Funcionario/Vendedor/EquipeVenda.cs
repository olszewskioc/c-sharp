using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20.Models.Empresa.Funcionario.Vendedor
{
    public class EquipeVenda(string nome)
    {
        private string _nome = nome;

        public string Nome
        {
            get => _nome; 
            set => _nome = value ?? _nome;
        }
    }
}