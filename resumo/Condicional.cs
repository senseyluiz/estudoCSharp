using System;


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

}