using System;

namespace Introducao;

class Program
{ 
  static void Main()  
  {

    // EXERCICIO 01

    Console.WriteLine("EXERCICIO 01");

    Pessoa pessoa1, Pessoa2;

    pessoa1 = new Pessoa();
    Pessoa2 = new Pessoa();

    pessoa1.Nome = "Maria";
    pessoa1.Idade = 17;

    Pessoa2.Nome = "João";
    Pessoa2.Idade = 16;

    Console.WriteLine("Dados da primeira pessoa: ");
    Console.WriteLine("Nome: " + pessoa1.Nome);
    Console.WriteLine("Idade: " + pessoa1.Idade);
    Console.WriteLine("--------------------------------");

    Console.WriteLine("Dados da segunda pessoa: ");
    Console.WriteLine("Nome: " + Pessoa2.Nome);
    Console.WriteLine("Idade: " + Pessoa2.Idade);

    Console.WriteLine("==================================");

    // EXERCICIO 02

    Console.WriteLine("EXERCICIO 02");

    Funcionario funcionario1, funcionario2;

    funcionario1 = new Funcionario();
    funcionario2 = new Funcionario();

    funcionario1.Nome = "Carlos Silva";
    funcionario1.Salario = 6300.00;

    funcionario2.Nome = "Ana Marques";
    funcionario2.Salario = 6700.00;

    Console.WriteLine("Nome: " + funcionario1.Nome);
    Console.WriteLine("Salário" + funcionario1.Salario);
    Console.WriteLine("--------------------------------");
    Console.WriteLine("Nome: " + funcionario2.Nome);
    Console.WriteLine("Salario: " + funcionario2.Salario);

  }
}