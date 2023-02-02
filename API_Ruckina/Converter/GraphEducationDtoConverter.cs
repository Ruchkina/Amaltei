
using AppAmalt.Dto;
using AppAmalt.ModelsGraph;

public static class GraphEducationDtoConverter
{
    public static GraphEducationDto Convert(GraphEducation education)
    {
        return new GraphEducationDto(
                university: education.University,
                work: education.Work,
                school: education.School);

    }
}