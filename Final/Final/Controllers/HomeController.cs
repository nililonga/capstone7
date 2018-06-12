using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Final.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string input1, string input2)
        {
            ViewBag.Message = Convert.ToInt32(input1) + Convert.ToInt32(input2);
            return View();
        }

        public ActionResult Result()
        {
            

            return View();
        }
        public class AdditionViewModel
        {
            public int input1 { get; set; }
            public int input2 { get; set; }
            public int Result { get; set; }
        }
    }
}