using AppAmalt.Dto;
using Newtonsoft.Json;

namespace AppAmalt.ModelsGraph
{
    public class GraphEducation
    {
        public GraphEducation(int university, int work, int school)
        {
            University = university;
            Work = work;
            School = school;
        }

        [JsonProperty("university")]
        public int University { get; set; }
        [JsonProperty("work")]
        public int Work { get; set; }
        [JsonProperty("school")]
        public int School { get; set; }

    }
}
