
using AppAmalt.Dto;
using AppAmalt.ModelsGraph;

public static class ResponseDtoConverter
{
    public static ResponseDto ConvertToDto(Response response)
    {
        return new ResponseDto(
                portrait: GraphPortraitDtoConverter.Convert(response.Portrait),
                graphAge: GraphAgeDtoConverter.Convert(response.GraphAge),
                graphGender: GraphGenderDtoConverter.Convert(response.GraphGender),
                graphLifeMain: GraphLifeMainDtoConverter.Convert(response.GraphLifeMain),
                graphPolitical: GraphPoliticalDtoConverter.Convert(response.GraphPolitical),
                graphCity: GraphCityDtoConverter.Convert(response.GraphCity),
                graphRelation: GraphRelationDtoConverter.Convert(response.GraphRelation),
                graphEducation: GraphEducationDtoConverter.Convert(response.GraphEducation));

    }
}