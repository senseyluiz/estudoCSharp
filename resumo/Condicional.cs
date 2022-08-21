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
  }

}