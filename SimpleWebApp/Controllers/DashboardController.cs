using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Context;
using SimpleWebApp.Models;
using SimpleWebApp.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleWebApp.Controllers
{
    public class DashboardController : InjectedController
    {
        private UserData dashboard;
        private DashboardService service;
        public DashboardController(DefaultContext context) : base(context)
        {
            dashboard = UserData.Instance;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            // todo: refactor stuff here, add calls to the service to calculate totals, etc.
            var encounters = await db.Encounters.ToAsyncEnumerable().ToList();
            dashboard.Encounters = encounters;

            return View(dashboard);
        }
    }
}
