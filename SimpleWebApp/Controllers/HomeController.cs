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
        private DashboardViewModel dashboard;
        private Encounter model;
        public HomeController()
        {
            dashboard = DashboardViewModel.Instance;
            model = new Encounter();
            ViewData["NumberOfEncounters"] = dashboard.Encounters.Count;
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
            //  encounter.Actions.Add(MinistryAction.Prayer);
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult IncrementTestimonyCountBy(int number = 0)
        {
            // model.NumberOfShares += number;
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult IncrementGospelCountBy(int number = 0)
        {
            //Console.WriteLine()
            // model.NumberOfShares += number;
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult SaveEncounter(Encounter encounter)
        {
            var prayer = encounter.prayer;
            //var prayer = Request.Form["prayerButton"];
            //var testimony = Request.Form["testimonyButton"];
            //var gospel = Request.Form["gospelButton"];

            if (prayer)
            {
                ViewData["NumberOfEncounters"] = "Prayer!";
            } else
            {
                ViewData["NumberOfEncounters"] = "no prayer :(";
            }

            return View("Index");
        }

    }
}
