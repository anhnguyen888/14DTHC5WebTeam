using _14DTHC5Web.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace _14DTHC5Web.Controllers
{
    public class BooksController : Controller
    {
        private List<Book> listBooks;
        //Constructor
        public BooksController()
        {
            this.listBooks = new List<Book>();
            listBooks.Add(new Book()
            {
                BookId = 1,
                Title = "Dac Nhan Tam",
                Author = "D.C",
                Year = 2010,
                Cover = "Content/images/book-1.png"
            });
            listBooks.Add(new Book()
            {
                BookId = 2,
                Title = "Pro ASP .NET MVC",
                Author = "Freeman, Adam",
                Year = 2013,
                Cover = "Content/images/book-2.png"
            });
            listBooks.Add(new Book()
            {
                BookId = 3,
                Title = "Clean Code",
                Author = "...",
                Year = 2010,
                Cover = "Content/images/book-3.png"
            });
        }
        // GET: Books
        public ActionResult Index()
        {
            return View();
        }

        public string HelloBook(string book)
        {
            return "This is book controller! " + book;
        }

        public ActionResult GetListBooks()
        {
            return View("ListBooks", listBooks);
        }

        public ActionResult Edit(int id)
        {
            Book book = listBooks.Find(s => s.BookId == id);

            if (book == null)
                return HttpNotFound();

            return View(book);
        }

        [HttpPost]
        public ActionResult Edit(Book book)
        {
            //Server validation
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Server validation !!!");
                return View();
            }
            Book b = listBooks.Find(s => s.BookId == book.BookId);

            if (b == null)
                return HttpNotFound();
            //update
            b.Title = book.Title;
            b.Author = book.Author;
            b.Year = book.Year;
            b.Cover = book.Cover;

            return View("ListBooks", listBooks);
        }
    }
}