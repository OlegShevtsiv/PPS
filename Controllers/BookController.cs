﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        public IActionResult GetBook()
        {
            ViewData["Message"] = "Lorem ipsum, bla bla bla. Book page";

            return View();
        }
    }
}