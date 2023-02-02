using AppAmalt.Dto;
using Newtonsoft.Json;


namespace AppAmalt.ModelsGraph
{
    public class GraphRelation 
    {
        public GraphRelation(int married, int notMarried, int haveFriend, int civilMerriage, int engagement, int activeResearch)
        {
            Married = married;
            NotMarried = notMarried;
            HaveFriend = haveFriend;
            CivilMerriage = civilMerriage;
            Engagement = engagement;
            ActiveResearch = activeResearch;
        }

        [JsonProperty("married")]
        public int Married { get; set; }
        [JsonProperty("notMarried")]
        public int NotMarried { get; set; }
        [JsonProperty("haveFriend")]
        public int HaveFriend { get; set; }
        
        [JsonProperty("civilMerriage")]
        public int CivilMerriage { get; set; }
        [JsonProperty("engagement")]
        public int Engagement { get; set; }
        [JsonProperty("activeResearch")]
        public int ActiveResearch { get; set; }
    }
}
