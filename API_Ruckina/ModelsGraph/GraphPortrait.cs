﻿namespace AppAmalt.ModelsGraph
{
    public class GraphPortrait 
    {
        public GraphPortrait(string sex, string occupation, string lifeMain, string relation, string political, string city, string age)
        {
            Sex = sex;
            Occupation = occupation;
            LifeMain = lifeMain;
            Relation = relation;
            Political = political;
            City = city;
            Age = age;
        }

        public string Sex { get; set; }

        public string Occupation { get; set; }

        public string LifeMain { get; set; }
  
        public string Relation { get; set; }

        public string Political { get; set; }

        public string City { get; set; }

        public string Age { get; set; }



    }
}
