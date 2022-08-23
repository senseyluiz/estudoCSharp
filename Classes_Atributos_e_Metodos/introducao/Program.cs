using System;
using System.Globalization;

namespace Introducao;

class Program
{ 
  static void Main()  
  {

    // EXERCICIO 01
    //Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha

    Console.WriteLine("EXERCICIO 01");

    Pessoa pessoa1, Pessoa2;
    string maisVelha;

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

    if(pessoa1.Idade > Pessoa2.Idade){
      Console.WriteLine("Pessoa mais velha ====> " + pessoa1.Nome);
    }
    else{
      Console.WriteLine("Pessoa mais velha ====> " + Pessoa2.Nome);
    }

    Console.WriteLine("==================================");

    // EXERCICIO 02

    Console.WriteLine("EXERCICIO 02");

    Funcionario funcionario1, funcionario2;
    double media;

    funcionario1 = new Funcionario();
    funcionario2 = new Funcionario();

    funcionario1.Nome = "Carlos Silva";
    funcionario1.Salario = 6300.00;

    funcionario2.Nome = "Ana Marques";
    funcionario2.Salario = 6700.00;

    Console.WriteLine("Nome: " + funcionario1.Nome);
    Console.WriteLine("Salário: R$ " + funcionario1.Salario.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("--------------------------------");
    Console.WriteLine("Nome: " + funcionario2.Nome);
    Console.WriteLine("Salario: R$ " + funcionario2.Salario.ToString("F2", CultureInfo.InvariantCulture));

    media = (funcionario1.Salario + funcionario2.Salario) / 2.0;

    Console.WriteLine("Média salarial ===> R$ " + media.ToString("F2",CultureInfo.InvariantCulture));

    Console.WriteLine("==================================");

  }
}