using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarAppNotes.Models;

namespace CarAppNotes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Models.Car> carlist = new List<Models.Car>();
            carlist.Add(new Car("Pontiac", "Aztek", 2007));
            carlist.Add(new Car("Ford", "Fusion", 2018));
            carlist.Add(new Car("Cadillac", "Escalade", 2012));
            ViewBag.CarList = carlist;
            return View();

            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult CarForm()
        {
            Car car = new Car();
            ViewBag.Car = car;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create (Car c)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Car = c;
            }
            else
            {
                return View("CarForm");
            }
        }
    }
}