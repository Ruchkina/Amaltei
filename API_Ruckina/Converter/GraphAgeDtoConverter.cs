
using AppAmalt.Dto;
using AppAmalt.ModelsGraph;

public static class GraphAgeDtoConverter
{
    public static GraphAgeDto Convert(GraphAge age)
    {
        return new GraphAgeDto(
            less20Age: age.Less20Age,
            between20_30Age: age.Between20_30Age,
            between30_40Age: age.Between30_40Age,
            between40_60Age: age.Between40_60Age,
            over60: age.Over60);

    }
}