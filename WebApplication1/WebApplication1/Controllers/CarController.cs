using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            ViewBag.Make = "Pontiac";
            ViewBag.Plate = "G6";
            ViewBag.Year = 2007;
              
            return View();
        }
        //parameters are automaticcaaly parsed in from query string
        public ActionResult Register(string make="Benz", string plate="g wagon", int year= 1999)
        {
            ViewBag.Make = make;
            ViewBag.Plate = plate;
            ViewBag.Year = year;
            return View();
        }
    }
}