namespace AppAmalt.ModelsDatabase
{
    public class Portrait : Base
    {
        public Portrait(string sex, string occupation, string lifeMain, string relation, string political, int cityId, string age)
        {
            Sex = sex;
            Occupation = occupation;
            LifeMain = lifeMain;
            Relation = relation;
            Political = political;
            CityId = cityId;
            Age = age;
        }

        public string Sex { get; set; }
        public string Occupation { get; set; }
        public string LifeMain { get; set; }
        public string Relation { get; set; }
        public string Political { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public string Age { get; set; }



    }
}
