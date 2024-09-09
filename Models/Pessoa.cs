using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pratica_de_cs2.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome { 

            get => _nome.ToUpper();

            set {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio.");

                }
            _nome = value;
            }
        }
        public int Idade { get; set; }
        public void Apresentar() {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}