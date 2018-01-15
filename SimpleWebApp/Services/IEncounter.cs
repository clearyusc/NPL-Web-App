using SimpleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Services
{
    interface IEncounter
    {
        Person Person { get; set; }
        IList<MinistryAction> Actions { get; set; }
        MinistryResponse Response { get; set; }
        string Notes { get; set; }
        DateTime Timestamp { get; set; }

    }
}
