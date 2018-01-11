using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Models;

namespace SimpleWebApp.Controllers
{

    public class HomeController : Controller
    {
        private DashboardViewModel model;
        private Encounter encounter;
        public HomeController()
        {
            model = DashboardViewModel.Instance;
            encounter = new Encounter();
        }
        public IActionResult Index()
        {
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View(model);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View(model);
        }

        public IActionResult Error()
        {
            return View(model);
        }

        [HttpPost]
        public IActionResult IncrementPrayersCountBy(int number = 0)
        {
            encounter.Actions.Add(MinistryAction.Prayer);
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult IncrementTestimonyCountBy(int number = 0)
        {
            model.NumberOfShares += number;
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult IncrementGospelCountBy(int number = 0)
        {
            //Console.WriteLine()
            model.NumberOfShares += number;
            return View("Index", model);
        }

    }
}
