/* Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe como mostrado no projeto ao lado. */

using System;
using System.Globalization;

namespace Introducao;

class Retangulo
{
  public double Largura;
  public double Altura;

  public double Area() {
    return Largura * Altura;
  }

  public double Perimetro(){
    return 2 * (Altura + Largura);
  }

  public double Diagonal(){
    return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
  }

}