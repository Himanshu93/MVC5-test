using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProtemTest.Models;

namespace ProtemTest.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        // GET: Customer/Details/id
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer==null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // get customer list
        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer {Id = 1, Name="customer1" },
                new Customer {Id = 2, Name="customer2" }
            };
        }
    }
}