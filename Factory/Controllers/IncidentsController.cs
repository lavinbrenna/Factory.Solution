using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Linq;

namespace Factory.Controllers
{
  public class IncidentsController: Controller
  {
    private readonly FactoryContext _db;

    public IncidentsController(FactoryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      return View(_db.EngineerMachine.ToList());
    }
    public ActionResult Create()
    {
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
      return View();
    }
    [HttpPost]
    public ActionResult Create(EngineerMachine engineerMachine)
    {
    _db.EngineerMachine.Add(engineerMachine);
    _db.SaveChanges();
    return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisEngineerMachine = _db.EngineerMachine.FirstOrDefault(engineerMachine => engineerMachine.EngineerMachineId == id);
      return View(thisEngineerMachine);
    }
    public ActionResult Edit(int id)
    {
      var thisEngineerMachine = _db.EngineerMachine.FirstOrDefault(engineerMachine => engineerMachine.EngineerMachineId == id);
      ViewBag.EngineerId = new SelectList(_db.Engineers,"EngineerId", "Name");
      return View(thisEngineerMachine);
    }
    [HttpPost]
    public ActionResult Edit(EngineerMachine engineerMachine, int EngineerId)
    {
      if(EngineerId != 0)
      {
        _db.EngineerMachine.Add(new EngineerMachine(){EngineerId = EngineerId, EngineerMachineId = engineerMachine.EngineerMachineId });
      }
      _db.Entry(engineerMachine).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}