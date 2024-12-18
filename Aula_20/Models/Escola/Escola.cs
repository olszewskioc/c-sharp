using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20.Models.Escola
{
    public class Escola
    {
        private Aluno _aluno;
        private Professor _professor;

        public Escola(string NomeEstudante) => _aluno = new Aluno(NomeEstudante);

        public void ContratarProfessor(Professor professor) => _professor = professor;
        
        public void Info()
        {
            Console.WriteLine($"Nome do Aluno: {_aluno.Nome}");
            Console.WriteLine($"Nome do Professor: {_professor.Nome}");
            _professor.Ensinar();
        }
    }
}