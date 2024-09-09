using pratica_de_cs2.Models;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = Console.ReadLine();
pessoa1.Idade = Convert.ToInt32(Console.ReadLine());
pessoa1.Apresentar();