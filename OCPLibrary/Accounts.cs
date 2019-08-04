using System;
using System.Collections.Generic;

namespace OCPLibrary
{


  public class Accounts : IAccounts
  {
    public EmployeeModel Create(IApplicantModel person)
    {
      EmployeeModel output = new EmployeeModel();

      output.FirstName = person.firstName;
      output.LastName = person.lastName;
      output.EmailAddress = $"{ person.firstName.Substring(0, 1) }{person.lastName}@acme.com";

      return output;
    }
  }
}