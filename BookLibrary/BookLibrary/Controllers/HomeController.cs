using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookLibrary.Models;
using DataAccess;
using Services.Interfaces;

namespace BookLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _service;
       
        public HomeController(IBookService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetAll().ToList());
            //return View();
        }

        public IActionResult GetAuthorInfo()
        {
            return View();
        }


        public IActionResult GetBookInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetBookInfo(string id)
        {
            return View(_service.Get(id));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
