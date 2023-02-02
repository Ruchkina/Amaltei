
using AppAmalt.ModelsGraph;

namespace AppAmalt.Dto
{
    public class ResponseDto 
    {
        public ResponseDto(GraphPortraitDto portrait, GraphAgeDto graphAge, GraphGenderDto graphGender, GraphLifeMainDto graphLifeMain, GraphPoliticalDto graphPolitical, GraphCityDto graphCity, GraphRelationDto graphRelation, GraphEducationDto graphEducation)
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

        public GraphPortraitDto Portrait { get; set; }
        public GraphAgeDto GraphAge { get; set; }
        public GraphLifeMainDto GraphLifeMain { get; set; }
        public GraphPoliticalDto GraphPolitical { get; set; }
        public GraphGenderDto GraphGender { get; set; }
        public GraphCityDto GraphCity { get; set; }
        public GraphRelationDto GraphRelation { get; set; }
        public GraphEducationDto GraphEducation { get; set; }






        /*public ResponseDto(PortraitDto portrait, GraphAgeDto graphAge, GraphLifeMainDto graphLifeMain, GraphPoliticalDto graphPolitical, GraphGenderDto graphGender, GraphCityDto graphCity, GraphRelationDto graphRelation, GraphEducationDto graphEducation)
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


        public PortraitDto Portrait { get; set; }
        public GraphAgeDto GraphAge { get; set; }
        public GraphLifeMainDto GraphLifeMain { get; set; }
        public GraphPoliticalDto GraphPolitical { get; set; }
        public GraphGenderDto GraphGender { get; set; }
        public GraphCityDto GraphCity { get; set; }
        public GraphRelationDto GraphRelation { get; set; }
        public GraphEducationDto GraphEducation { get; set; }*/


    }
}
