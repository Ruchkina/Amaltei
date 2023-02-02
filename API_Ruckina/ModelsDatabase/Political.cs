namespace AppAmalt.ModelsDatabase
{
    public class Political : Base
    {

        public double Communists { get; set; }
        public double Socialists { get; set; }
        public double Moderate { get; set; }
        public double Liberals { get; set; }
        public double Conservatives { get; set; }
        public double Indifferents { get; set; }

        public Political(double communists, double socialists, double moderate, double liberals, double conservatives, double indifferents)
        {
            Communists = communists;
            Socialists = socialists;
            Moderate = moderate;
            Liberals = liberals;
            Conservatives = conservatives;
            Indifferents = indifferents;
        }
    }
}
