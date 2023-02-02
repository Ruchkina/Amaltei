
using AppAmalt.Dto;
using AppAmalt.ModelsGraph;

public static class CityDtoConverter
{
    public static CityDto Convert(CityModal city)
    {
        return new CityDto(
            name : city.Name,
            value : city.Value);

    }
}