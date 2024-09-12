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

        public void ListarAlunos(){
            Console.WriteLine($"Alunos do curso de: {Nome}");

            for (int count = 0; count < Alunos.Count; count++) {

                // string texto = "N° " + count + " - " + Alunos[count].NomeCompleto; 
                string texto = $"N° {count} - {Alunos[count].NomeCompleto}"; //Interpolação
                Console.WriteLine(texto);
            }
            // foreach(Pessoa aluno in Alunos) {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }
        }    
    }
}