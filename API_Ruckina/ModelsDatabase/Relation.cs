namespace AppAmalt.ModelsDatabase
{
    public class Relation : Base
    {
        public Relation(int married, int notMarried, int haveFriend, int civilMerriage, int engagement, int activeResearch)
        {
            Married = married;
            NotMarried = notMarried;
            HaveFriend = haveFriend;
            CivilMerriage = civilMerriage;
            Engagement = engagement;
            ActiveResearch = activeResearch;
        }

        public int Married { get; set; }
        public int NotMarried { get; set; }
        public int HaveFriend { get; set; }
        public int CivilMerriage { get; set; }
        public int Engagement { get; set; }
        public int ActiveResearch { get; set; }

    }
}
