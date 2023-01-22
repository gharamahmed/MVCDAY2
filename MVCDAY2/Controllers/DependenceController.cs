using Microsoft.AspNetCore.Mvc;
using MVCDAY2.Models;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVCDAY2.Controllers
{
  
    public class DependenceController : Controller
    {
        CompanyContext db;
        public DependenceController() {
            db = new CompanyContext();
        }
        public IActionResult GetAll()
        {
            List<dependent> dependents= db.Dependents.Where(e=>e.ESSN==HttpContext.Session.GetInt32("SSN")).ToList();
            return View("GetAll", dependents);
        }
        public IActionResult AddDependence(int id)
        {
            //employee emp = db.Employees.Where(e => e.SSN == id).Single();
            return View("AddDependence");
        }

        public IActionResult Add(dependent dep)
        {
            db.Dependents.Add(dep);
            db.SaveChanges();
            TempData["msg"] = "You Add one Dependent";
            return RedirectToAction("GetAll");
        }
        public IActionResult Edit(int id)
        {
            dependent dep = db.Dependents.Where(e => e.Id == id).Single();
            return View("Edit", dep);
        }
        public IActionResult Delete(int id)
        {
            dependent dep = db.Dependents.Where(e => e.Id == id).Single();
            db.Dependents.Remove(dep);
            db.SaveChanges();
            TempData["msg"] = "You Delete one Dependent";
            return RedirectToAction("GetAll");
        }
        public IActionResult Update(dependent dep)
        {
            var Olddep = db.Dependents.SingleOrDefault(e => e.Id == dep.Id);
            Olddep.Name = dep.Name;
            Olddep.Birthdate = dep.Birthdate;
            Olddep.Relationship = dep.Relationship;
            Olddep.ESSN = HttpContext.Session.GetInt32("SSN");
            db.SaveChanges();
            TempData["msg"] = "You Update one Dependent";
            return RedirectToAction("GetAll");
        }
    }

}
