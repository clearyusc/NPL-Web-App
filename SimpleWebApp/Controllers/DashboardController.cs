using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Context;
using SimpleWebApp.Models;
using SimpleWebApp.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleWebApp.Controllers
{
    public class DashboardController : Controller
    {
        private EncounterRepository db;
        public DashboardController()
        {
            // TODO: Change this to a singleton?
            db = new EncounterRepository();
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var query = db.GetEncounters();

            ViewData["PrayCount"] = query.Where(e => e.MinistryActions.Contains(MinistryAction.Prayer)).Count().ToString();
            ViewData["TestimonyCount"] = query.Where(e => e.MinistryActions.Contains(MinistryAction.Testimony)).Count().ToString();
            ViewData["GospelCount"] = query.Where(e => e.MinistryActions.Contains(MinistryAction.Gospel)).Count().ToString();

            ViewData["RedCount"] = query.Where(e => e.MinistryResponse == MinistryResponse.RedLight).Count().ToString();
            ViewData["YellowCount"] = query.Where(e => e.MinistryResponse == MinistryResponse.YellowLight).Count().ToString();
            ViewData["GreenCount"] = query.Where(e => e.MinistryResponse == MinistryResponse.GreenLight).Count().ToString();
            ViewData["DoesNotWantTraining"] = query.Where(e => e.MinistryResponse == MinistryResponse.BelieverDoesNotWantTraining).Count().ToString();
            ViewData["WantsTraining"] = query.Where(e => e.MinistryResponse == MinistryResponse.BelieverWantsTraining).Count().ToString();

            // todo: refactor stuff here, add calls to the service to calculate totals, etc.
            //var encounters = await db.Encounters.ToAsyncEnumerable().ToList();
            var encounters = query.OrderByDescending(e => e.Timestamp).ToList();

            return View(encounters);
        }
    }
}
