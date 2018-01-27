using SimpleWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Models
{
    public interface IUserData
    {
        IList<IEncounter> Encounters { get; }
        IPerson User { get; set; }

        void AddEncounter(IEncounter encounter);
        IEncounter GetEncounter(Guid id);
        void DeleteEncounter(Guid id);
    }

    public class UserData : IUserData
    {
        public IList<IEncounter> Encounters { get; }
        public IPerson User { get; set; }

        private static UserData instance;
        private UserData()
        {
            Encounters = new List<IEncounter>();
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

        public void AddEncounter(IEncounter encounter)
        {
            ((List<IEncounter>)Encounters).Add(encounter);
        }

        public IEncounter GetEncounter(Guid id)
        {
            return Encounters.First(e => e.Id == id);
        }

        public void DeleteEncounter(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
