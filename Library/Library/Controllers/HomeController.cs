using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Models;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult BookList()
        {
            Library2Entities db = new Library2Entities();
            List<book> books = db.books.ToList();
            ViewBag.Books = books;
            ViewBag.Statuses = db.Statuses.ToList();
            return View();
        }
        //filter by status
        
        public ActionResult BookListByStatus(int status)
        {
            Library2Entities db = new Library2Entities();
            //LINQ Query
            List<book> books = (from b in db.books
                               where b.Status == status select b).ToList();
                               
            ViewBag.Books = books;
            ViewBag.Statuses = db.Statuses.ToList();
            return View("BookList"
                );
        }
        //filter
        public ActionResult BookListByAuthor(string author)
        {
            Library2Entities db = new Library2Entities();
            //LINQ Query
            List<book> books = (from b in db.books
                                where b.Author.Contains(author)
                                select b).ToList();

            ViewBag.Books = books;
            ViewBag.Statuses = db.Statuses.ToList();

            return View("BookList"
                );
        }
        public ActionResult BookListSorted(string column)
        {
            Library2Entities db = new Library2Entities();
            //LINQ Query

            if (column == "Title")
            {
                List<book> books = (from b in db.books
                                    orderby b.Title
                                    select b).ToList();
                ViewBag.Books = books;
            }
            else if (column == "Author")
            {
                List<book> books = (from b in db.books
                                    orderby b.Author
                                    select b).ToList();
                ViewBag.Books = books;
            }
            else if (column == "Status")
            {
                List<book> books = (from b in db.books
                                    orderby b.Status
                                    select b).ToList();
                ViewBag.Books = books;
            }
            else if (column == "YearPublished")
            {
                List<book> books = (from b in db.books
                                    orderby b.YearPublished
                                    select b).ToList();
                ViewBag.Books = books;
            }
            
            ViewBag.Statuses = db.Statuses.ToList();

            return View("BookList"
                );
        }
        public ActionResult Add(int id)
        {
            Library2Entities db = new Library2Entities();
            //check if cart object already exists
            if (Session["Cart"] == null)
            {
                //if it doesn't, make new list of books
                List<book> cart = new List<book>();
                //add this book to it
                cart.Add ((from b in db.books where b.Ranking == id select b).Single());
                //add the list to the session
                Session.Add("Cart", cart);
            }
            else
            {
                //if it does exist, get the list
                List<book> cart = (List<book>)(Session["Cart"]);
                //add this book to it
                cart.Add((from b in db.books where b.Ranking == id select b).Single());
                //add it back to the session
                    //Session["Cart"] = cart;
            }
            return View();
        }
    }
}