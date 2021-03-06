﻿using System;
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
using Microsoft.AspNetCore.Identity;

namespace BookLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IRateService _rateService;

        public HomeController(IBookService bookService, IAuthorService authorService, UserManager<IdentityUser> userManager, IRateService rateService)
        {
            _bookService = bookService;
            _authorService = authorService;
            _userManager = userManager;
            _rateService = rateService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_bookService.GetAll().ToList());
        }
      
        [HttpPost]
        public IActionResult Search(string req)
        {
            if (string.IsNullOrEmpty(req))
            {
                return RedirectToAction("Index");
            }
            List<BookDTO> param = new List<BookDTO>();
            List<string> keys = req.Trim().Split(' ').ToList();
            List<BookDTO> allBooks = _bookService.GetAll().ToList();
            for(int i = 0; i < keys.Count; i++)
            {
                keys[i] = keys[i].ToLower().Trim();
                foreach  (BookDTO book  in allBooks)
                {
                    if (book.Title.ToLower().Contains(keys[i]))
                    {
                        if (!param.Exists(b => b.Id == book.Id))
                        {
                            param.Add(book);
                        }
                    }
                    if (book.Year.ToString() == keys[i])
                    {
                        if (!param.Exists(b => b.Id == book.Id))
                        {
                            param.Add(book);
                        }
                    }
                    if (book.Genre.ToLower().ToString().Contains(keys[i]))
                    {
                        if (!param.Exists(b => b.Id == book.Id))
                        {
                            param.Add(book);
                        }
                    }
                    if (_authorService.Get(book.AuthorId).Name.ToLower() == keys[i])
                    {
                        if (!param.Exists(b => b.Id == book.Id))
                        {
                            param.Add(book);
                        }
                    }
                    if (_authorService.Get(book.AuthorId).Surname.ToLower() == keys[i])
                    {
                        if (!param.Exists(b => b.Id == book.Id))
                        {
                            param.Add(book);
                        }
                    }
                }
            }

            var result = param.Distinct().ToList();

            return View("~/Views/Home/Index.cshtml", result);
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


        [Authorize]
        [HttpPost]
        public IActionResult RateBook(string bookId, string userId, decimal rate)
        {
            if (string.IsNullOrEmpty(bookId) || string.IsNullOrEmpty(userId) || rate < 1 || rate > 5)
            {
                RedirectToAction("Error");
            }
            BookDTO bookTORate = _bookService.Get(bookId);
            if (bookTORate == null)
            {
                return RedirectToAction("Error");
            }
            RateDTO yourRate = new RateDTO { BookId = bookId, UserId = userId, Value = rate};
            List<RateDTO> allRates = _rateService.GetAll().ToList();
            if (allRates != null)
            {
                bool isFinded = false;
                foreach (var r in allRates)
                {
                    if (r.BookId == bookId && r.UserId == userId)
                    {
                        isFinded = true;
                        yourRate.Id = r.Id;
                        bookTORate.Rate = (bookTORate.Rate * bookTORate.RatesAmount - r.Value + rate) / bookTORate.RatesAmount;
                        _rateService.Update(yourRate);
                        _bookService.Update(bookTORate);
                        break;
                    }
                }
                if (!isFinded)
                {
                    uint amount = bookTORate.RatesAmount;
                    bookTORate.RatesAmount++;
                    bookTORate.Rate = (bookTORate.Rate * amount + rate) / bookTORate.RatesAmount;
                    _bookService.Update(bookTORate);
                    _rateService.Add(yourRate);
                }
            }
            else
            {
                uint amount = bookTORate.RatesAmount;
                bookTORate.RatesAmount++;
                bookTORate.Rate = (bookTORate.Rate * amount + rate) / bookTORate.RatesAmount;
                _bookService.Update(bookTORate);
                _rateService.Add(yourRate);
            }
            
            return RedirectToAction("GetBookInfo", "Home", new { id = bookTORate.Id });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
