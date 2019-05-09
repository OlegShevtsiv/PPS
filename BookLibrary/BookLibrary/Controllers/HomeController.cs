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
        private readonly ICommentService _commentService;

        public HomeController(IBookService bookService, IAuthorService authorService, ICommentService commentService)
        {
            _bookService = bookService;
            _authorService = authorService;
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View(_bookService.GetAll().ToList());
        }

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

        [Authorize]
        [HttpPost]
        public IActionResult CommentBook(string ownerId, string bookId, string text)
        {
            if (string.IsNullOrEmpty(ownerId) || string.IsNullOrEmpty(bookId) || string.IsNullOrEmpty(text))
            {
                RedirectToAction("Error");
            }
            CommentDTO newComment = new CommentDTO
            {
                OwnerId = ownerId,
                CommentedEssenceId = bookId,
                Text = text
            };
            _commentService.Add(newComment);
            //return PartialView("CommentPartial", bookId);
            return RedirectToAction("GetBookInfo", "Home", new { id = bookId});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
