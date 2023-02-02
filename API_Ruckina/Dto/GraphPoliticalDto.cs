
using Newtonsoft.Json;


namespace AppAmalt.Dto
{
    public class GraphPoliticalDto 
    {
        public GraphPoliticalDto(double communists, double socialists, double moderate, double liberals, double conservatives, double indifferents)
        {
            Communists = communists;
            Socialists = socialists;
            Moderate = moderate;
            Liberals = liberals;
            Conservatives = conservatives;
            Indifferents = indifferents;
        }

        [JsonProperty("communists")]
        public double Communists { get; set; }
        [JsonProperty("socialists")]
        public double Socialists { get; set; }
        [JsonProperty("moderate")]
        public double Moderate { get; set; }
        [JsonProperty("liberals")]
        public double Liberals { get; set; }
        [JsonProperty("conservatives")]
        public double Conservatives { get; set; }
        [JsonProperty("indifferents")]
        public double Indifferents { get; set; }

    }
}
