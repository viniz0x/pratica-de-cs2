using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pratica_de_cs2.Models
{
    public class Pessoa
    {
        //Construtores
        public Pessoa() {
            
        }

        public Pessoa(string nome, string sobrenome, int idade) {
            Nome = nome; //Propriedade recebe parametro
            Sobrenome = sobrenome; //Propriedade recebe parametro
            Idade = idade; //Propriedade recebe parametro
        }

        public void Deconstruct(out string nome, out string sobrenome, out int idade) {
            nome = Nome;
            sobrenome = Sobrenome;
            idade = Idade;
        }

        private string _nome;
        private string _sobrenome;
        private int _idade;

        public string Nome { 
            get => _nome;

            set {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio.");
                }
            _nome = value;
            }
        }

        public string Sobrenome {
            get => _sobrenome;

            set {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio.");
                }
            _sobrenome = value;
            }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade { 

            get => _idade;
            
            set {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não pode ser negativa.");
                }
                _idade = value;
            } 
        }
        
        public void Apresentar() {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }

        internal void Deconstruct(out string nome, out string sobrenome)
        {
            throw new NotImplementedException();
        }
    }
}