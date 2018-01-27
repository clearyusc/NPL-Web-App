﻿using SimpleWebApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleWebApp.Models
{
    public enum MinistryActionOptions { Prayer, Testimony, Gospel };
    public enum MinistryResponse { Undefined, RedLight, YellowLight, GreenLight, BelieverWantsTraining, BelieverDoesNotWantTraining };
    public class MinistryAction
    {
        [Required]
        public virtual Encounter Encounter { get; set; }

        public Guid Id { get; set; }
        public int Action { get; set; }
        public MinistryAction(int _action)
        {
            Action = _action;
            Id = Guid.NewGuid();
        }
    }

    public interface IEncounter
    {
        Person Person { get; set; }
        List<MinistryAction> Actions { get; set; }
        MinistryResponse Response { get; set; }
        string Notes { get; set; }
        DateTime Timestamp { get; set; }
        Guid Id { get; set; }

        //void AddMinistryAction(MinistryAction action);
    }

    public class Encounter : IEncounter
    {
        public Person Person { get; set; }
        public MinistryResponse Response { get; set; } = MinistryResponse.Undefined;
        public string Notes { get; set; }
        public DateTime Timestamp { get; set; }
        public Guid Id { get; set; }

        public virtual List<MinistryAction> Actions { get; set; }

        public Encounter()
        {
            Actions = new List<MinistryAction>();
            Person = new Person();
            Id = (Id == null) ? Guid.NewGuid() : Id;
        }

        public void AddMinistryAction(int action)
        {
            Actions.Add(new MinistryAction(action));
        }
    }
}