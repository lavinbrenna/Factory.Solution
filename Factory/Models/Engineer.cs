using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer 
  {
    public Engineer()
    {
      this.joinEntities = new HashSet<EngineerMachine>();
    }
    public int EngineerId {get;set;}
    public string Name {get;set;}
    public List<string> Certifications {get;set;}
    public DateTime LicenseRenewal {get;set;}
    public string Location {get;set;}
  }
}