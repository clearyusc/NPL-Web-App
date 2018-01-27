using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Context;

namespace SimpleWebApp.Controllers
{
    // Helper class to take care of db context injection.
    public class InjectedController : Controller
    {
        protected readonly DefaultContext db;

        public InjectedController(DefaultContext context)
        {
            db = context;
        }
    }
}
