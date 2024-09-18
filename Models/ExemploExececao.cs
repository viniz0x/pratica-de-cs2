using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace pratica_de_cs2.Models
{
    public class ExemploExececao
    {
        public void Metodo1() {
            try {
                Metodo2();
            } catch (Exception ex) {
                Console.WriteLine($"Execeçõa tradada {ex.Message}");
            }
        }

        public void Metodo2() {
            Metodo3();
        }

        public void Metodo3() {
            Metodo4();
        }

        public void Metodo4() {
            throw new Exception("Ocorreu uma Exceção");
        }
    }
}