using SimpleWebApp.Services;
using System;
using System.Collections.Generic;

namespace SimpleWebApp.Models
{
    public enum MinistryAction { Prayer, Testimony, Gospel, Train };
    public enum MinistryResponse { Undefined, RedLight, YellowLight, GreenLight, BelieverWantsTraining, BelieverDoesNotWantTraining };

    public interface IEncounter
    {
        Person Person { get; set; }
        IList<MinistryAction> Actions { get; set; }
        MinistryResponse Response { get; set; }
        string Notes { get; set; }
        DateTime Timestamp { get; set; }
        Guid Id { get; set; }

        void AddMinistryAction(MinistryAction action);
    }

    public class Encounter : IEncounter
    {
        public Person Person { get; set; }
        public IList<MinistryAction> Actions { get; set; }
        public MinistryResponse Response { get; set; } = MinistryResponse.Undefined;
        public string Notes { get; set; }
        public DateTime Timestamp { get; set; }
        public Guid Id { get; set; }

        public Encounter()
        {
            Actions = new List<MinistryAction>();
            Person = new Person();
            Id = (Id == null) ? Guid.NewGuid() : Id;
        }

        public void AddMinistryAction(MinistryAction action)
        {
            Actions.Add(action);
        }
    }
}