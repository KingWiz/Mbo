using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mbo.Models;

namespace Mbo.Controllers
{
    public class PrashilController : Controller
    {
        MBOEntities db = new MBOEntities();
        // GET: Default
        public ActionResult FormWork()
        {
            List<Employee> all_data = db.Employees.ToList();
            
            return View(all_data);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit(int empid)
        {
            Employee data = db.Employees.Find(empid); //find data using primary key
            //Employee data = db.Employees.FirstOrDefault(x => x.empID == id);
            return View(data);
        }
        public ActionResult UpdateData(Employee Employee)
        {
            Employee update = db.Employees.Find(Employee.empID);
            update.empName = Employee.empName;
            update.empAddress = Employee.empAddress;
            update.empContact = Employee.empContact;
            db.Entry(update).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("FormWork");
        }
        public ActionResult SaveData(Employee Employee)
        {
            db.Employees.Add(Employee);
            db.SaveChanges();
            return RedirectToAction("FormWork");
        }
    }
}