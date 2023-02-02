
using AppAmalt.Dto;
using AppAmalt.ModelsGraph;

public static class GraphGenderDtoConverter
{
    public static GraphGenderDto Convert(GraphGender gender)
    {
        return new GraphGenderDto(
            man : gender.Man,
            woman : gender.Woman);

    }
}