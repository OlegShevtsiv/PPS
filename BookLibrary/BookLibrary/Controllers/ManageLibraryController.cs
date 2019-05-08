using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Services.DTO;
using BookLibrary.ViewModels.ManageLibrary;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace BookLibrary.Controllers
{
    [Authorize(Roles = "library admin")]
    public class ManageLibraryController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        public ManageLibraryController(IBookService bookService, IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;

        }

        public IActionResult Index() => View(_bookService.GetAll().ToList());

        public IActionResult AddBook()
        {
            ViewBag.Authors = _authorService.GetAll().ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(AddBookViewModel model)
        {
            if (ModelState.IsValid)
            {
                BookDTO newBook = new BookDTO
                                {
                                    Title = model.Title,
                                    AuthorId = model.AuthorId,
                                    Genre = model.Genre,
                                    Rate = model.Rate,
                                    Description = model.Description,      
                                    Year = model.Year
                                };
                if (model.Image != null && model.FileBook != null)
                {
                    byte[] imageData = null;
                    using (var binaryReader = new BinaryReader(model.Image.OpenReadStream()))
                    {
                        imageData = binaryReader.ReadBytes((int)model.Image.Length);
                    }
                    newBook.Image = imageData;

                    byte[] fileData = null;
                    using (var binaryReader = new BinaryReader(model.FileBook.OpenReadStream()))
                    {
                        fileData = binaryReader.ReadBytes((int)model.FileBook.Length);
                    }
                    newBook.FileBook = fileData;
                }
               
                _bookService.Add(newBook);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditBook(string id)
        {
            ViewBag.Authors = _authorService.GetAll().ToList();

            BookDTO getedBook = _bookService.Get(id);
            EditBookViewModel model = new EditBookViewModel {
                Id = getedBook.Id,
                Title = getedBook.Title,
                AuthorId = getedBook.AuthorId,
                Rate = getedBook.Rate,
                Year = getedBook.Year,
                Description = getedBook.Description,
                Genre = getedBook.Genre
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult EditBook(EditBookViewModel model)
        {
            if (ModelState.IsValid)
            {
                BookDTO editedBook = new BookDTO
                {
                    Id = model.Id,
                    Title = model.Title,
                    AuthorId = model.AuthorId,
                    Genre = model.Genre,
                    Rate = model.Rate,
                    Description = model.Description,
                    Year = model.Year
                };
                if (model.Image != null && model.FileBook != null)
                {
                    byte[] imageData = null;
                    using (var binaryReader = new BinaryReader(model.Image.OpenReadStream()))
                    {
                        imageData = binaryReader.ReadBytes((int)model.Image.Length);
                    }
                    editedBook.Image = imageData;

                    byte[] fileData = null;
                    using (var binaryReader = new BinaryReader(model.FileBook.OpenReadStream()))
                    {
                        fileData = binaryReader.ReadBytes((int)model.FileBook.Length);
                    }
                    editedBook.FileBook = fileData;
                }

                _bookService.Update(editedBook);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteBook(string id)
        {
            _bookService.Remove(id);
            return RedirectToAction("Index");
        }

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

        public IActionResult EditAuthor(string id)
        {
            AuthorDTO model = _authorService.Get(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult EditAuthor(AuthorDTO model)
        {
      
            if (ModelState.IsValid)
            {
                _authorService.Update(model);
            }
            return RedirectToAction("AuthorsList");
        }

        [HttpPost]
        public IActionResult DeleteAuthor(string id)
        {
            _authorService.Remove(id);
            return RedirectToAction("AuthorsList");
        }

    }
}