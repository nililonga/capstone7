using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBreak.Models;

namespace MVCBreak.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public List<Student> GetStudentByName(string x)
        {
            StudentInfoEntities DB = new StudentInfoEntities();
            List<Student> Name = (from Y in DB.Students
                                  where Y.Name.Contains(x)
                                  select Y).ToList();

            return Name;
        }
        public List<Student> GetStudentByMajor(string x)
        {
            StudentInfoEntities DB = new StudentInfoEntities();
            List<Student> Major = (from M in DB.Students
                                   where M.Major.Contains(x)
                                   select M).ToList();

            return Major;
        }
    }
}