using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mbo.Models;

namespace Mbo.Controllers
{
    public class StdTableController : Controller
    {

        MBOEntities db = new MBOEntities();
        // GET: StdTable
        public ActionResult Index()
        {
            List<Student> all_data = db.Students.ToList();

            return View();
        }
        
        public ActionResult Create()
        {
            List<Student> all_data = db.Students.ToList();
            return View();
        }
        public ActionResult Edit(int sID)
        {
            Student data = db.Students.Find(sID); //find data using primary key
                                                  //Employee data = db.Employees.FirstOrDefault(x => x.empID == id);
            return View(data);
        }
        public ActionResult UpdateData(Student Student)
        {
            Student update = db.Students.Find(Student.sID);
            update.sName =Student.sName;
            update.sAddress = Student.sAddress;
            db.Entry(update).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("FormWork");
        }
        public ActionResult SaveStdData(Student Student)
        {
            db.Students.Add(Student);
            db.SaveChanges();
            return RedirectToAction("FormWork","Prashil");
        }
    }
}