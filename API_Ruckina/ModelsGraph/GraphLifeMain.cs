using Newtonsoft.Json;

namespace AppAmalt.ModelsGraph
{
    [JsonObject]
    public class GraphLifeMain 
    {
        public GraphLifeMain(double family, double careerMoney, double famePower, double entertainment, double science, double selfDevelopment)
        {
            Family = family;
            CareerMoney = careerMoney;
            FamePower = famePower;
            Entertainment = entertainment;
            Science = science;
            SelfDevelopment = selfDevelopment;
        }

        [JsonProperty("family")]
        public double Family { get; set; }

        [JsonProperty("career_money")]
        public double CareerMoney { get; set; }
        [JsonProperty("fame_power")]
        public double FamePower { get; set; }
        [JsonProperty("entertainment")]
        public double Entertainment { get; set; }
        [JsonProperty("science")]
        public double Science { get; set; }
        [JsonProperty("Self_development")]
        public double SelfDevelopment { get; set; }


    }
}
