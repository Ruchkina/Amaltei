using AppAmalt.Dto;
using Newtonsoft.Json;


namespace AppAmalt.ModelsGraph
{
    public class GraphAge
    {
        public GraphAge(double less20Age, double between20_30Age, double between30_40Age, double between40_60Age, double over60)
        {
            Less20Age = less20Age;
            Between20_30Age = between20_30Age;
            Between30_40Age = between30_40Age;
            Between40_60Age = between40_60Age;
            Over60 = over60;
        }

        [JsonProperty("less20Age")]
        public double Less20Age { get; set; }
        [JsonProperty("between20_30Age")]
        public double Between20_30Age { get; set; }
        [JsonProperty("between30_40Age")]
        public double Between30_40Age { get; set; }
        [JsonProperty("between40_60Age")]
        public double Between40_60Age { get; set; }
        [JsonProperty("over60")]
        public double Over60 { get; set; }

    }
}
