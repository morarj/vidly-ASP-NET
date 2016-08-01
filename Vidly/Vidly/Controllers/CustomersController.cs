using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };

            var viewModel = new CustomerListViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        // GET: Customers/Details
        public ActionResult Details(int id)
        {
            bool exists = false;
            Customer model = new Customer();

            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };

            foreach(var customer in customers)
            {
                if(customer.Id == id)
                {
                    exists = true;
                    model = customer;
                }
            }

            if (!exists)
                return HttpNotFound();
            else
                return View(model);
        }
    }
}