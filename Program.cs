using System;
using OCPLibrary;
using System.Collections.Generic;

namespace EmployeeAccounts
{
  class Program
  {
    static void Main(string[] args)
    {
      List<PersonModel> applicants = new List<PersonModel>{
        new PersonModel {firstName = "James", lastName = "Cox"},
        new PersonModel {firstName = "Max", lastName = "Storr"},
        new PersonModel {firstName = "Sarah", lastName = "Healy"}
      };

      List<EmployeeModel> employees = new List<EmployeeModel>();
      Accounts accountProcessor = new Accounts();

      foreach (var person in applicants)
      {
        employees.Add(accountProcessor.Create(person));
      }

      foreach (var emp in employees)
      {
        Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive }");
      }

      Console.ReadLine();
    }
  }
}
