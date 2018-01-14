using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Models
{
    public class EncounterViewModel
    {
        public bool Testimony { get; set; } = false;
        public bool Prayer { get; set; } = false;
        public bool Gospel { get; set; } = false;
        public MinistryResponse Response { get; set; }
        public string NameOfPerson { get; set; }
        public string Notes { get; set; }
        public DateTime Timestamp { get; set; }

        public EncounterViewModel()
        {
            Response = MinistryResponse.Undefined;
        }
    }
}
