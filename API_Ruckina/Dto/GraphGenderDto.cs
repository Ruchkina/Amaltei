using AppAmalt.Dto;
using Newtonsoft.Json;


namespace AppAmalt.Dto
{
    public class GraphGenderDto 
    { 
        public GraphGenderDto(double man, double woman)
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
