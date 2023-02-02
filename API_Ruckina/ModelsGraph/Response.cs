

using AppAmalt.Dto;

namespace AppAmalt.ModelsGraph
{
    public class Response 
    {
        public Response(GraphPortrait portrait, GraphAge graphAge, GraphGender graphGender, GraphLifeMain graphLifeMain, GraphPolitical graphPolitical, GraphCity graphCity, GraphRelation graphRelation, GraphEducation graphEducation)
        {
            Portrait = portrait;
            GraphAge = graphAge;
            GraphLifeMain = graphLifeMain;
            GraphPolitical = graphPolitical;
            GraphGender = graphGender;
            GraphCity = graphCity;
            GraphRelation = graphRelation;
            GraphEducation = graphEducation;
        }

        public GraphPortrait Portrait { get; set; }
        public GraphAge GraphAge { get; set; }
        public GraphLifeMain GraphLifeMain { get; set; }
        public GraphPolitical GraphPolitical { get; set; }
        public GraphGender GraphGender { get; set; }
        public GraphCity GraphCity { get; set; }
        public GraphRelation GraphRelation { get; set; }
        public GraphEducation GraphEducation { get; set; }

    }





}
