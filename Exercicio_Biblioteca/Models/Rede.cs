using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_Biblioteca.Models.Library;
using Exercicio_Biblioteca.Models.User;

namespace Exercicio_Biblioteca.Models
{
    public class Rede(string nome)
    {
        private string _nome = nome;
        private List<Biblioteca> _bibliotecas= new List<Biblioteca>();
        private List<Funcionario> _funcionarios= new List<Funcionario>();

        public string Nome
        {
            get { return _nome; }
            set { _nome = value != null && value.Length > 1 ? value : _nome; }
        }
        public List<Biblioteca> Bibliotecas
        {
            get { return _bibliotecas; }
            set { _bibliotecas = value; }
        }
        public List<Funcionario> Funcionarios
        {
            get { return _funcionarios; }
            set { _funcionarios = value; }
        }

        public void AddFuncionario(Biblioteca biblioteca, Funcionario funcionario) => biblioteca.Funcionarios?.Add(funcionario);
        public void RemoveFuncionario(Biblioteca biblioteca, Funcionario funcionario) => biblioteca.Funcionarios?.Remove(funcionario);
        public void AddBiblioteca(Biblioteca biblioteca) => Bibliotecas.Add(biblioteca);
        public void RemoveBiblioteca(Biblioteca biblioteca) => Bibliotecas.Remove(biblioteca);

    }
}