using pratica_de_cs2.Models;

Pessoa pessoa1 = new Pessoa();

Console.WriteLine("Digite o nome:");
pessoa1.Nome = Console.ReadLine();

Console.WriteLine("Digite o sobrenome:");
pessoa1.Sobrenome = Console.ReadLine();

Console.WriteLine("Digite sua idade:");
pessoa1.Idade = Convert.ToInt32(Console.ReadLine());
pessoa1.Apresentar();