using System;
using System.Globalization;


namespace ContaBancaria;

public class Conta 
{
  private int _nunConta;
  public string Titular { get; set;}
  public double Saldo { get; private set;}

  public Conta(int nunConta, string titular, double deposito)
  {
    _nunConta = nunConta;
    Titular = titular;
    Depositar(deposito);
  }

  public Conta(int nunConta, string titular)
  {
    _nunConta = nunConta;
    Titular = titular;
    Saldo = 0;
  }

  public void Depositar (double valor){
    Saldo += valor;
  }

  public void Retirar (double valor){
    Saldo -= valor + 5.00;
  }

  public override string ToString()
  {
    return $"Conta: {_nunConta}, Titular: {Titular}, Saldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
  }
}
