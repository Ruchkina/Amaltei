
using AppAmalt.Dto;
using AppAmalt.ModelsGraph;

public static class GraphPoliticalDtoConverter
{
    public static GraphPoliticalDto Convert(GraphPolitical political)
    {
        return new GraphPoliticalDto(
                 communists: political.Communists,
                socialists: political.Socialists,
                moderate: political.Moderate,
                liberals: political.Liberals,
                conservatives: political.Conservatives,
                indifferents: political.Indifferents);

    }
}