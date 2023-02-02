namespace AppAmalt.ModelsDatabase
{
    public class Gender : Base
    {
        public double WomenFollower { get; set; }
        public double MenFollower { get; set; }

        public Gender(double womenFollower, double menFollower, int partyId, int id)
        {
            WomenFollower = womenFollower;
            MenFollower = menFollower;
        }


    }
}
