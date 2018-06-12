using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone6.Models;

namespace Capstone6.Controllers
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

        public ActionResult Registration(User info)
        {
            TaskListEntities ORM = new TaskListEntities();
            if (ModelState.IsValid)
            {
                ORM.Users.Add(info);
                ORM.SaveChanges();
            }
            
            return View();
        }
        public ActionResult TaskList (Task data)
        {
            TaskListEntities ORM = new TaskListEntities();
            if (ModelState.IsValid)
            {
                ORM.Tasks.Add(data);
                ORM.SaveChanges();
            }
            
            return View();
        }
    }
}