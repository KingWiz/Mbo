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

            return View();
        }
        
    }
}