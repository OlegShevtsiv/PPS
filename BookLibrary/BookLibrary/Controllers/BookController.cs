using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace BookLibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _service;
        public BookController(IBookService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}