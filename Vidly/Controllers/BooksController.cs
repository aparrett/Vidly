using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class BooksController : Controller
    {
        public ApplicationDbContext _context;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var books = _context.Books.ToList();
            return View(books);
        }

        public ActionResult Details(int id)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == id);

            if (book == null)
                return HttpNotFound();

            return View(book);
        }
    }
}