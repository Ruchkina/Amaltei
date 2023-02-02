using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    public class Personal
    {

        [JsonProperty("political")]
        public int Political { get; set; }

        [JsonProperty("langs")]
        public List<string> Langs { get; set; }

        [JsonProperty("religion")]
        public string Religion { get; set; }

        [JsonProperty("inspired_by")]
        public string Inspired_by { get; set; }

        [JsonProperty("people_main")]
        public int People_main { get; set; }

        [JsonProperty("life_main")]
        public int Life_main { get; set; }

        [JsonProperty("smoking")]
        public int Smoking { get; set; }

        [JsonProperty("alcohol")]
        public int Alcohol { get; set; }
    }
}
