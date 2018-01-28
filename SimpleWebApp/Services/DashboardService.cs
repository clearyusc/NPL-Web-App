//using SimpleWebApp.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace SimpleWebApp.Services
//{
//    public class DashboardService
//    {
//        public static int CountRedLights(IList<Encounter> encounters)
//        {
//            return CountResponsesOfType(MinistryResponse.RedLight, encounters);
//        }

//        public static int CountYellowLights(IList<Encounter> encounters)
//        {
//            return CountResponsesOfType(MinistryResponse.YellowLight, encounters);
//        }

//        public static int CountGreenLights(IList<Encounter> encounters)
//        {
//            return CountResponsesOfType(MinistryResponse.GreenLight, encounters);
//        }

//        public static int CountBelieversNoTraining(IList<Encounter> encounters)
//        {
//            return CountResponsesOfType(MinistryResponse.BelieverDoesNotWantTraining, encounters);
//        }

//        public static int CountBelieversYesTraining(IList<Encounter> encounters)
//        {
//            return CountResponsesOfType(MinistryResponse.BelieverWantsTraining, encounters);
//        }

//        private static int CountResponsesOfType(MinistryResponse type, IList<Encounter> encounters)
//        {
//            int count = 0;
//            foreach (var encounter in encounters)
//            {
//                //if (encounter.Response == type)
//                //    count++;
//            }
//            return count;
//        }
//    }
//}
