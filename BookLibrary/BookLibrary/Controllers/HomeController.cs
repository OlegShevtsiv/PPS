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

        public IActionResult Index()
        {
            return View(_bookService.GetAll().ToList());
        }

        public IActionResult GetAuthorInfo(string id)
        {
            AuthorDTO currentAuthor = _authorService.Get(id);
            if (currentAuthor == null)
            {
                return RedirectToAction("Error");
            }
            return View(currentAuthor);
        }


        public IActionResult GetBookInfo(string id)
        {
            
            BookDTO currentBook = _bookService.Get(id);
            if (currentBook == null)
            {
                return RedirectToAction("Error");
            }
            ViewBag.Author = _authorService.Get(currentBook.AuthorId);
            return View(currentBook);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
