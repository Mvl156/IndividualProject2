using IndividueelProjectSemester2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IndividueelProjectSemester2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            AccountViewModel accountViewModel = new AccountViewModel();
            accountViewModel.Username = "Harrie";
            accountViewModel.Password = "test";


            return View(accountViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Henk()
        {
            AccountViewModel accountViewModel = new AccountViewModel();
            accountViewModel.Username = "Harrie";
            accountViewModel.Password = "test";


            return View(accountViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
