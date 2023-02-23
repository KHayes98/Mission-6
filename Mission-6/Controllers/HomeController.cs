using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = _movieContext.Categories.ToList();

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
            var movies =_movieContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Category).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit (int movieid)
        {
            ViewBag.Categories = _movieContext.Categories.ToList();

            var movie = _movieContext.Responses.Single(x => x.MovieID == movieid);

            return View("Database", movie);
        }
        [HttpPost]
        public IActionResult Edit (MovieForm ar)
        {
            _movieContext.Update(ar);
            _movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        public IActionResult Delete ()
        {
            return View();
        }

    }
}
