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
        public ActionResult Services()
        {
            List<Employee> all_data = db.Employees.ToList();
            
            return View(all_data);
        }
    }
}