﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleWebApp.Context;
using SimpleWebApp.Models;

namespace SimpleWebApp.Services
{
    public class SqlEncounter : IEncounter
    {
        private DefaultContext _context;
        public SqlEncounter(DefaultContext context)
        {
            _context = context;
        }
        public Person Person { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<MinistryAction> Actions { get; set;  }
        public MinistryResponse Response { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Notes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Timestamp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IList<MinistryAction> IEncounter.Actions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddMinistryAction(MinistryAction action)
        {
            throw new NotImplementedException();
        }
    }
}