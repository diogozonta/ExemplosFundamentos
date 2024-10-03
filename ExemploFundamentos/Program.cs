using System.ComponentModel;
using ExemplosFundamentos.Common.Models;

Pessoa pessoa = new Pessoa();

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//   Console.Clear();
//   Console.WriteLine("Escolhe uma opção: ");
//   Console.WriteLine("1 - Cadastrar usuário");
//   Console.WriteLine("2 - Buscar usuário");
//   Console.WriteLine("3 - Deletar usuário");
//   Console.WriteLine("4 - Encerrar o programa");
//   opcao = Console.ReadLine();

//   switch(opcao)
//   {
//     case "1":
//       Console.WriteLine("Cadastro de usuário");
//       break;
    
//     case "2":
//       Console.WriteLine("Pesquisa de usuário");
//       break;

//     case "3":
//       Console.WriteLine("Exclusão de usuário");
//       break;

//     case "4":
//       exibirMenu = false;
//       break;
//   }
// }

Console.WriteLine("Programa finalizado com sucesso!");

// int soma = 0, numero = 0;

// do
// {
//   Console.WriteLine("Digite um número (0 para sair): ");
//   numero = Convert.ToInt32(Console.ReadLine());
//   soma += numero;

// } while (numero != 0);

// Console.WriteLine($"A soma total dos números é: {soma}");

// int numero = 5;
// int contador = 1;

// while(contador <= 10)
// {
//   Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//   contador++;
// }

// int numero = 5;

// for(int contador = 1; contador <= 10; contador++)
// {
//   Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// Calculadora calc = new Calculadora();

// // calc.Somar(10, 30);
// // calc.Substrair(10, 50);
// // calc.Multiplicar(15, 45);
// // calc.Dividir(2, 2);
// // calc.Potencia(5, 5);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

// Console.WriteLine("O aluno possui pressença média? (s/n) ");
// string presencaMinima = Console.ReadLine().ToUpper();
// Console.WriteLine("Qual a nota do aluno? ");
// int nota = Convert.ToInt32(Console.ReadLine());

// if (presencaMinima == "S" && nota >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }

// Console.WriteLine("Qual a sua idade? ");
// int idade = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Você possuí autorização? (s/n) ");
// string autorizacao = Console.ReadLine().ToUpper();

// if (idade >= 18 || autorizacao == "S")
// {
//     Console.WriteLine("Entrada permitida.");
// }
// else
// {
//     Console.WriteLine("Entrada não permitida");
// }

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;

// }

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//   Console.WriteLine("Vogal");
// }
// else
// {
//   Console.WriteLine("Não é uma vogal");
// }

// if (letra == "a")
// {
//   Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//   Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//   Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//   Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//   Console.WriteLine("Vogal");
// }
// else
// {
//   Console.WriteLine("Não é uma vogal");
// }


// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//   Console.WriteLine("Venda inválida.");
// }
// else if(possivelVenda)
// {
//   Console.WriteLine("Venda realizada.");
// }
// else
// {
//   Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }

// string a = "15-";
// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine("Conversão realizada com sucesso!");

// double a = 4 / 2 + 2;
// Console.WriteLine(a);

// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);

// Cast - Casting (converter de um tipo para outro)
// int a = Convert.ToInt32("5");


// int a = 10;
// int b = 20;

// int c = a + b;

// c -= 5;

// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);

// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80m;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Diogo";
// pessoa1.Idade = 21;
// pessoa1.Apresentar();