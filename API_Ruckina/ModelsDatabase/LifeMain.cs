
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.ModelsDatabase
{
    public class LifeMain : Base
    {
        public double Family { get; set; }
        public double CareerMoney { get; set; }
        public double FamePower { get; set; }
        public double Entertainment { get; set; }
        public double Science { get; set; }
        public double SelfDevelopment { get; set; }
        public LifeMain(double family, double careerMoney, double famePower, double entertainment, double science, double selfDevelopment, int partyId, int id)
        {
            Family = family;
            CareerMoney = careerMoney;
            FamePower = famePower;
            Entertainment = entertainment;
            Science = science;
            SelfDevelopment = selfDevelopment;
            PartyId = partyId;
            Id = id;
        }
    }
}
