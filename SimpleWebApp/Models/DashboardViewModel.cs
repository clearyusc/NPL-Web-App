using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Models
{
    public class DashboardViewModel
    {

        public IList<Encounter> Encounters { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private static DashboardViewModel instance;
        private DashboardViewModel()
        {
            Encounters = new List<Encounter>();
        }

        public static DashboardViewModel Instance
        { 
            get
            {
                if (instance == null)
                {
                    instance = new DashboardViewModel();
                }
                return instance;
            }
        }
        
    }
}
