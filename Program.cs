using pratica_de_cs2.Models;

Pessoa pessoa1 = new Pessoa();

Pessoa p1 = new Pessoa(nome:"Leonardo", sobrenome:"Buta", idade:13);
Pessoa p2 = new Pessoa(nome:"Ana", sobrenome:"Clara", idade:16);
//Não á necessidade mas é uma boa prática -> (|nome:|"Leonardo"...)


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();






// Console.WriteLine("Digite o nome:");
// pessoa1.Nome = Console.ReadLine();

// Console.WriteLine("Digite o sobrenome:");
// pessoa1.Sobrenome = Console.ReadLine();

// Console.WriteLine("Digite sua idade:");
// pessoa1.Idade = Convert.ToInt32(Console.ReadLine());
// pessoa1.Apresentar();