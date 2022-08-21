using System;
using System.Globalization;


namespace Condicionais;

public class ExerciciosCondicionais
{
  public void Exercicio01()
  {
    /* Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não. */

    int num;

    Console.WriteLine("POSITIVO OU NEGATIVO");
    Console.WriteLine("Digite um numero inteiro positivo ou negativo: ");
    num = int.Parse(Console.ReadLine());

    if (num < 0) {
      Console.WriteLine("NEGATIVO");
    }

    if (num > 0) {
      Console.WriteLine("NÃO NEGATIVO");
    }

    Console.WriteLine("=======================================================");
  }

    // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
  public void Exercicio02()
  {
    Console.WriteLine("PAR OU IMPAR");
    Console.WriteLine("Digite um número inteiro");
    int num = int.Parse(Console.ReadLine());

    if (num % 2 == 0) {
      Console.WriteLine("PAR");
    }
    else {
      Console.WriteLine("ÍMPAR");
    }
    Console.WriteLine("=======================================================");
  }

  /*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.*/

  public void Exercicio03()
  {
    Console.WriteLine("VERIFICA MÚLTIPLOS");
    int a, b;
    Console.WriteLine("Digite um número inteiro para A: ");
    a = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite um número inteiro para B: ");
    b = int.Parse(Console.ReadLine());

    if (a % b == 0 || b % a == 0){
      Console.WriteLine("São Múltiplos");
    }
    else {
      Console.WriteLine("Não são Múltiplos");
    }
    Console.WriteLine("=======================================================");
  }


  /*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/
  public void Exercicio04()
  {
    Console.WriteLine("DURAÇÃO DO JOGO");
    int horaInicial, horaFinal, duracao;
    string[] horas;

    Console.WriteLine("Digite a hora inicial e a hora final separado por espaço: ");
    horas = Console.ReadLine().Split(" ");
    horaInicial = int.Parse(horas[0]);
    horaFinal = int.Parse(horas[1]);

    if (horaInicial < horaFinal){
      duracao = horaFinal - horaInicial;
    }
    else {
      duracao = 24 - horaInicial + horaFinal;
    }

    Console.WriteLine($"O Jogo durou {duracao} Hora(s)");
    Console.WriteLine("=======================================================");
  }

  /* Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar. */

  public void Exercicio05()
  {
    Console.WriteLine("VALOR A PAGAR");
    Console.WriteLine("CÓDIGO    ESPECIFICAÇÃO       PREÇO");
    Console.WriteLine("-------------------------------------");
    Console.WriteLine(" 1        Cachorro Quente     R$ 4.00");
    Console.WriteLine(" 2        X-Salada            R$ 4.50");
    Console.WriteLine(" 3        X-Bacon             R$ 5.00");
    Console.WriteLine(" 4        Torrada Simples     R$ 2.00");
    Console.WriteLine(" 5        Refrigerante        R$ 1.50");

    Console.WriteLine("Digite o código e a quantidade do produto separado por espaço");
    string[] dados = Console.ReadLine().Split(" ");
    int cod = int.Parse(dados[0]);
    int qtde = int.Parse(dados[1]);
    double totalPagar, precoProduto = 0.00;

    if( cod == 1){
      precoProduto = 4.00;
    }
    else if( cod == 2){
      precoProduto = 4.50;
    }
    else if( cod == 3){
      precoProduto = 5.00;
    }
    else if( cod == 4){
      precoProduto = 2.00;
    }
    else if( cod == 5){
      precoProduto = 1.50;
    }

    totalPagar = qtde * precoProduto;

    Console.WriteLine("TOTAL: R$ " + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("=======================================================");
  }

  /* Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”. */

  public void Exercicio06()
  {
    Console.WriteLine("INTERVALO DE NUMEROS");
    Console.WriteLine("Digite um número entre 0 e 100: ");
    double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (num >= 0 && num <= 100){
      if(num <= 25){
      Console.WriteLine("Intervalo [ 0, 25 ]");
      }
      else if(num <= 50){
        Console.WriteLine("Intervalo [ 25, 50 ]");
      }
      else if(num <= 75){
        Console.WriteLine("Intervalo [ 50, 75 ]");
      }

      else if(num <= 100){
        Console.WriteLine("Intervalo [ 75, 100 ]");
      }
    }    
    else{
      Console.WriteLine("Fora de intervalo");
    }
    Console.WriteLine("=======================================================");    
  }

    /* Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
    Se o ponto estiver na origem, escreva a mensagem “Origem”.
    Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
    situação. */

    public void Exercicio07()
    {
      Console.WriteLine("COORDENADAS");
      Console.WriteLine("Digite dois numeros separados por espaço:  ");
      string[] valores = Console.ReadLine().Split(" ");
      double x = float.Parse(valores[0], CultureInfo.InvariantCulture);
      double y = float.Parse(valores[1], CultureInfo.InvariantCulture);

      Console.WriteLine("X: " + x.ToString("F1", CultureInfo.InvariantCulture) + " Y: " + y.ToString("F1", CultureInfo.InvariantCulture));

      if ( x == 0.0 && y == 0.0){
        Console.WriteLine("ORIGEM");
      }

      if(x > 0 || x < 0 && y == 0.0){
        Console.WriteLine("Eixo X");
      }

      if(y > 0 || y < 0 && y == 0.0){
        Console.WriteLine("Eixo Y");
      }

      if (x > 0 && y > 0){
        Console.WriteLine("Q1");
      }

      if (x < 0 && y > 0 ){
        Console.WriteLine("Q2");
      }

      if (x < 0 && y < 0){
        Console.WriteLine("Q3");
      }

      if (x > 0 && y < 0){
        Console.WriteLine("Q4");
      }
      Console.WriteLine("=======================================================");
    }

    /* Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
    
    Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo. 

    RENDA                                 IMPOSTO DE RENDA
    de 0.00 à R$ 2000.00 ------------------- Isento
    de R$ 2000.01 até R$ 3000.00--------- 8 %
    de R$ 3000.01 até R$ 4500.00--------- 18 %
    acima de R$ 4500.00------------------ 28 %
    
    Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com duas casas decimais.*/

    public void Exercicio08()
    {
      Console.WriteLine("CALCULA IMPOSTO");
      Console.WriteLine("Digite o valor do salário:  ");
      double salario = double.Parse(Console.ReadLine());

      double imposto = 0.00;
      
      if(salario < 2000){
        imposto = 0.00;
      }
      else if(salario < 3000){
        imposto = (3000 - salario) * 0.08;
      }
      else if (salario < 4500.00){
        imposto = (salario - 3000) * 0.18 + (1000 * 0.08);
      }
      else{
        imposto = (salario - 4500) * 0.28 + (4500 - 3000) * 0.18 + (1000 * 0.08);
      }

      if(imposto == 0.00){
        Console.WriteLine("ISENTO");
      }else{
        Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
      }

      Console.WriteLine("=======================================================");
    }
}