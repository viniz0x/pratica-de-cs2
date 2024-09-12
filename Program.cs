using pratica_de_cs2.Models;
using System.Globalization; //Definindo cultura do sistema
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); //Ajustando cultura do sistema

decimal valorMonetario = 1582.40M;
Console.WriteLine(valorMonetario.ToString("N8")); // Formatação personalizada

Console.WriteLine($"{valorMonetario:C}"); //Formatação em moeda (:C)

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("es-US")));


double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P")); //Definindo formatação em porcentagem


int numero = 15062004;
Console.WriteLine(numero.ToString("##/##/####")); //Definindo formatação Ex. Data


DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); //Formatação de DateTime
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());


string dataString = "2024-06-15 06:30";

bool sucesso = DateTime.TryParseExact(dataString, 
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, out DateTime data2);

Console.WriteLine(data); //Exibindo a data convertida de forma segura

if (sucesso) {
    Console.WriteLine($"Conversão feita com sucesso! Data: {data2}");
} else {
    Console.WriteLine($"Conversão falhou! {data2} Não é válida.");
}










// int numero1 = 10;
// int numero2 = 20;

// int resultado = numero1 + numero2;
// Console.WriteLine(resultado);










// Pessoa pessoa1 = new Pessoa();

// Pessoa p1 = new Pessoa(nome:"Leonardo", sobrenome:"Buta", idade:13);
// Pessoa p2 = new Pessoa(nome:"Ana", sobrenome:"Clara", idade:16);
// //Não á necessidade mas é uma boa prática -> (|nome:|"Leonardo"...)


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();










// Console.WriteLine("Digite o nome:");
// pessoa1.Nome = Console.ReadLine();

// Console.WriteLine("Digite o sobrenome:");
// pessoa1.Sobrenome = Console.ReadLine();

// Console.WriteLine("Digite sua idade:");
// pessoa1.Idade = Convert.ToInt32(Console.ReadLine());
// pessoa1.Apresentar();