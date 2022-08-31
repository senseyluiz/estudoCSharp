using System;
using System.Globalization;

using ContaBancaria;

Console.Write("Entre com número da Conta: ");
int nunConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Entre com o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá deposito inicial? (s/n) ");
string depositoInicial = Console.ReadLine();

Conta conta1;

if(depositoInicial == "s")
{
  Console.Write("Entre com o valor de depósito inicial: ");
  double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  conta1 = new(nunConta, titular, valor);
}
else
{
  conta1 = new(nunConta, titular);
}



Console.WriteLine("Dados da Conta: ");
Console.WriteLine(conta1);

Console.Write("Entre com um valor para depósito: ");
double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

conta1.Depositar(deposito);

Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta1);

Console.Write("Entre com um valor para saque: ");
double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta1.Retirar(saque);

Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta1);


