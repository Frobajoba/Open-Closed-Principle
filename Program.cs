using System;
using OCPLibrary;
using System.Collections.Generic;

namespace EmployeeAccounts
{
  class Program
  {
    static void Main(string[] args)
    {
      List<IApplicantModel> applicants = new List<IApplicantModel>{         //Creating a List of people, called appliocations. 
        new PersonModel {firstName = "James", lastName = "Cox"},
        new ManagerModel {firstName = "Max", lastName = "Storr"},
        new ExecutiveModel {firstName = "Sarah", lastName = "Healy"}
      };

      List<EmployeeModel> employees = new List<EmployeeModel>();
      Accounts accountProcessor = new Accounts();

      foreach (var person in applicants)
      {
        employees.Add(person.AccountProcessor.Create(person));
      }

      foreach (var emp in employees)
      {
        Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
      }

      Console.ReadLine();
    }
  }
}
