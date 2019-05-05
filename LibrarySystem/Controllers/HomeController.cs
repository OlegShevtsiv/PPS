using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Library.Models;
using DataAccess;
using DataAccess.Implementation;
using DataAccess.Models;
using Services.Interfaces;
using Services.Implementation;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        LibraryContext db;
        private readonly IBookService _bookService;
        public HomeController(LibraryContext context)
        {
            db = context;
        }

        public HomeController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            return View(db.Books.ToList());
        }

        [HttpGet]
        public IActionResult GetBookInfo(Book book)
        {
            //string Authors = "";
            //for (int i = 0; i < book.Authors.Count - 1; i++)
            //{
            //    Authors += $"{book.Authors[i].Name} {book.Authors[i].Surname}, ";
            //}
            //Authors += $"{book.Authors[book.Authors.Count - 1].Name} {book.Authors[book.Authors.Count - 1].Surname}";
            //ViewBag.BookAuthors = Authors;

            //string genres = "";
            // for (int i = 0; i < book.Genres.Count - 1; i++)
            // {
            //     genres += $"{book.Genres[i].ToString()}, ";
            // }
            // genres += book.Genres[book.Genres.Count - 1].ToString();
            //ViewBag.BookGenres = genres;
              
            return View("~/Views/Book/GetBookInfo.cshtml", book);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
