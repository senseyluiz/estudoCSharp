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
  }

}