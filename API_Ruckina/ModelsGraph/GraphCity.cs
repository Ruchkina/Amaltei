
using System.Collections.Generic;

namespace AppAmalt.ModelsGraph 
{
    public class GraphCity 
    {
        public List<CityModal> Cities { get; set; }

        public GraphCity(List<CityModal> cities)
        {
            Cities = cities;
        }
    }
}
