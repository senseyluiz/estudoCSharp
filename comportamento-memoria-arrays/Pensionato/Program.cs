using System;
using System.Globalization;

namespace Pensionato;

class Program
{
  public static void Main(string[] args)
  {
    Console.Write("Quantos quartos serão alugados? ");
    int qtde = int.Parse(Console.ReadLine());



    Estudante[] Quartos = new Estudante[10];

    for(int i = 0; i < qtde; i++)
    {
      Console.WriteLine($"Aluguel #{i+1}");
      Console.Write("Nome: ");
      string nome = Console.ReadLine();

      Console.Write("Email: ");
      string email = Console.ReadLine();

      Console.Write("Quarto: ");
      int quarto = int.Parse(Console.ReadLine());

      Quartos[quarto] = new Estudante(nome, email);
    }

    for (int i = 0; i < 10; i++)
    {
      if (Quartos[i] != null)
      {        
        Console.WriteLine($"{i}: {Quartos[i]} ");
      }
    }  
    
  }
}