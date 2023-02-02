
using AppAmalt.Dto;
using AppAmalt.ModelsGraph;

public static class GraphPortraitDtoConverter
{
    public static GraphPortraitDto Convert(GraphPortrait portrait)
    {
        return new GraphPortraitDto(
                sex: portrait.Sex,
                occupation: portrait.Occupation,
                lifeMain: portrait.LifeMain,
                relation: portrait.Relation,
                political: portrait.Political,
                city: portrait.City,
                age: portrait.Age);

    }
}