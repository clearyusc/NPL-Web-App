using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleWebApp.Models;

namespace SimpleWebApp.Services
{
    public class SqlEncounter : IEncounter
    {
        public Person Person { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<MinistryAction> Actions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MinistryResponse Response { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Notes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Timestamp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
