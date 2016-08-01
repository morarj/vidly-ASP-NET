using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            // Getting the list of customers from the private method
            var customers = GetCustomers();

            return View(customers);
        }

        // GET: Customers/Details
        public ActionResult Details(int id)
        {
            // With this you avoid the foreach loop
            // From c in customers
            // Where c.Id == id
            // Select c
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();
            else
                return View(customer);
        }

        // List of customers as private method
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
        }
    }
}