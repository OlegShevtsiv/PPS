﻿using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Library.Models;
using DataAccess;
namespace Library.Controllers
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}