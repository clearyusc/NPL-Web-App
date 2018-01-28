using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleWebApp.Context;
using SimpleWebApp.Models;
using System.Threading.Tasks;

namespace SimpleWebApp.Controllers
{

    public class HomeController : InjectedController
    {
        private UserData dashboard;
        public HomeController(DefaultContext context) : base(context)
        {
            dashboard = UserData.Instance;
        }
        public IActionResult Index()
        {
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
        public async Task<IActionResult> SaveEncounter([FromForm] EncounterViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var encounter = new Encounter();
            //if (viewModel != null)
            //{
            //    if (viewModel.Gospel)
            //        encounter.MinistryActions.Add(new MinistryAction(3));
            //    if (viewModel.Prayer)
            //        encounter.MinistryActions.Add(new MinistryAction(2));
            //    if (viewModel.Testimony)
            //        encounter.MinistryActions.Add(new MinistryAction(1));
            //}

            encounter.Response = viewModel.Response;
            encounter.Person.FirstName = viewModel.NameOfPerson;
            encounter.Notes = viewModel.Notes;
            encounter.Timestamp = DateTime.Now;

            await db.Encounters.AddAsync(encounter);
            //encounter.MinistryActions.ForEach(ma => db.MinistryActions.AddAsync(ma));

            //await db.AddAsync(encounter);
            await db.SaveChangesAsync();

            //dashboard.Encounters.Add(encounter);

            return View("Index");
        }

    }
}
