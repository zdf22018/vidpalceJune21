using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;

namespace VidPlace.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();
          
            return View(customers);
        }


        private IEnumerable<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            Customer c1 = new Customer();
            Customer c2 = new Customer();
            Customer c3 = new Customer();

            c1 = new Customer { Name = "Anna", ID = 2, };

            c2 = new Customer { Name = "John", ID = 3, };
            c3 = new Customer { Name = "Samuel", ID = 4, };
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

            return customers;

        }

        public ActionResult Details (int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.ID == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
    }
}