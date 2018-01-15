using SimpleWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Models
{
    public class UserData
    {

        public IList<Encounter> Encounters { get; set; }
        public Person User { get; set; }

        private static UserData instance;
        private UserData()
        {
            Encounters = new List<Encounter>();
        }

        public static UserData Instance
        { 
            get
            {
                if (instance == null)
                {
                    instance = new UserData();
                }
                return instance;
            }
        }
        
    }
}
