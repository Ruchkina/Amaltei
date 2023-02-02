
using System.Collections.Generic;

namespace AppAmalt.Dto
{
    public class GraphCityDto 
    {
        public List<CityDto> CityDtos { get; set; }

        public GraphCityDto(List<CityDto> cityDtos)
        {
            CityDtos = cityDtos;
        }
    }
}
