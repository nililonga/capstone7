using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookiesNotes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       /* public ActionResult About()
        {
            //declare [1]
            HttpCookie cookie;
            
            if (Request.Cookies["Counter"] == null)
            {
                //make cookie [2]
                cookie = new HttpCookie("Counter");
                cookie.Value = "0";
                
            }

            int visits = int.Parse(cookie.Value);
            visits++;

            cookie.Expires = DateTime.Now.AddDays(14);

            else
            {
                //read cookie[3]
                cookie = Request.Cookies["Counter"];

            }
            ViewBag.Message = "Your application description page.";

            return View();
        }*/

        public ActionResult Contact()
        {
            if(Session["Counter"] == null)
            {
                Session.Add("Counter", 0);
            }
            int visits = (int)Session["Counter"];
            visits++;

            Session["Counter"] = visits;
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return View();
        }
    }
}