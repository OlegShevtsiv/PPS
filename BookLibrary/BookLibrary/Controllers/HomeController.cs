using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookLibrary.Models;
using DataAccess;
using Services.Interfaces;
using Services.DTO;
using Microsoft.AspNetCore.Authorization;

namespace BookLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;

        public HomeController(IBookService bookService, IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_bookService.GetAll().ToList());
        }

        [HttpGet]
        public IActionResult GetAuthorInfo(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                RedirectToAction("Error");
            }
            AuthorDTO currentAuthor = _authorService.Get(id);
            if (currentAuthor == null)
            {
                return RedirectToAction("Error");
            }
            return View(currentAuthor);
        }

        [HttpGet]
        public IActionResult GetBookInfo(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                RedirectToAction("Error");
            }
            BookDTO currentBook = _bookService.Get(id);
            if (currentBook == null)
            {
                return RedirectToAction("Error");
            }
            return View(currentBook);
        }

        [Authorize]
        public IActionResult DownloadBook(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                RedirectToAction("Error");
            }
            BookDTO book = _bookService.Get(id);
            if (book == null)
            {
                return RedirectToAction("Error");
            }
            string file_type = "application/pdf";
            string file_name = book.Title + ".pdf";

            return File(book.FileBook, file_type, file_name);
        }

        // поміняти!!!

        [Authorize]
        [HttpPost]
        public IActionResult RateBook(BookDTO ratedBook)
        {
            BookDTO book = _bookService.Get(ratedBook.Id);
            if (book == null)
            {
                return RedirectToAction("Error");
            }
            uint amount = book.RatesAmount;
            book.RatesAmount++;
            book.Rate = (book.Rate * amount + ratedBook.Rate) / book.RatesAmount;

            _bookService.Update(book);
            return RedirectToAction("GetBookInfo", "Home", new { id = book.Id });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
