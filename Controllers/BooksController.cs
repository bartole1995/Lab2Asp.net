using LibApp_Gr6.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp_Gr6.ViewModels;


namespace LibApp_Gr6.Controllers
{
    public class BooksController : Controller
    {
        //ctrl+kc komentarz
        public IActionResult Random()
        {
            var firstBook = new Book() { Name = "English dictionary" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 1"}
            };

            var viewModel = new RandomBookViewModel
            {
                Book = firstBook,
                Customers = customers
            };

            return View(viewModel);
        }

        public IActionResult Index()
        {
            var books = GetBooks();
            return View(books);
        }

        [Route("books/released/{year:regex(^\\d{{4}}$)}/{month:range(1,12)}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        private IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book {Id = 1, Name = "Hamlet"},
                new Book {Id = 2, Name = "Quo Vadis"}
            };
        }
    }
}
