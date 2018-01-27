using SimpleWebApp.Context;
using SimpleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Services
{
    public class SqlUserData : IUserData
    {
        private DefaultContext _context;

        public SqlUserData(DefaultContext context)
        {
            _context = context;
        }
        public IList<IEncounter> Encounters {
            get => _context.Encounters.OrderBy(e => e.Timestamp).ToList();
            set => throw new NotImplementedException();
        }
        public Person User { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IPerson IUserData.User { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public void AddEncounter(IEncounter encounter)
        {
            _context.Encounters.Add(encounter);
            _context.SaveChanges();
        }

        public void DeleteEncounter(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEncounter GetEncounter(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}