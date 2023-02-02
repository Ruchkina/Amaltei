
using AppAmalt.Dto;
using AppAmalt.ModelsGraph;

public static class GraphLifeMainDtoConverter
{
    public static GraphLifeMainDto Convert(GraphLifeMain lifeMain)
    {
        return new GraphLifeMainDto(
                family: lifeMain.Family,
                careerMoney: lifeMain.CareerMoney,
                famePower: lifeMain.FamePower,
                entertainment: lifeMain.Entertainment,
                science: lifeMain.Science,
                selfDevelopment: lifeMain.SelfDevelopment);

    }
}