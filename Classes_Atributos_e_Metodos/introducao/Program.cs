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

    // Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.

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

    // EXERCICIO 03
    /* Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe como mostrado no projeto ao lado. */
    Console.WriteLine();
    Console.WriteLine("Exercicio 03");
    Console.WriteLine("CALCULO DO RETANGULO");
    Retangulo retangulo = new();
    Console.WriteLine("Entre com a largura e altura do retângulo: ");
    Console.Write("Altura: ");
    retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Largura: ");
    retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("ÁREA: " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("PERIMETRO " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("DIAGONAL: " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

    Console.WriteLine("==================================");

    // EXERCICIO 04
    Console.WriteLine();
    Console.WriteLine("Exercicio 04");
    Console.WriteLine("SALÁRIO DO FUNCIONÁRIO");

    FuncionarioEmpresa funcionarioEmpresa = new();
    
    Console.Write("Nome: ");
    funcionarioEmpresa.Nome = Console.ReadLine();

    Console.Write("Salário Bruto: ");
    funcionarioEmpresa.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Imposto: ");
    funcionarioEmpresa.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Funcionario: " + funcionarioEmpresa);
    Console.WriteLine();
    Console.Write("Digite a porcentagem para aumentar o salário: ");
    double aumento = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

    funcionarioEmpresa.AumentaSalario(aumento);

    Console.WriteLine("===============================================");
    Console.WriteLine(funcionarioEmpresa.SalarioBruto);
    Console.WriteLine("===============================================");
    Console.WriteLine();
    Console.WriteLine("Funcionario Atualizado: " + funcionarioEmpresa);
    Console.WriteLine("===============================================");
  }
}