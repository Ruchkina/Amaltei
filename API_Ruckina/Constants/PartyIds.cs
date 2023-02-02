using System;
using System.Collections.Generic;

namespace AppAmalt.Constants
{
    public static class PartyId
    {
        public enum PartyIds
        {
            NewPeople = 1,
            EdinayRussia = 2,
            LDPR = 3,
            KPRF = 4,
            SpravedlivayRussia = 5,
            NonParlament = 6
        };

        public static int GetValue(string enumName)
        {
            int result = (int)Enum.Parse(typeof(PartyIds), enumName);
            return result;
        }

    }
    
}
