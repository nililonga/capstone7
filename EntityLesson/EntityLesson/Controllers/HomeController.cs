using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityLesson.Models;

namespace EntityLesson.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            InventoryEntities ORM = new InventoryEntities();

            ViewBag.Items = ORM.Items.ToList();
            ViewBag.Customers = ORM.Customers.ToList();
            return View();
        }

        public ActionResult About(Item data)
        {

            InventoryEntities ORM = new InventoryEntities(); 

            if (ModelState.IsValid)
            {
                ORM.Items.Add(data);
                ORM.SaveChanges();
                ViewBag.Messagee = $"{data.Description} has been added";
            }
            else
            {
                ViewBag.message = "Item was not valid, cannot add to database";
            }

            return View();
        }

        public ActionResult Contact(int ID)
        {
            InventoryEntities ORM = new InventoryEntities();

            DbContextTransaction DeleteCustomerTransaction = ORM.Database.BeginTransaction();
            Item temp = new Item();
            try
            {
                temp = ORM.Items.Find(ID);
                ORM.Items.Remove(temp);
                ORM.SaveChanges();
                DeleteCustomerTransaction.Commit();
                ViewBag.Message = $"{temp.Description} was removed";
            }

            catch (Exception ex)
            {
                DeleteCustomerTransaction.Rollback();
                ViewBag.Message = "Item could not be removed";
            }
            return View();
        }


        public ActionResult ItemView(string descrip)
        {

            InventoryEntities ORM = new InventoryEntities();

            /*ViewBag.Items = ORM.Items.Where(x => x.Email == Email).ToList();
            List<Item> ItemList = ORM.Items.ToList();
           

            foreach(Item I in ItemList)
            {
                if(I.Description == descrip)
                {
                    newItems.Add(I);
                }
            }*/
            return View();
        }
    }
}