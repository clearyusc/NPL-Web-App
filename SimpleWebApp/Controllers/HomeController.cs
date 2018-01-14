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
                if (viewModel.Gospel)
                    encounter.Actions.Add(MinistryAction.Gospel);
                if (viewModel.Prayer)
                    encounter.Actions.Add(MinistryAction.Prayer);
                if (viewModel.Testimony)
                    encounter.Actions.Add(MinistryAction.Testimony);
            }

            encounter.Response = viewModel.Response;
            encounter.Person.FirstName = viewModel.NameOfPerson;
            encounter.Notes = viewModel.Notes;
            encounter.Timestamp = DateTime.Now;

            dashboard.Encounters.Add(encounter);

            ViewData["NumberOfEncounters"] = encounter.Actions.Count;

            return View("Index");
        }

    }
}
