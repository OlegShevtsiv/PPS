using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookLibrary.Models;
using DataAccess;

namespace BookLibrary.Controllers
{
    public class HomeController : Controller
    {
        LibraryContext db;
        public HomeController(LibraryContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Books.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
