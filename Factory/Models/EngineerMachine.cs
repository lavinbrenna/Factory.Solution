namespace Factory.Models
{
  public class EngineerMachine
  {
    public int EngineerMachineId {get;set;}
    public int MachineId{get;set;}
    public int EngineerId{get;set;}
    public string Repair {get;set;}
    public virtual Machine machine {get;set;}
    public virtual Engineer engineer {get;set;}

  }
}