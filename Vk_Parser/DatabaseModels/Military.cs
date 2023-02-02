using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    public class Military
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }
        [JsonProperty("unit_id")]
        public int Unit_id { get; set; }
        [JsonProperty("country_id")]
        public int Country_id { get; set; }
        [JsonProperty("from")]
        public int From { get; set; }
        [JsonProperty("until")]
        public int Until { get; set; }
    }
}
