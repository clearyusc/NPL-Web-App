using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Models
{
    public class EncounterViewModel
    {
        public bool testimony { get; set; } = false;
        public bool prayer { get; set; } = false;
        public bool gospel { get; set; } = false;
        public MinistryResponse response { get; set; } = MinistryResponse.Undefined;
    }
}
