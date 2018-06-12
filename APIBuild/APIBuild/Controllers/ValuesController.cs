using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIBuild.Models;

namespace APIBuild.Controllers
{
    public class ValuesController : ApiController
    {
        int hits = 0;
        // GET api/values/5
        public int Get()
        {
            hits++;
            return hits;
        }

        public  Card GetCard()
        {
            Card c = new Card();
            c.suit = "Hearts";
            c.value = "Queen";

            return c;
        }
        public List<Product> GetCatalog()
        {
            NorthwndEntities db = new NorthwndEntities();
            List<Product> products = db.Products.ToList();
            db.P
            return products;
        }

        public Product GetProduct(int id)
        {
            NorthwndEntities db = new NorthwndEntities();
            Product prod = (from p in db.Products where p.ProductID == id select p).Single();

            return prod;
        }
        public List<Product> GetProductByName (string id)
        {
            NorthwndEntities db = new NorthwndEntities();
            List<Product> prod = (from p in db.Products where p.ProductName.Contains(id) select p).ToList();

            return prod;
        }
        public List<Customer> GetCustomer()
        {
            NorthwndEntities db = new NorthwndEntities();
            List<Customer> Custos = (from c in db.Customers select c).ToList();
            return Custos;
        }
        public List<Customer>GetCustomerByLastName (string name)
        {
            NorthwndEntities db = new NorthwndEntities();
            List<Customer> Custos = (from c in db.Customers
                                     where c.ContactName.Split(' ').Contains(name)
                                     select c).ToList();

            return Custos;
        }
        public Customer GetCustomerByID (string ID)
        {
            NorthwndEntities db = new NorthwndEntities();
            Customer Custo = (from c in db.Customers
                              where c.CustomerID == ID
                              select c).Single();
            return Custo;
        }
        public List<Customer> GetCustomerByCountry (string country)
        {
            NorthwndEntities db = new NorthwndEntities();
            List<Customer> Custo = (from c in db.Customers
                                    where c.Country.Contains(country)
                                    select c).ToList();
            return Custo;
        }

    }
}
