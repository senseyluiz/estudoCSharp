using System;
using System.Globalization;
using System.Collections.Generic;

namespace Empresa;

class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("How many employees will be registered? ");
    int qtde = int.Parse(Console.ReadLine());

    List<Employee> employees = new List<Employee>();

    for (int i = 0; i< qtde; i++)
    {

      Console.WriteLine($"Employe: #{i+1}");
      Console.Write("ID: ");
      int id = int.Parse(Console.ReadLine());

      Console.Write("Name: ");
      string name = Console.ReadLine();

      Console.Write("Salary: ");
      double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      employees.Add(new Employee(id, name, salary));
      
    }

    Console.Write("Enter the employee id that will have salary increase: ");
    int idEmployee = int.Parse(Console.ReadLine());

    


    if(employees.Find(x => x.Id == idEmployee) != null){

      Console.Write("Enter the percentage: ");
      double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.WriteLine("Updated list of employees: ");

      foreach (var item in employees)
      {
        if(item.Id == idEmployee)
        {
          item.increaseSalary(percentage);
        }
      }

    }else{
      Console.WriteLine("This id does note exist!");
    }
    

    foreach (var item in employees)
    {
      Console.WriteLine(item);
    }
  }
}

