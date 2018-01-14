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
        public HomeController()
        {
            dashboard = DashboardViewModel.Instance;
            ViewData["NumberOfEncounters"] = dashboard.Encounters.Count;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [HttpPost]
        public IActionResult IncrementPrayersCountBy(int number = 0)
        {
            //  encounter.Actions.Add(MinistryAction.Prayer);
            return View("Index");
        }

        [HttpPost]
        public IActionResult IncrementTestimonyCountBy(int number = 0)
        {
            // model.NumberOfShares += number;
            return View("Index");
        }

        [HttpPost]
        public IActionResult IncrementGospelCountBy(int number = 0)
        {
            //Console.WriteLine()
            // model.NumberOfShares += number;
            return View("Index");
        }

        [HttpPost]
        public IActionResult SaveEncounter(EncounterViewModel viewModel)
        {
            var encounter = new Encounter();
            if (viewModel != null)
            {
                if (viewModel.gospel)
                    encounter.Actions.Add(MinistryAction.Gospel);
                if (viewModel.prayer)
                    encounter.Actions.Add(MinistryAction.Prayer);
                if (viewModel.testimony)
                    encounter.Actions.Add(MinistryAction.Testimony);
            }

            dashboard.Encounters.Add(encounter);

            ViewData["NumberOfEncounters"] = encounter.Actions.Count;

            return View("Index");
        }

    }
}
