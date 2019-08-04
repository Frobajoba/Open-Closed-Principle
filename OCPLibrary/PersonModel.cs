using System;
namespace OCPLibrary
{
  public class UserDetails : IApplicantModel
  {
    public string firstName { get; set; }
    public string lastName { get; set; }

    public IAccounts AccountProcessor { get; set; } = new Accounts();

  }
}