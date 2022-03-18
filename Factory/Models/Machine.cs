using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int MachineId {get;set;}
    public string Name {get;set;}
    public string Type{get;set;}
    public DateTime InspectionDate{get;set;}
    public string IsOperating {get;set;}
    public string IsMalfunctioning {get;set;}
    public string IsBeingRepaired {get;set;}

    public string Location {get;set;}
    public virtual ICollection<EngineerMachine> JoinEntities{get;set;}

  }
  
}