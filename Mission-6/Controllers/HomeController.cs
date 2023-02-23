using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission_6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_6.Controllers
{
    public class HomeController : Controller
    {
        private MovieDatabaseContext _movieContext { get; set; }

        public HomeController(MovieDatabaseContext someName)
        {
            _movieContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Database()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Database(MovieForm ar)
        {
            _movieContext.Add(ar);
            _movieContext.SaveChanges();

            return View("Confirmation", ar);
        }

        [HttpGet]
        public IActionResult MovieList ()
        {
            var movies =_movieContext.Responses.OrderBy(x => x.Category).ToList();

            return View(movies);
        }

    }
}
