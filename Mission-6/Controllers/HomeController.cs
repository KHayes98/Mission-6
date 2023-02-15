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
        private readonly ILogger<HomeController> _logger;
        private MovieDatabaseContext _movieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieDatabaseContext someName)
        {
            _logger = logger;
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
