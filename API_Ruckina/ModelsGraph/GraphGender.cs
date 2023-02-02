using Newtonsoft.Json;


namespace AppAmalt.ModelsGraph
{
    public class GraphGender
    { 
        public GraphGender(double man, double woman)
        {
            Man = man;
            Woman = woman;
        }

        [JsonProperty("man")]
        public double Man { get; set; }
        [JsonProperty("woman")]
        public double Woman { get; set; }


    }
}
