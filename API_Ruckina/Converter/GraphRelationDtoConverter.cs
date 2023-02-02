
using AppAmalt.Dto;
using AppAmalt.ModelsGraph;

public static class GraphRelationDtoConverter
{
    public static GraphRelationDto Convert(GraphRelation relation)
    {
        return new GraphRelationDto(
                married: relation.Married,
                notMarried: relation.NotMarried,
                haveFriend: relation.HaveFriend,
                civilMerriage: relation.CivilMerriage,
                engagement: relation.Engagement,
                activeResearch: relation.ActiveResearch);

    }
}