using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pratica_de_cs2.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno) {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados() {
            int quantidadeAlunos = Alunos.Count;
            return quantidadeAlunos;
            // OR return Alunos.Count;
        }

        public bool RemoverAuleno(Pessoa aluno) {
            return Alunos.Remove(aluno);
        }
    }
}