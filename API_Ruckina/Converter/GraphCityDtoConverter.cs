
using AppAmalt.Dto;
using AppAmalt.ModelsGraph;
using System.Collections.Generic;

public static class GraphCityDtoConverter
{
    public static GraphCityDto Convert(GraphCity city)
    {
        List<CityDto> DataCityDto = new List<CityDto>();
        foreach (CityModal oneCity in city.Cities)
            DataCityDto.Add(CityDtoConverter.Convert(oneCity));

        return new GraphCityDto(
            cityDtos : DataCityDto);

    }
}