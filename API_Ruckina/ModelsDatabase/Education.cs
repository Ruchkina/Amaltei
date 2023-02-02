namespace AppAmalt.ModelsDatabase
{
    public class Education : Base
    {
        public Education(int university, int work, int school)
        {
            University = university;
            Work = work;
            School = school;
        }

        //University,Work,School : 
        public int University { get; set; }
        public int Work { get; set; }
        public int School { get; set; }
    }
}
