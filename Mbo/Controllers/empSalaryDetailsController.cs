using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mbo.Models;

namespace Mbo.Controllers
{
    public class empSalaryDetailsController : Controller
    {
        MBOEntities db = new MBOEntities();
        // GET: empSalaryDetails
        public ActionResult empSalaryDetails()
        {
            var employee_salary_details = db.employee_salary_details.ToList();
            return View(employee_salary_details);
        }
        public ActionResult esdCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult esdCreate(employee_salary_details employee_Salary_Details)
        {
            db.employee_salary_details.Add(employee_Salary_Details);
            db.SaveChanges();
            return RedirectToAction("FormWork","Prashil");
        }

    }
}
