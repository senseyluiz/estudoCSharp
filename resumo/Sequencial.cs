using System;
using System.Globalization;


namespace EstruturaSequencial;


public class ExerciciosSequenciais
{
  //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa.
  public void Exercicio01()
  {
    Console.WriteLine("SOMA DE DOIS NUMEROS");
    Console.WriteLine("Digite um valor inteiro para A: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um valor inteiro par B: ");
    int b = int.Parse(Console.ReadLine());
    int soma = a + b;
    Console.WriteLine("SOMA = " + soma);
    Console.WriteLine("===========================================");
  }


  /*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.
  Fórmula da área: area = π . raio 2
  Considere o valor de π = 3.14159*/
  public void Exercicio02()
  {
    Console.WriteLine("CALCULO DA AREA DE UM CIRCULO");
    Console.WriteLine("Digite o valor do raio");
    double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    double pi = 3.14159;
    double area = pi * raio * raio;

    Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
    Console.WriteLine("===========================================");
  }

/*Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/
  public void Exercicio03()
  {
    int a, b, c, d, diferenca;
    Console.WriteLine("CALCULO DA DIFERENÇA");
    Console.WriteLine("Digite um valor para A: ");
    a = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite um valor para B: ");
    b = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite um valor para C: ");
    c = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite um valor para D: ");
    d = int.Parse(Console.ReadLine());

    diferenca = a*b - c*d;
    Console.WriteLine("Diferença = " + diferenca);
    Console.WriteLine("===========================================");
  }

  /*Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.*/

  public void Exercicio04()
  {

    Console.WriteLine("SALARIO DO FUNCIONARIO");
    int idFuncionario, horasTrabalhada;
    double valorHora, salario;

    Console.WriteLine("Digite o ID do funcionário:");
    idFuncionario = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite as horas trabalhadas: ");
    horasTrabalhada = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor hora: ");
    valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    salario = horasTrabalhada * valorHora;

    Console.WriteLine("Number: " + idFuncionario);
    Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("===========================================");
  }

  /* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago. */

  public void Exercicio05()
  {
    Console.WriteLine("CALCULO DO VALOR A PAGAR");
    string[] peca1, peca2;    
    string idPeca1, idPeca2;
    int nPecas1, nPecas2;
    double valorPeca1, valorPeca2, totalPagar;

    Console.WriteLine("Digite o codigo da peça, número de peças e valor de cada peça separando por espaços");
    peca1 = Console.ReadLine().Split(" ");

    Console.WriteLine("Digite o codigo da peça2, número de peças e valor de cada peça separando por espaços");
    peca2 = Console.ReadLine().Split(" ");

    idPeca1 = peca1[0];
    nPecas1 = int.Parse(peca1[1]);
    valorPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

    idPeca2 = peca2[0];
    nPecas2 = int.Parse(peca2[1]);
    valorPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

    totalPagar = (nPecas1 * valorPeca1) + (nPecas2 * valorPeca2);

    Console.WriteLine("VALOR A PAGAR: U$ " + totalPagar.ToString("F2", CultureInfo.InvariantCulture));

    Console.WriteLine("===========================================");  
  }

  /* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
  a) a área do triângulo retângulo que tem A por base e C por altura.
  b) a área do círculo de raio C. (pi = 3.14159)
  c) a área do trapézio que tem A e B por bases e C por altura.
  d) a área do quadrado que tem lado B.
  e) a área do retângulo que tem lados A e B. */

  public void Exercicio06()
  {
    Console.WriteLine("CALCULA AREA");
    float a, b, c, areaTriangulo, areaTrapezio, areaQuadrado, areaRetangulo;

    double areaCirculo, pi = 3.14159;

    Console.WriteLine("Digite um valor para A: ");
    a = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Digite um valor para B: ");
    b = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Digite um valor para C: ");
    c = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    areaTriangulo = (a * c) / 2;
    areaCirculo = pi *  c * c;
    areaTrapezio = ((b + a) * c) / 2;
    areaQuadrado = b * b;
    areaRetangulo = a * b;

    Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("RETATNGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
  }
}