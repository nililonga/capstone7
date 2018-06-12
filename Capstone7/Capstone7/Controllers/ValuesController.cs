using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Capstone7.Models;



namespace Capstone7.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
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
        public List<Product> GetProductByName(string id)
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
        public List<Customer> GetCustomerByLastName(string name)
        {
            NorthwndEntities db = new NorthwndEntities();
            List<Customer> Custos = (from c in db.Customers
                                     where c.ContactName.Split(' ').Contains(name)
                                     select c).ToList();

            return Custos;
        }
        public Customer GetCustomerByID(string ID)
        {
            NorthwndEntities db = new NorthwndEntities();
            Customer Custo = (from c in db.Customers
                              where c.CustomerID == ID
                              select c).Single();
            return Custo;
        }
        public List<Customer> GetCustomerByCountry(string country)
        {
            NorthwndEntities db = new NorthwndEntities();
            List<Customer> Custo = (from c in db.Customers
                                    where c.Country.Contains(country)
                                    select c).ToList();
            return Custo;
        }
    }
}
