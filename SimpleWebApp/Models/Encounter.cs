using System.Collections.Generic;

namespace SimpleWebApp.Models
{
    public enum MinistryAction { Prayer, Testimony, Gospel, Train };
    public enum MinistryResponse { Undefined, RedLight, YellowLight, GreenLight, BelieverWantsTraining, BelieverDoesNotWantTraining };

    public class Encounter
    {
        public Person Person { get; set; }
        public IList<MinistryAction> Actions { get; set; }
        public MinistryResponse Response { get; set; }


        public Encounter()
        {
            Actions = new List<MinistryAction>();
        }
    }
}