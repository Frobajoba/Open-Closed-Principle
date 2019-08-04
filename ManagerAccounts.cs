using System;
namespace OCPLibrary
{
  public class ManagerAccounts : IAccounts
  {
    public EmployeeModel Create(IApplicantModel person)
    {
      EmployeeModel output = new EmployeeModel();

      output.FirstName = person.firstName;
      output.LastName = person.lastName;
      output.EmailAddress = $"{ person.firstName.Substring(0, 1) }{person.lastName}@acmeManager.com";

      output.IsManager = true;

      return output;
    }
  }
}