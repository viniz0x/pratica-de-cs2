﻿using System.Data.Common;
using System.Diagnostics.Contracts;
using System.Reflection;
using System.Runtime.CompilerServices;
using pratica_de_cs2.Models;
using Newtonsoft.Json; //Usando o pacote



string conteudoArquivo = File.ReadAllText("Files/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda) {
    Console.WriteLine($"Id: {venda.Id},\nProduto: {venda.Produto},\n" +
                        $"Preço: {venda.Preco},\nData: {venda.DataVenda.ToString("dd/MM/yyyy - HH:mm")}");
    Console.WriteLine("-----------------------------------------");
}












// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda venda1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda venda2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(venda1);
// listaVendas.Add(venda2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented); //Ex. de serialização de acordo as orientações de uso do pacote

// File.WriteAllText("Files/vendas.json", serializado);

// Console.WriteLine(serializado);
// //https://codebeautify.org/jsonviewer - Site para validar o formato do .json













// int numero = 20;
// bool ehPar = false;

// //IF Ternário
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));

// //IF Normal 
// if(numero % 2 == 0) {
//     Console.WriteLine($"O número {numero} é par");
// } else {
//     Console.WriteLine($"O número {numero} é ímpar");
// }










// //Descontrutor
// Pessoa p1 = new Pessoa("Pedro", "Vinícius", 20);
// (string nome, string sobrenome, int idade) = p1;

// Console.WriteLine($"Nome: {nome}, Sobrenome: {sobrenome}, Idade: {idade}");











// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Files/arquivoLeitura.txt");

// if (sucesso) {
//     // Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);

//     foreach (string linha in linhasArquivo) {
//         Console.WriteLine(linha);
//     }
// } else {
//     Console.WriteLine("Erro ao ler o arquivo.");
// }








// //Obs: não á necessidade das informações após o tipo
// (int Id, string Nome, string Sobrenome, decimal Altura) variavelTupla = (1, "Pedro Vinícius", "Nascimento", 1.83M);

// // //desvantagem é não poder apontar do que se trata ou nomear os tipos como na sintaxe de cima
// // ValueTuple<int, string, string, decimal> outraSintaxeTupla = (1, "Pedro Vinícius", "Nascimento", 1.83M);
// // var outroOutroSintaxeTupla = Tuple.Create(1, "Pedro Vinícius", "Nascimento", 1.83M);



// Console.WriteLine($"Id: {variavelTupla.Item1}");
// Console.WriteLine($"Nome: {variavelTupla.Item2}");
// Console.WriteLine($"Sobrenome: {variavelTupla.Item3}");
// Console.WriteLine($"Altura: {variavelTupla.Item4}");









// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// foreach (var PercorrerDictionary in estados) {
//     Console.WriteLine($"Chave: {PercorrerDictionary.Key}, Valor: {PercorrerDictionary.Value}");
// }

// Console.WriteLine("---------------------------");

// estados.Remove("BA"); //Removação
// estados["SP"] = "Sao Paulo - Sem ascento"; //Alteração de valor

// foreach (var PercorrerDictionary in estados) {
//     Console.WriteLine($" Chave: {PercorrerDictionary.Key}, Valor: {PercorrerDictionary.Value}");
// }


// //Criando sistema forá do curso para armazenar nome de estados

// bool VerificandoString = false;
// string AdicionarEstado = string.Empty; //Para utilizar o valor da variável dentro e forá do try


// //Obs: Essa foi uma função feita apenas para testa try e cath, eles são considerados Power para uma situação como essa.
// do {
//     try {
//         Console.WriteLine("\nInforme a sigla do estado com apenas duas letras");
//         AdicionarEstado = Console.ReadLine().ToUpper();

//         if (AdicionarEstado.Length == 2 && char.IsLetter(AdicionarEstado[0]) &&char.IsLetter(AdicionarEstado[1])) {
//             VerificandoString = true;
//         } else {
//             throw new Exception("Você não seguiu o padrão solicitado");
//         }

//     } catch (Exception invalid) {
//         Console.WriteLine("Informações do erro: " + invalid.Message);
//     }
// } while (!VerificandoString);

// if (estados.ContainsKey(AdicionarEstado)) {
//     Console.WriteLine($"O estado {AdicionarEstado} já existe");
// } else {
//     estados.Add(AdicionarEstado, "");
// }

// Console.WriteLine("Informe o nome do estado;");
// estados[AdicionarEstado] = Console.ReadLine();

// Console.WriteLine("---------------------------");
// foreach (var PercorrerDictionary in estados) {
//     Console.WriteLine($" Chave: {PercorrerDictionary.Key}, Valor: {PercorrerDictionary.Value}");
// }
// Console.WriteLine("---------------------------");












// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha) {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha) {
//     Console.WriteLine(item);
// }










// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila) {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// Console.WriteLine($"\nInforme um valor de entrada");


// // Sistema feito forá do curso para validar o valor inteiro ao entrar na lista sem encerrar o programa!
// bool EnterVefification = false;

// do {

//     try {
//         fila.Enqueue(Convert.ToInt32(Console.ReadLine()));
//         EnterVefification = true;

//     } catch (Exception ValorIncorreto) {
//         Console.WriteLine("Erro: [O valor informado deve ser um número inteiro]");
//         Console.WriteLine($"Mensagem da Exceção {ValorIncorreto.Message}");
//         }

// } while (!EnterVefification);

// Console.WriteLine($"\nAtuais conteúdos da lista: ");
// foreach (int item in fila) {
//     Console.WriteLine(item);
// }







//new ExemploExececao().Metodo1();










// try { //try = tente "fazer alguma coisa"
//     string[] linhas = File.ReadAllLines("File/arquivoLeitura.txt");

//     foreach (string linha in linhas) {
//         Console.WriteLine(linha);
//     }
// } catch (Exception ex) { //Capture a exceção
//     Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
// }

// Console.WriteLine("Chegou até aqui");










// using System.Globalization; //Definindo cultura do sistema
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); //Ajustando cultura do sistema

// decimal valorMonetario = 1582.40M;
// Console.WriteLine(valorMonetario.ToString("N8")); // Formatação personalizada

// Console.WriteLine($"{valorMonetario:C}"); //Formatação em moeda (:C)

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("es-US")));


// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P")); //Definindo formatação em porcentagem


// int numero = 15062004;
// Console.WriteLine(numero.ToString("##/##/####")); //Definindo formatação Ex. Data


// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); //Formatação de DateTime
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());


// string dataString = "2024-06-15 06:30";

// bool sucesso = DateTime.TryParseExact(dataString, 
//                         "yyyy-MM-dd HH:mm", 
//                         CultureInfo.InvariantCulture, 
//                         DateTimeStyles.None, out DateTime data2);

// Console.WriteLine(data); //Exibindo a data convertida de forma segura

// if (sucesso) {
//     Console.WriteLine($"Conversão feita com sucesso! Data: {data2}");
// } else {
//     Console.WriteLine($"Conversão falhou! {data2} Não é válida.");
// }










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