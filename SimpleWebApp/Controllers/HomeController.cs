using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleWebApp.Context;
using SimpleWebApp.Models;
using System.Threading.Tasks;
using SimpleWebApp.Repository;
using System.Linq;

namespace SimpleWebApp.Controllers
{

    public class HomeController : Controller
    {
        private EncounterRepository db;
        private UserData dashboard;
        public HomeController() 
        {
            dashboard = UserData.Instance;
            db = new EncounterRepository();
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

        //[HttpGet]
        //public void TestMongo()
        //{
        //    var person = new Person() { FirstName = "other person!" };
        //    Employee employee = new Employee() { Name = "Ryan", JoinedDate = DateTime.Now, EmployeeId = 1234, Person = person };
        //    db.AddEmployee(employee);
        //}

        //public void TestMongoRead()
        //{
        //    var empList = db.GetEmployees();
        //    foreach(var e in empList)
        //    {
        //        Console.WriteLine(e.Name + e.Position + e.JoinedDate + e.Id);
        //    }
        //}

        [HttpPost]
        public async Task<IActionResult> SaveEncounter([FromForm] EncounterViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var encounter = new Encounter();
            if (viewModel != null)
            {
                if (viewModel.Gospel)
                    encounter.MinistryActions.Add(MinistryAction.Gospel);
                if (viewModel.Prayer)
                    encounter.MinistryActions.Add(MinistryAction.Prayer);
                if (viewModel.Testimony)
                    encounter.MinistryActions.Add(MinistryAction.Testimony);
            }

            encounter.MinistryResponse = viewModel.Response;
            encounter.PersonEncountered.FirstName = viewModel.NameOfPerson;
            encounter.Notes = viewModel.Notes;
            encounter.Timestamp = DateTime.Now;

            // todo: remove below if we don't use EF and MySql
            //await db.Encounters.AddAsync(encounter);
            //encounter.MinistryActions.ForEach(ma => db.MinistryActions.AddAsync(ma));

            //await db.AddAsync(encounter);
            //await db.SaveChangesAsync();

            db.AddEncounter(encounter);

            return View("Index");
        }

    }
}
