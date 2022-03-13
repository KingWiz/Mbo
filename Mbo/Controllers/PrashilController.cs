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
        public ActionResult SaveData(Employee Employee)
        {
            db.Employees.Add(Employee);
            db.SaveChanges();
            return RedirectToAction("FormWork");
        }
    }
}