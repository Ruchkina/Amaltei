namespace AppAmalt.ModelsDatabase
{
    public class City
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public City(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
