using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp_Gr6.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibApp_Gr6.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public IActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(x => x.Id == id);

            if (customer == null)
            {
                return Content("User not found");
            }
            
            return View(customer);
            
        }
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer {Id = 1, Name = "Jan Kowalski"},
                new Customer {Id = 2, Name = "Monika Nowak"}
            };
        }
    }
}
