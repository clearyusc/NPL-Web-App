using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Models;
using SimpleWebApp.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleWebApp.Controllers
{
    public class DashboardController : Controller
    {
        private DashboardViewModel dashboard;
        private DashboardService service;
        public DashboardController()
        {
            dashboard = DashboardViewModel.Instance;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            // todo: refactor stuff here, add calls to the service to calculate totals, etc.
            return View(dashboard);
        }
    }
}
