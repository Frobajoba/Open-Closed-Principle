using System;
namespace OCPLibrary
{
  public interface IApplicantModel
  {
    string firstName { get; set; }
    string lastName { get; set; }
    IAccounts AccountProcessor { get; set; }
  }
}