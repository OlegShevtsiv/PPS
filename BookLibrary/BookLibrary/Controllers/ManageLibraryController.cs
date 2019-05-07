using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Services.DTO;
using BookLibrary.ViewModels.ManageLibrary;

namespace BookLibrary.Controllers
{
    public class ManageLibraryController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        public ManageLibraryController(IBookService bookService, IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;

        }

        public IActionResult Index()
        {
            return View(_bookService.GetAll().ToList());
        }

        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(AddBookViewModel model)
        {
            if (ModelState.IsValid)
            {
                BookDTO newBook = new BookDTO {
                    Title = model.Title,
                    AuthorId = model.AuthorId,
                    Genre = model.Genre,
                    Rate = model.Rate,
                    Description = model.Description,
                    ImagePath = model.ImagePath,
                    Year = model.Year };
                // add new book
                _bookService.Add(newBook);
            }
            return RedirectToAction("Index");
        }

        //public IActionResult EditBook()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult DeleteBook(string id)
        {
            _bookService.Remove(id);
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public IActionResult EditBook()
        //{
        //    return View();
        //}

        public IActionResult AuthorsList() => View(_authorService.GetAll().ToList());



        public IActionResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAuthor(AddAuthorViewModel model)
        {
            if (ModelState.IsValid)
            {
                AuthorDTO newAuthor = new AuthorDTO
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    Description = model.Description
                };
                // add new author
                _authorService.Add(newAuthor);
            }
            return RedirectToAction("AuthorsList");
        }

        //public IActionResult EditAuthor()
        //{
        //    return View();
        //}


        //[HttpPost]
        //public IActionResult EditAuthor()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult DeleteAuthor(string id)
        {
            _authorService.Remove(id);
            return RedirectToAction("AuthorsList");
        }

    }
}