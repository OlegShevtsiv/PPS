using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult GetAuthor()
        {
            ViewData["Message"] = "Some given author message";

            return View();
        }
    }
}